using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    internal class MainMediator : IMediator
    {
        private List<ControlLog> controlLog;
        private List<ControlMenu> controlMenu;
        private List<ControlPlayer> controlPlayer;

        public void AddControlLog(ControlLog cl)
        {
            if (!controlLog.Contains(cl))
                controlLog.Add(cl);
            else
                throw new Exception("ControlLog already added");
        }
        public void AddControlMenu(ControlMenu cm)
        {
            if (!controlMenu.Contains(cm))
                controlMenu.Add(cm);
            else
                throw new Exception("ControlMenu already added");
        }
        public void AddControlPlayer(ControlPlayer cp)
        {
            if (!controlPlayer.Contains(cp))
                controlPlayer.Add(cp);
            else
                throw new Exception("ControlPlayer already added");
        }

        public void RemoveControlLog(ControlLog cl)
        {
            if (controlLog.Contains(cl))
                controlLog.Remove(cl);
            else
                throw new Exception("ControlLog does not exist");
        }
        public void RemoveControlMenu(ControlMenu cl)
        {
            if (controlMenu.Contains(cl))
                controlMenu.Remove(cl);
            else
                throw new Exception("ControlMenu does not exist");
        }
        public void RemoveControlPlayer(ControlPlayer cp)
        {
            if (controlPlayer.Contains(cp))
                controlPlayer.Remove(cp);
            else
                throw new Exception("ControlPlayer does not exist");
        }


        internal MainMediator()
        {
            controlLog = new List<ControlLog>();
            controlMenu = new List<ControlMenu>();
            controlPlayer = new List<ControlPlayer>();
        }

        public void Send(string Message, string obj)
        {
            throw new NotImplementedException();
        }
    }
}
