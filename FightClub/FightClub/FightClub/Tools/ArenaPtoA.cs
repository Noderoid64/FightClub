using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FightClub
{
    using Part = Player.Part;
    class ArenaPtoA : IMainModelPlayer, IArena
    {
        Player HumanPlayer;
        Player AI;
        Func<Part, bool> SetPart;

        private IBot Bot;
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

        public ArenaPtoA(Player humanPlayer, Player ai, int firstPlayer, IBot bot)
        {
            Bot = bot;
            HumanPlayer = humanPlayer;
            AI = ai;

            SetPart = SetBlockPart;  // Select start phase
            SetStartPlayer(firstPlayer);
            SubscribeEvents(HumanPlayer);
            SubscribeEvents(AI);

        }
        ~ArenaPtoA()
        {
            DiscribeEvents(HumanPlayer);
            DiscribeEvents(AI);
        }
        private void SetStartPlayer(int firstPlayer)
        {
            if (firstPlayer >= 0 && firstPlayer < 2)
            {
                if (firstPlayer != 0)
                    HumanPlayer.GetHit(Bot.MakeAttackDecision());
            }
            else
                throw new Exception("Class: ArenaPtoA\nfirstPlayer must be between 0 and 1");
        }

        private bool SetBlockPart(Part part)
        {
            HumanPlayer.SetBlock(part);
            HumanPlayer.GetHit(Bot.MakeAttackDecision());
            View.SetLeftLife(HumanPlayer.HP);
            SetPart = SetHitPart;
            view.SetPhaseAttack();
            return false;
        }
        private bool SetHitPart(Part part)
        {
            AI.SetBlock(Bot.MakeDefDecision());
            AI.GetHit(part);
            View.SetRightLife(AI.HP);
            SetPart = SetBlockPart;
            view.SetPhaseDefence();
            return true;
        }

        public List<Player> GetPlayers()
        {
            return new List<Player>(new Player[] { HumanPlayer, AI });
        }

        private void SubscribeEvents(Player P)
        {
            P.Block += Block;
            P.Wound += Wound;
            P.Death += Death;
        }
        private void DiscribeEvents(Player P)
        {
            P.Block -= Block;
            P.Wound -= Wound;
            P.Death -= Death;
        }

        private void Block(object sende, PlayersEventArgs e)
        {
            Loger log = new DebugLoger(new UILoger(view));
            log.Write(DateTime.Now + " " + e.Name + ": " + " blocked " + e.HP);
        }
        private void Wound(object sende, PlayersEventArgs e)
        {
            Loger log = new DebugLoger(new UILoger(view));
            log.Write(DateTime.Now + " " + e.Name + ": " + " wound " + e.HP);
        }
        private void Death(object sende, PlayersEventArgs e)
        {
            Loger log = new DebugLoger(new UILoger(view));
            log.Write(DateTime.Now + " " + e.Name + ": " + " death " + e.HP);
        }


        #region IModelPlayer
        public void BodyClick()
        {
            SetPart(Part.Body);
        }

        public void HeadClick()
        {
            SetPart(Part.Head);
        }

        public void LegsClick()
        {
            SetPart(Part.Legs);
        }
        #endregion
    }
}
