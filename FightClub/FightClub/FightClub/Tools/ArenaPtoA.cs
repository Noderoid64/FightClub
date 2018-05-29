using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FightClub
{
    using System.Windows;
    using Part = Player.Part;
    class ArenaPtoA : IMainModelPlayer, IArena
    {
        Player HumanPlayer;
        Player AI;
        Func<Part,Player,bool> SetPart;
        Action<Part> SetTo;

        private IMainView View;
        public IMainView view
        {
            set
            {
                View = value;
                View.SetLeftMaxLife(HumanPlayer.HP);
                View.SetRightMaxLife(AI.HP);
                View.SetLeftName(HumanPlayer.Name);
                View.SetRightName(AI.Name);
            }
            get
            {
                return View;
            }
        }

        public ArenaPtoA( Player humanPlayer, Player ai, int firstPlayer)
        {
            
            HumanPlayer = humanPlayer;
            AI = ai;           

            SetPart = SetBlockPart;  // Select start phase
            SetStartPlayer(firstPlayer);
           
            
        }

        private void SetStartPlayer(int firstPlayer)
        {
            if (firstPlayer >= 0 && firstPlayer < 2)
                if (firstPlayer == 0)
                    SetTo = SetToPlayer;
                else
                    SetTo = SetToAI;
            else
                throw new Exception("Class: ArenaPtoA\nfirstPlayer must be between 0 and 1");
        }

        private void SetToPlayer(Part p)
        {
            view.PickOutLeftPlayer();
            if (SetPart(p, HumanPlayer))
            {
                SetTo = SetToAI;
                view.SetLeftLife(HumanPlayer.HP);
            }
            else
                view.SetRightLife(AI.HP);
            
           
        }
        private void SetToAI(Part p)
        {
            view.PickOutRightPlayer();
            if (SetPart(p, AI))
                SetTo = SetToPlayer;
            
        }
        private bool SetBlockPart(Part part, Player player)
        {
            player.SetBlock(part);
            SetPart = SetHitPart;
            view.SetPhaseAttack();
            return false;
        }
        private bool SetHitPart(Part part, Player player)
        {
            player.GetHit(part);
            SetPart = SetBlockPart;            
            view.SetPhaseDefence();
            return true;
        }

        public List<Player> GetPlayers()
        {
            return new List<Player>(new Player[] {HumanPlayer,AI });
        }
        public static int FirstPlayer(params Player[] t)
        {
            return (new Random().Next(0, t.Length));
        }

        #region IModelPlayer
        public void BodyClick()
        {
            SetTo(Part.Body);
        }

        public void HeadClick()
        {
            SetTo(Part.Head);
        }

        public void LegsClick()
        {
            SetTo(Part.Legs);
        }
        #endregion
    }
}
