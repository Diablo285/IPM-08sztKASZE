using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Core.src.InterFaces;
using Core.src.Utils;


using System.Collections.ObjectModel;

namespace Core.src
{
    class CoreViewModel : BaseViewModel
    {
        protected CoreModel model;

        public DelegateCommand LaunchGameCommand
        {
            get;
            protected set;
        }

        public ObservableCollection<IGameApp> GameList
        {
            get
            {
                return model.Games;
            }
        }

        public Int32 GameNum
        {
            get
            {
                return model.GameNum;
            }
        }

        public CoreViewModel()
        {
            model = new CoreModel();

            LaunchGameCommand = new DelegateCommand(param => { onGameLaunch(param); });

            // Register Game applications
        }

        private void onGameLaunch(object param)
        {
            Int32 Id = (Int32)param;
            IGameApp current = GameList[(int)Id];
        }
    }
}
