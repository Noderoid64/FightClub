using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    internal class ControlDefaultMenu : ControlMenu
    {
        internal IModelMenu Model;

        public ControlDefaultMenu(MainMediator mm) : base(mm)
        {
            // Model = new 
        }
        public override void SendWindow(Window w)
        {

            if (w.GetType() == typeof(MenuWindow))
            {
                ((MenuWindow)w).ButtonAI.Click += StartAIGame;
                ((MenuWindow)w).ButtonPlayer.Click += StartPlayerGame;
                // Model.SendWindow(w);
            }
            else
                throw new Exception("Window does not inherit MenuWindow");

        }

        public override void StartAIGame(object sender, EventArgs ea)
        {
            throw new NotImplementedException();
        }

        public override void StartPlayerGame(object sender, EventArgs ea)
        {
            throw new NotImplementedException();
        }
    }
}
