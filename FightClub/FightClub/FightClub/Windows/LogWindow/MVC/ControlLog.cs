using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    abstract class ControlLog : MediatorsElement,  IMVCElement
    {
        public ControlLog(MainMediator mm) : base(mm)
        {

        }

       public abstract void ClearLog(object sender, EventArgs e);

        abstract public void SendWindow(Window w);
    }
}
