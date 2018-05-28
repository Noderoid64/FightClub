namespace FightClub
{
    interface IMainModelMenu
    {
        IMainView view { set; }
        void ClearClick();
        void ExitClick();
        void NewGameAI();
        void NewGamePlayer();
        void SettingsClick();
    }
}