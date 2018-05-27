﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FightClub
{
    class PModelAI : IMainModel, IMainControlMenu, IMainControlPlayer
    {
        private IMainView View;
        private IMainModelMenu Menu;
        private IMainModelPlayer Control;

        #region Constructors
        public PModelAI() : this(new MainView(), new ModelMenu(),new ArenaPtoA(new UserPlayer(), new UserPlayer(),0))
        {
            
        }
        public PModelAI(IMainView view, IMainModelMenu menu, IMainModelPlayer control)
        {
            View = view;
            Menu = menu;
            Control = control;
            if(control is IArena)
            {
                ((IArena)control).GetPlayers()[0].Block += SendBlockedToLog;
                ((IArena)control).GetPlayers()[0].Wound += SendWoundToLog;
                ((IArena)control).GetPlayers()[0].Death += SendDeathToLog;
                ((IArena)control).GetPlayers()[1].Block += SendBlockedToLog;
                ((IArena)control).GetPlayers()[1].Wound += SendWoundToLog;
                ((IArena)control).GetPlayers()[1].Death += SendDeathToLog;
            }
        }
        #endregion

        #region Control
        public void HeadClick(object sender, RoutedEventArgs e)
        {
            Control.HeadClick();
            View.Log("it was a headHit");
        }
        public void BodyClick(object sender, RoutedEventArgs e)
        {
            Control.BodyClick();
        }
        public void LegsClick(object sender, RoutedEventArgs e)
        {
            Control.LegsClick();
        }
        #endregion

        #region Menu
        public void ClearClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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

        #region Events
        private void SendBlockedToLog(object sender,PlayersEventArgs e)
        {
            View.Log(e.Name + " Blocked " + e.HP);
        }
        private void SendWoundToLog(object sender, PlayersEventArgs e)
        {
            View.Log(e.Name + " Wound " + e.HP);
        }
        private void SendDeathToLog(object sender, PlayersEventArgs e)
        {
            View.Log(e.Name + " Death " + e.HP);
        }
        #endregion

        public void SendWindow(Window wind)
        {
            View.SendWindow(wind);
        }
    }
}
