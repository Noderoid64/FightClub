using System;
using System.Windows;
namespace FightClub
{
    interface IMainControlMenu
    {
        void ClearClick(object sender, RoutedEventArgs e);
        void ExitClick(object sender, RoutedEventArgs e);
        void NewGameAI(object sender, RoutedEventArgs e);
        void NewGamePlayer(object sender, RoutedEventArgs e);
        void SettingsClick(object sender, RoutedEventArgs e);
    }
}