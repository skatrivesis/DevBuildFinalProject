using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using DevBuildFinalProject.Models;

namespace DevBuildFinalProject.Services
{
    public class CharacterDataService : ICharacterDataService
    {
        private readonly string connString;

        public CharacterDataService(IConfiguration config)
        {
            connString = config.GetConnectionString("default");
        }

        public int AddPlayer(Character character)
        {
            //This is where we can edit player attributes
            character.HP = 20;
            character.AP = 3;
            character.Progress = 0;
            character.Player = true;

            SqlConnection conn = new SqlConnection(connString);

            string command = "insert into Character (CharName, Hp, Ap, Progress, Player) ";
            command += "values (@CharName, @HP, @AP, @Progress, @Player) ";
            command += "select scope_identity()";

            int id = conn.ExecuteScalar<int>(command, character);

            int result = AssignStarterDeck(id);

            conn.Close();

            return result;
        }

        public IEnumerable<Character> GetAllCharacters()
        {
            SqlConnection conn = new SqlConnection(connString);

            string command = "SELECT * FROM Character";

            IEnumerable<Character> result = conn.Query<Character>(command);

            conn.Close();

            return result;
        }

        public int AssignStarterDeck(int id)
        {
            SqlConnection conn = new SqlConnection(connString);

            string command = "insert into Deck select @id as CharId, CardId from PremadeDeck where DeckId = 1";

            int result = conn.Execute(command, new { id = id });

            conn.Close();

            return result;
        }
    }
}
