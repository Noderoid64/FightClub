using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IControlMenu : IMVCElement
    {
        void StartAIGame(object sender, EventArgs ea);
        void StartPlayerGame(object sender, EventArgs ea);
    }
}
