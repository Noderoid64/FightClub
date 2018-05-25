using System;
using System.Windows;
namespace FightClub
{
    interface IMainControlMenu
    {
        void ClearClick(object sender, RoutedEventArgs e);
        void ExitClick(object sender, RoutedEventArgs e);
        void NewGameClick(object sender, RoutedEventArgs e);
        void SettingsClick(object sender, RoutedEventArgs e);
    }
}