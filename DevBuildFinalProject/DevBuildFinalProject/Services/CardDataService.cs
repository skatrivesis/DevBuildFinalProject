using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildFinalProject.Services
{
    public class CardDataService : ICardDataService
    {
        private readonly string connString;

        public CardDataService(IConfiguration config)
        {
            connString = config.GetConnectionString("default");
        }

        public IEnumerable<Card> GetAllCards()
        {
            IEnumerable<Card> result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Cards";

                result = conn.Query<Card>(command, new {});
            }

            return result;
        }

        public IEnumerable<Card> GetDeck()
        {
            IEnumerable<Card> result;

            using (var conn = new SqlConnection(connString))
            {
                string command = "select * from Card where Card";

                result = conn.Query<Card>(command);
            }

            return result;
        }
    }
}
