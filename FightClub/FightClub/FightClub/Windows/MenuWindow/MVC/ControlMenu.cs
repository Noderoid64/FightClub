using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    abstract class ControlMenu : MediatorsElement IMVCElement
    {
        public ControlMenu(MainMediator m) : base(m)
        {

        }
        abstract public void SendWindow(Window w);

        abstract public void StartAIGame(object sender, EventArgs ea);
        abstract public void StartPlayerGame(object sender, EventArgs ea);
    }
}
