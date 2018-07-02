using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            LogWindow w = new LogWindow();
            PlayerWindow pw1 = new PlayerWindow();
            PlayerWindow pw2 = new PlayerWindow();
            pw1.Show();
            pw2.Show();
            w.Show();
        }
    }
}
