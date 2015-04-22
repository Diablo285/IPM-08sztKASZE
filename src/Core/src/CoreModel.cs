using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Core.src.InterFaces;

namespace Core.src
{
    class CoreModel : ICore
    {
        protected Int32 registeredGames;
        protected ObservableCollection<IGameApp> games;
        
        public ObservableCollection<IGameApp> Games
        {
            get
            {
                return games;
            }
        }

        public Int32 GameNum
        {
            get
            {
                return registeredGames;
            }
        }

        public CoreModel()
        {
            registeredGames = 0;
            games = new ObservableCollection<IGameApp>();
        }

        public void register(IGameApp game)
        {
            ++registeredGames;
            games.Add(game);
        }
    }
}
