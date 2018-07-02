using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class HumanControlPlayer : ControlPlayer
    {
        public HumanControlPlayer (MainMediator mm) : base(mm)
        {

        }
        public override void BodyHit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void HeadHit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void LegsHit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void SendWindow(Window w)
        {
            throw new NotImplementedException();
        }
    }
}
