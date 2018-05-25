using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class PlayerControl : IMainControl
    {

        public void BodyClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Yeah");
        }

        public void ClearClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ExitClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void HeadClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LegsClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void NewGameClick(object sender, RoutedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        public void SettingsClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
