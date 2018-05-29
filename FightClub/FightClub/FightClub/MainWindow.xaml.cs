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
        IMainControl Control;

        public MainWindow()
        {
            InitializeComponent();
         
            StartNewGame(new PlayerControl(this));
            ButtonAIGame.Click += StartGameAI;
            ButtonPlayerGame.Click += StartGamePlayer;
        }
        internal void StartNewGame(IMainControl control)
        {
            
            Control = control;
            SetEvents(Control);
            
        }

        private void SetEvents(IMainControl control)
        {
            ButtonHead.Click += control.HeadClick;
            ButtonBody.Click += control.BodyClick;
            ButtonLegs.Click += control.LegsClick;
            ButtonExit.Click += control.ExitClick;           
            ButtonSettings.Click += control.SettingsClick;
            ButtonClear.Click += control.ClearClick;

            ButtonAIGame.Click += control.NewGameAI;
            ButtonPlayerGame.Click += control.NewGamePlayer;
            
            
        }
        private void DisableEvents(IMainControl control)
        {
            ButtonHead.Click -= control.HeadClick;
            ButtonBody.Click -= control.BodyClick;
            ButtonLegs.Click -= control.LegsClick;
            ButtonExit.Click -= control.ExitClick;
            ButtonSettings.Click -= control.SettingsClick;
            ButtonClear.Click -= control.ClearClick;

            ButtonAIGame.Click -= control.NewGameAI;
            ButtonPlayerGame.Click -= control.NewGamePlayer;
        }

        private void StartGameAI(object sender, EventArgs e)
        {
            DisableEvents(Control);
            StartNewGame(new PlayerControl(new PModelAI(this)));
        }
        private void StartGamePlayer(object sender, EventArgs e)
        {
            DisableEvents(Control);
            StartNewGame(new PlayerControl(new PModelP(this)));
        }
        
    }
}
