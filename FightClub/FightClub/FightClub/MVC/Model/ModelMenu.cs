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
        public IMainModelMenu ClearClick()
        {
            MessageBox.Show(Arena.FirstPlayer(new UserPlayer(),new UserPlayer()).ToString());
            return this;
           // throw new NotImplementedException();
        }

        public IMainModelMenu ExitClick()
        {
            throw new NotImplementedException();
        }

        public IMainModelMenu NewGameAI()
        {
            throw new NotImplementedException();
        }

        public IMainModelMenu NewGamePlayer()
        {
            throw new NotImplementedException();
        }

        public IMainModelMenu SettingsClick()
        {
            throw new NotImplementedException();
        }
    }
}
