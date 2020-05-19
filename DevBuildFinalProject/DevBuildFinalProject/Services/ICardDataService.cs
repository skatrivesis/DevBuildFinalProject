using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildFinalProject.Services
{
    public interface ICardDataService
    {
        //return all cards
        public IEnumerable<Card> GetAllCards();

        //return deck

        //return card by id
    }
}
