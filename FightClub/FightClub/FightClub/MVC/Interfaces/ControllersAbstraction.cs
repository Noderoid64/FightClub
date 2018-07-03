using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    public abstract class ControllersAbstraction
    {
        protected Model model;
        
        public ControllersAbstraction()
        {
            model = new Model();
        }
        public void StartRound(RoomCreator RC)
        {
            model.StartRound(RC);
        }
        public abstract void AddView(IObserver o);
        public abstract void RemoveView(IObserver o);

        public abstract void SetPart(Player.Part Part);
        public abstract void LogClear();
    }
}
