using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.src.InterFaces;


namespace Core.src.Utils
{
    class GameAppWrapper : IGameApp
    {
        protected readonly IGameApp original;

        public Int32 Id
        {
            get;
            protected set;
        }


        public GameAppWrapper(IGameApp original, Int32 Id)
        {
            this.original = original;
            this.Id = Id;
        }

        public void Initialize(Structures.Player p1, Structures.Player p2)
        {
            this.original.Initialize(p1, p2);
        }
    }
}
