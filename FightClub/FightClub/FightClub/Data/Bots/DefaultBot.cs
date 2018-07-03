using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class DefaultBot : IBot
    {
        #region Singleton
        static DefaultBot Entity;
        private DefaultBot()
        {

        }
        public static DefaultBot GetInst()
        {
            if (Entity == null)
                Entity = new DefaultBot();
            return Entity;
        }
        #endregion
        public Player.Part SetBlock()
        {
            return (Player.Part)new Random().Next(0, 3);
        }

        public Player.Part SetTarget()
        {
            return (Player.Part)new Random().Next(0, 3);
        }
    }
}
