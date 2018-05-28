using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FightClub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
         
            StartNewGame(new PlayerControl());
        }

        internal void StartNewGame(IMainControl control)
        {

            SetEvents(control);
            SendWindow(control);
        }
        private void SetEvents(IMainControl control)
        {
            ButtonHead.Click += control.HeadClick;
            ButtonBody.Click += control.BodyClick;
            ButtonLegs.Click += control.LegsClick;
            ButtonExit.Click += control.ExitClick;
            ButtonAIGame.Click += control.NewGameAI;
            ButtonPlayerGame.Click += control.NewGamePlayer;
            ButtonSettings.Click += control.SettingsClick;
            ButtonClear.Click += control.ClearClick;
        }
        private void SendWindow(IMainControl control)
        {
            control.SendWindow(this);
        }
        
    }
}
