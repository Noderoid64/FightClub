using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FightClub
{
    abstract class Loger
    {
       protected Loger loger;

        public Loger(Loger log)
        {
            loger = log;
        }
       public abstract void Write(string message);
    }

    class FileLoger : Loger
    {
        public FileLoger(Loger log) : base(log) { }

        public override void Write(string message)
        {
            throw new NotImplementedException();
        }
    }
    class UILoger : Loger
    {
        IMainView View;
        public UILoger(IMainView view, Loger log = null) : base(log) { View = view; }

        public override void Write(string message)
        {
            View.Log(message);
            if (loger != null)
                loger.Write(message);
        }
    }
    class DebugLoger : Loger
    {

        public DebugLoger(Loger loger = null) : base(loger) { }
        
        public override void Write(string message)
        {
            Debug.WriteLine(message);
            if (loger != null)
                loger.Write(message);
        }
    }
}
