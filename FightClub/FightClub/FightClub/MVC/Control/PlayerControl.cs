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
        private IMainView View;

        public PlayerControl() : this(new PModelAI())
        {

        }
        public PlayerControl(IMainModel model)
        {
            Model = model;
        }

        #region ControlMenu
        public void ClearClick(object sender, RoutedEventArgs e)
        {
            Model.ClearClick(sender, e);
        }
        public void ExitClick(object sender, RoutedEventArgs e)
        {
            Model.ExitClick(sender, e);
        }
        public void NewGameAI(object sender, RoutedEventArgs e)
        {
            Model.NewGameAI(sender,e);
        }
        public void NewGamePlayer(object sender, RoutedEventArgs e)
        {
            Model.NewGamePlayer(sender,e);
        }
        public void SettingsClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ControlPlayer
        public void HeadClick(object sender, RoutedEventArgs e)
        {
            Model.HeadClick(sender,e);
        }
        public void BodyClick(object sender, RoutedEventArgs e)
        {
            Model.BodyClick(sender, e);
        }
        public void LegsClick(object sender, RoutedEventArgs e)
        {
            Model.LegsClick(sender,e);
        }
        #endregion

        public void SendWindow(Window wind)
        {
            Model.SendWindow(wind);
        }
       
    }
}