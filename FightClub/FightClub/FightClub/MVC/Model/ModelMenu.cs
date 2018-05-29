using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class ModelMenu : IMainModelMenu
    {
        public IMainView view { set; private get; }

        public void ClearClick()
        {

            view.CleanLog();
        }

        public void ExitClick()
        {
            Environment.Exit(0);

        }

        public void NewGameAI()
        {
            throw new NotImplementedException();
        }

        public void NewGamePlayer()
        {
            throw new NotImplementedException();
        }

        public void SettingsClick()
        {
            throw new NotImplementedException();
        }
    }
}
