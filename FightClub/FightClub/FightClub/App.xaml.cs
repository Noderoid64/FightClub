﻿using System;
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
            
            MainMediator MM = new MainMediator();
            MenuWindow Mw = new MenuWindow(MM);
            PlayerWindow Pw = new PlayerWindow();
            
            Mw.Show();
            Pw.Show();
        }
    }
}
