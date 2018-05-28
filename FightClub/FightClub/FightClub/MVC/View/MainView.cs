using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace FightClub
{
    class MainView : IMainView
    {
        private MainWindow Window;



        public void SetLeftMaxLife(int i)
        {
            Window.ProgressLeft.Maximum = i;
            Window.LeftLifeLabel.Content = i;
        }
        public void SetRightMaxLife(int i)
        {
            Window.ProgressRight.Maximum = i;
            Window.RightLifeLabel.Content = i;

        }
        public void SetLeftLife(int i)
        {
            Window.ProgressLeft.Value = i;
            Window.LeftLifeLabel.Content = i;
        }
        public void SetRightLife(int i)
        {
            Window.ProgressRight.Value = i;
            Window.RightLifeLabel.Content = i;
        }
        public void SetLeftName(string name)
        {
            Window.NameLeft.Text = name;
        }
        public void SetRightName(string name)
        {
            Window.NameRight.Text = name;
        }
        public void PickOutLeftPlayer()
        {
            Window.RightPlayerBorder.Background = Brushes.LightBlue;
            Window.LeftPlayerBorder.Background = Brushes.White;

        }
        public void PickOutRightPlayer()
        {
            Window.RightPlayerBorder.Background = Brushes.White;
            Window.LeftPlayerBorder.Background = Brushes.LightBlue;
        }

        public void SetPhaseDefence()
        {
            Window.PicPhase.Source = new BitmapImage(new Uri("Resourse\\DefenceIcon.png", UriKind.Relative));
        }
        public void SetPhaseAttack()
        {
            Window.PicPhase.Source = new BitmapImage(new Uri("Resourse\\AttackIcon.png", UriKind.Relative));
        }

        public void Log(string message)
        {
            Window.LogBox.Items.Add(message);
        }
        public void CleanLog()
        {
            Window.LogBox.Items.Clear();
        }

        public void SendWindow(Window w)
        {
            if (w is MainWindow)
                Window = (MainWindow)w;
        }
    }
}
