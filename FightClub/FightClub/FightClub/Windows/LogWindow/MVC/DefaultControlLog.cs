using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class DefaultControlLog : ControlLog
    {
        public DefaultControlLog(MainMediator mm) : base(mm)
        {

        }
        public override void ClearLog(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void SendWindow(Window w)
        {
            throw new NotImplementedException();
        }
    }
}
