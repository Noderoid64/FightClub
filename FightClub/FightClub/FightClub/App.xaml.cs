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

            ControllersAbstraction C = new Controller();

            PlayersView PV = new PlayersView(C);
            LogView LV = new LogView(C);

            C.AddView(PV);
            C.AddView(LV);
            C.StartRound(new HumanComputerCreator());

            
        }
    }
}
