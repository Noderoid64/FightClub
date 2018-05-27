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
            throw new NotImplementedException();
        }

        public override void SetBlock(Part target)
        {
            throw new NotImplementedException();
        }
    }
}
