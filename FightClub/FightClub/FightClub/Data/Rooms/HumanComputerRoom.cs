using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class HumanComputerRoom : FightRoomForTwo
    {
        public Player Human
        {
            get
            {
                return First;
            }
            private set
            {
                First = value;
            }
        }
        public Player Computer
        {
            get
            {
                return Second;
            }
            private set
            {
                First = Second;
            }
        }
        private Action<Player.Part> Stage;

        public HumanComputerRoom(Player human, Player computer) : base(first:human,second:computer)
        {
            Stage = HumanBlock;
        }

        public override void SetPart(Player.Part part)
        {
            Stage.Invoke(part);
        }
        private void HumanBlock(Player.Part part)
        {
            Human.SetBlock(part);
            Human.GetHit(DefaultBot.GetInst().SetTarget(), Computer.attackPower);
            Stage = ComputerBlock;
        }
        private void ComputerBlock(Player.Part part)
        {
            Computer.SetBlock(DefaultBot.GetInst().SetBlock());
            Computer.GetHit(part, Human.attackPower);
            Stage = HumanBlock;
        }
    }
}
