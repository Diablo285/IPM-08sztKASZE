using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.src.InterFaces;


namespace Core.src
{
    class CoreController : ICore
    {
        protected Int32 registeredGames;
        protected List<IGameApp> games;

        public CoreController()
        {
            registeredGames = 0;
            games = new List<IGameApp>();
        }

        public void register(IGameApp game)
        {
            games.Add(game);
            ++registeredGames;
        }
    }
}
