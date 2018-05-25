﻿using System;
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
            SetEvents(new PlayerControl());
            
        }
        private void SetEvents(IMainControl control)
        {
            ButtonHead.Click += control.HeadClick;
            ButtonBody.Click += control.BodyClick;
            ButtonLegs.Click += control.LegsClick;
            ButtonExit.Click += control.ExitClick;
            ButtonNewGame.Click += control.NewGameClick;
            ButtonSettings.Click += control.SettingsClick;
            ButtonClear.Click += control.ClearClick;
        }
        
    }
}
