using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBuildFinalProject.Models;

namespace DevBuildFinalProject.Services
{
    public interface ICharacterDataService
    {
        public int AddPlayer(Character character);
        public IEnumerable<Character>GetAllCharacters();
        public int AssignStarterDeck(int id);
        //remove character
        //edit character
    }
}
