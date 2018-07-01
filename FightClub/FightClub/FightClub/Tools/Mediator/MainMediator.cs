using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class MainMediator : IMediator
    {
        private ControlLog controlLog;
        private ControlMenu controlMenu;
        private ControlPlayer controlPlayer;

        public ControlLog ControlLog
        {             
            set
            {
                controlLog = value;
            }
            private get
            {
                return controlLog;
            }
        }
        public ControlMenu ControlMenu
        {
            set
            {
                controlMenu = value;
            }
            private get
            {
                return controlMenu;
            }
        }
        public ControlPlayer ControlPlayer
        {
            set
            {
                controlPlayer = value;
            }
            private get
            {
                return ControlPlayer;
            }
        }

        public void Send(string Message, string obj)
        {
            throw new NotImplementedException();
        }
    }
}
