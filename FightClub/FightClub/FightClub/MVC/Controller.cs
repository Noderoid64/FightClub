using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class Controller : ControllersAbstraction
    {

        public Controller()
        {

        }

        public override void AddView(IObserver o)
        {
            ((IObservable)model).AddObserver(o);
        }
        public override void RemoveView(IObserver o)
        {
            ((IObservable)model).RemoveObserver(o);
        }

        public override void LogClear()
        {
            model.ClearLog();
        }        
        public override void SetPart(Player.Part Part)
        {
            model.SetPart(Part);
        }


    }
}
