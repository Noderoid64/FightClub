using System;
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
using System.Windows.Shapes;

namespace FightClub.Windows.MenuWindow
{
    public partial class MenuWindow : Window
    {
        IControlMenu Model;
        public MenuWindow()
        {
            Model = new ControlDefaultMenu();
            Model.SendWindow(this);
            InitializeComponent();
        }

    }
}
