using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class MainView : IMainView
    {
        private MainWindow Window;

        public void Log(string message)
        {
            Window.LogBox.Items.Add(message);
        }

        public void SendWindow(Window w)
        {
            if (w is MainWindow)
                Window = (MainWindow)w;
        }
    }
}
