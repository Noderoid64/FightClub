namespace FightClub
{
    interface IMainModelMenu
    {
        IMainModelMenu ClearClick();
        IMainModelMenu ExitClick();
        IMainModelMenu NewGameAI();
        IMainModelMenu NewGamePlayer();
        IMainModelMenu SettingsClick();
    }
}