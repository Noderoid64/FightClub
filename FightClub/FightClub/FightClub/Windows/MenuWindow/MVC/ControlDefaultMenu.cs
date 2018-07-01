using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using FightClub.Windows.MenuWindow;

namespace FightClub
{
    class ControlDefaultMenu : IControlMenu
    {
        IModelMenu Model;

        public ControlDefaultMenu()
        {
           // Model = new 
        }
        public void SendWindow(Window w)
        {

            if (w.GetType() == typeof(MenuWindow))
            {
                ((MenuWindow)w).ButtonAI.Click += StartAIGame;
                ((MenuWindow)w).ButtonPlayer.Click += StartPlayerGame;
                Model.SendWindow(w);
            }
            else
                throw new Exception("Window does not inherit MenuWindow");
            
        }

        public void StartAIGame(object sender, EventArgs ea)
        {
            throw new NotImplementedException();
        }

        public void StartPlayerGame(object sender, EventArgs ea)
        {
            throw new NotImplementedException();
        }
    }
}
