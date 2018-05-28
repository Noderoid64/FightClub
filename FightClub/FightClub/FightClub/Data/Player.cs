using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    abstract class Player
    {
        protected const int damage = 20;
        public string Name { get; protected set; }
        public int HP { get; protected set; }
        public enum Part { Head, Body, Legs }
        protected Part Blocked;

        public Player(string name, int hp)
        {
            Name = name;
            HP = hp;
            
        }

        public event EventHandler <PlayersEventArgs> Block;
        public event EventHandler <PlayersEventArgs> Wound;
        public event EventHandler <PlayersEventArgs> Death;

        public void CallBlock(PlayersEventArgs arg)
        {
            Block.Invoke(null,arg);
        }
        public void CallWound(PlayersEventArgs arg)
        {
            Wound.Invoke(null, arg);
        }
        public void CallDeath(PlayersEventArgs arg)
        {
            Death.Invoke(null, arg);
        }

        public abstract void GetHit(Part target);
        public abstract void SetBlock(Part blocked);
    }

    class PlayersEventArgs : EventArgs
    {
        public string Name { get; private set; }
        public int HP { get; private set; }
        public PlayersEventArgs(string name, int hp)
        {
            Name = name;
            HP = hp;
        }
    }
}
