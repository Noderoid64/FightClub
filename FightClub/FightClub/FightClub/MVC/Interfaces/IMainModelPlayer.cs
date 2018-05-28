namespace FightClub
{
    interface IMainModelPlayer
    {
        IMainView view { set;}
        void BodyClick();
        void HeadClick();
        void LegsClick();
    }
}