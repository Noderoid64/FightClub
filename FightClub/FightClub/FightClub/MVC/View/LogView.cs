using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class LogView : IObserver
    {
        public ControllersAbstraction controller { get; set;}
        LogWindow LW;
        public LogView(ControllersAbstraction ca)
        {
            LW = new LogWindow();
            controller = ca;
            LW.ClearButton.Click += ClearLog;
            LW.Show();
        }

        public void ClearLog(object sender, EventArgs e)
        {
            controller.LogClear();
        }


        public void update(object info)
        {
            if(info is string)
            {
                string message = (string)info;
                if (message == "Clear")
                    LW.LogBox.Items.Clear();
                else
                LW.LogBox.Items.Add(message);
            }
        }
    }
}
