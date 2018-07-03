using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public abstract class FightRoomForTwo
    {
        public Player First { get; set; }
        public Player Second { get; set; }

        public FightRoomForTwo(Player first, Player second)
        {
            First = first;
            Second = second;
        }
        public abstract void SetPart(Player.Part part);
    }
}
