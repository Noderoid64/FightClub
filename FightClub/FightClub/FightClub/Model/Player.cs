using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Player
    {
        public event EventHandler Block;
        public event EventHandler Attack;
        public event EventHandler Death;

        public enum BodyPart : int { Head, Body, Legs}
        BodyPart Blocked;
        string name;
        int hp;
        int attackPower;

        public void GetHit(BodyPart bp, int attackPower)
        {
            PlayerEventArgs PEA = new PlayerEventArgs(name, hp, Blocked);
            if (bp == Blocked)
            {                
                Block.Invoke(this,PEA);
            }
            else
            {
                hp -= attackPower;
                PEA.AfterHP = hp;
                PEA.AttackPart = bp;
                Attack.Invoke(this, PEA);
                if (hp <= 0)
                {
                    hp = 0;
                    Death.Invoke(this,PEA);
                }
                    
                
            }
                
        }
        public void SetBlock(BodyPart bp)
        {
            Blocked = bp;
        }

    }
}
