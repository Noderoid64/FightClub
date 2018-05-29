using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IBot
    {
        void Block(object sende, PlayersEventArgs e);
        void Wound(object sende, PlayersEventArgs e);
        void Death(object sende, PlayersEventArgs e);

        Player.Part MakeDefDecision();
        Player.Part MakeAttackDecision();

    }
}
