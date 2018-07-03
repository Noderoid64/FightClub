using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightClub
{
    class PlayersView :  IObserver
    {
        private ControllersAbstraction Controller;
        public ControllersAbstraction controller
        {
            set
            {
                Controller = value;
            }
        }

        PlayerWindow Human;
        PlayerWindow Computer;

        public PlayersView(ControllersAbstraction C)
        {
            controller = C;

            Human = new PlayerWindow();
            Computer = new PlayerWindow();

            Human.HeadButton.Click += HumanHeadClick;
            Human.BodyButton.Click += HumanBodyClick;
            Human.LegsButton.Click += HumanLegsClick;

            Human.Show();
            Computer.Show();
        }

        #region Events
        public void HumanHeadClick(object sender, EventArgs e)
        {
            Controller.SetPart(Player.Part.Head);
        }
        public void HumanBodyClick(object sender, EventArgs e)
        {
            Controller.SetPart(Player.Part.Body);
        }
        public void HumanLegsClick(object sender, EventArgs e)
        {
            Controller.SetPart(Player.Part.Legs);
        }
        #endregion

        public void update(object info)
        {
            if(info is HumanComputerRoom)
            {
                HumanComputerRoom localRoom = (HumanComputerRoom)info;
                UpdateWindow(Human,localRoom.Human);
                UpdateWindow(Computer, localRoom.Computer);
            }           
        }
        private void UpdateWindow(PlayerWindow pw, Player p)
        {
            pw.TextBlockHP.Text = p.hp + "/" + p.maxHp;
            pw.TextBoxName.Text = p.name;
            pw.ProgressBarHp.Maximum = p.maxHp;
            pw.ProgressBarHp.Value = p.hp;
        }
    }
}
