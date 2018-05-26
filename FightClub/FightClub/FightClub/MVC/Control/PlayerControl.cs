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
        private IMainModel Model;

        public PlayerControl() : this(new PModelP())
        {

        }
        public PlayerControl(IMainModel model)
        {
            Model = model;
        }
        
        public void BodyClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ClearClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ExitClick(object sender, RoutedEventArgs e)
        {
            Model.ExitClick(sender,e);
        }

        public void HeadClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void LegsClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void NewGameAI(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void NewGamePlayer(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void SettingsClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
