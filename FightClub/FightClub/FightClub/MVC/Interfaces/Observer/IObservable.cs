using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    interface IObservable
    {
        void AddObserver(IObserver obj);
        void RemoveObserver(IObserver obj);
        void Notify(object info);
    }
}
