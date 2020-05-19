using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        
    }
}
