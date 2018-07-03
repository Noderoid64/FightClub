using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public class Player
    {
        public event Action<PlayerArgs> Block;
        public event Action<PlayerArgs> Attack;
        public event Action<PlayerArgs> Death;

        public enum Part : int { Head, Body, Legs, NoTarget }

        public Player(string name, int hp = 100, int attackPower = 20)
        {
            this.name = name;
            this.attackPower = attackPower;
            this.maxHp = hp;
            this.hp = hp;
            blockedPart = Part.NoTarget;
        }

        public string name { get; protected set; }
        public int attackPower { get; private set; }
        public int maxHp { get; private set; }
        public int hp { get;private set; }
        public Part blockedPart { get; private set; }

        public void SetBlock(Part p)
        {
            blockedPart = p;
        }
        public void GetHit(Part p,int attackPower)
        {
            PlayerArgs pa = new PlayerArgs(name);
            pa.MaxHP = maxHp;
            pa.HP = hp;
            pa.Block = blockedPart;
            pa.Attack = p;
            pa.AttackPower = attackPower;
            
            if (blockedPart == p)
            {
                Block(pa);
            }
            else
            {
                hp -= attackPower;
                pa.HP = hp;
                if (hp <= 0)
                {
                    hp = 0;
                    Death( pa);
                }
                else                    
                Attack(pa);
            }
            blockedPart = Player.Part.NoTarget;


        }
    }
}
