using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FightClub
{
    class UserPlayer : Player
    {
        public UserPlayer():base("default",100)
        {

        }
        public UserPlayer(string name,int hp) : base(name, hp)
        {

        }

        public override void GetHit(Part blocked)
        {
            if (Blocked == blocked)
                CallBlock(new PlayersEventArgs(Name, HP));
            else
            {
                HP -= damage;
                if (HP > 0)
                    CallWound(new PlayersEventArgs(Name, HP));
                else
                {
                    HP = 0;
                    CallDeath(new PlayersEventArgs(Name, HP));
                }
                    
            }
        }

        public override void SetBlock(Part target)
        {
            Blocked = target;
        }
    }
}
