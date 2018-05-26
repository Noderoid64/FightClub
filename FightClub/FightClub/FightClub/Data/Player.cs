using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class Player
    {
        protected string Name;
        protected int HP;
        protected enum Part : int { Head, Body, Legs }
        protected Part Blocked;


        public abstract void GetHit();
        public abstract void SetBlock();
    }
}
