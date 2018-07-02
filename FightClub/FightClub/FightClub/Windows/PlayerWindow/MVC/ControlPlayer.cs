using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    abstract class ControlPlayer : MediatorsElement, IMVCElement
    {
        public ControlPlayer(MainMediator m) : base(m)
        {

        }
        public abstract void HeadHit(object sender, EventArgs e);
        public abstract void BodyHit(object sender, EventArgs e);
        public abstract void LegsHit(object sender, EventArgs e);

        abstract public void SendWindow(Window w);
    }
}
