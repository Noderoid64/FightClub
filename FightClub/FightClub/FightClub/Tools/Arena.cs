using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FightClub
{
    using System.Windows;
    using Part = Player.Part;
    class ArenaPtoA : IMainControlPlayer
    {
        Player HumanPlayer;
        Player AI;
        int HumanDef;

        Func<Part,Player,bool> SetPart;
        Action<Part> SetTo;

        public ArenaPtoA(Player humanPlayer, Player ai, int firstPlayer)
        {
            HumanPlayer = humanPlayer;
            AI = ai;

            SetPart = SetBlockPart;
            if (firstPlayer == 0)
                SetTo = SetToPlayer;
            else
                SetTo = SetToAI;
            
        }
        private void SetToPlayer(Part p)
        {
            if (SetPart(p, HumanPlayer))
                SetTo = SetToAI;
        }
        private void SetToAI(Part p)
        {
            if (SetPart(p, AI))
                SetTo = SetToPlayer;
        }
        private bool SetBlockPart(Part part, Player player)
        {
            SetPart = SetHitPart;
            return false;
        }
        private bool SetHitPart(Part part, Player player)
        {
            
            SetPart = SetBlockPart;
            return true;
        }


        public static int FirstPlayer(params Player[] t)
        {
            return (new Random().Next(0, t.Length));
        }
        #region IModelPlayer
        public void BodyClick(object sender, RoutedEventArgs e)
        {
            SetTo(Part.Body);
        }

        public void HeadClick(object sender, RoutedEventArgs e)
        {
            SetTo(Part.Head);
        }

        public void LegsClick(object sender, RoutedEventArgs e)
        {
            SetTo(Part.Legs);
        }
        #endregion
    }
}
