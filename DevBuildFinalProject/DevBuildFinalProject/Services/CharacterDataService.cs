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
            //character.HP = 20;
            //character.AP = 3;
            //character.Progress = 0;
            //character.Player = true;

            SqlConnection conn = new SqlConnection(connString);

            string command = "insert into Character (CharName, Hp, Ap, Progress, Player) ";
            command += "values (@CharName, @HP, @AP, @Progress, @Player)";

            int result = conn.Execute(command, character);

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
    }
}
