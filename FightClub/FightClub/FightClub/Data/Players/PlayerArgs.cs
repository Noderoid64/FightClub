using System;

namespace FightClub
{
    public class PlayerArgs : EventArgs
    {
        public string Name;
        public int MaxHP;
        public int HP;
        public int AttackPower;
        public Player.Part Block;
        public Player.Part Attack;

        public PlayerArgs(string name)
        {
            Name = name;
        }
    }
}
