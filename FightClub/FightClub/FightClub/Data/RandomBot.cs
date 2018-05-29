using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class RandomBot : IBot
    {
        public void Block(object sende, PlayersEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Death(object sende, PlayersEventArgs e)
        {
            throw new NotImplementedException();
        }
        public void Wound(object sende, PlayersEventArgs e)
        {
            throw new NotImplementedException();
        }

        public Player.Part MakeAttackDecision()
        {
            return (Player.Part)new Random().Next(0,2);
        }

        public Player.Part MakeDefDecision()
        {
            return (Player.Part)new Random().Next(0, 2);
        }

        
    }
}
