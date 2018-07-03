using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IBot
    {
        Player.Part SetBlock();
        Player.Part SetTarget();
    }
}
