using System;

namespace FightClub
{
    class PlayerEventArgs : EventArgs
    {
        public string Name;

        public int BeforeHP;
        public int AfterHP;

        public Player.BodyPart BlockedPart;
        public Player.BodyPart AttackPart;

        public PlayerEventArgs(string name, int afterHp, Player.BodyPart Part):this(name, afterHp,afterHp,Part,Part){}
        public PlayerEventArgs(string name, int beforeHP, int afterHP, Player.BodyPart blockedPart, Player.BodyPart attackPart)
        {
            Name = name;
            BeforeHP = beforeHP;
            AfterHP = afterHP;
            BlockedPart = blockedPart;
            AttackPart = attackPart;
        }
    }
}
