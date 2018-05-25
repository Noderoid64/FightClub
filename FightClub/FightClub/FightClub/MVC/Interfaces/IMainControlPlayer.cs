using System;
using System.Windows;

namespace FightClub
{
    interface IMainControlPlayer
    {
        void BodyClick(object sender, RoutedEventArgs e);
        void HeadClick(object sender, RoutedEventArgs e);
        void LegsClick(object sender, RoutedEventArgs e);
    }
}