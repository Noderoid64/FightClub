using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class PModelP : IMainModel, IMainControlMenu, IMainControlPlayer
    {
        private IMainView View;
        private IMainModelMenu Menu;
        private IMainModelPlayer Control;

        #region Constructors
        public PModelP() : this(null, new ModelMenu(),null) { }
        public PModelP(IMainView view, IMainModelMenu menu, IMainModelPlayer control)
        {
            View = view;
            Menu = menu;
            Control = control;
        }
        #endregion

        #region Control
        public void HeadClick(object sender, RoutedEventArgs e)
        {
            Control = Control.HeadClick();
        }
        public void BodyClick(object sender, RoutedEventArgs e)
        {
            Control = Control.BodyClick();
        }
        public void LegsClick(object sender, RoutedEventArgs e)
        {
            Control = Control.LegsClick();
        }
        #endregion

        #region Menu
        public void ClearClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        public void ExitClick(object sender, RoutedEventArgs e)
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
        #endregion
    }
}
