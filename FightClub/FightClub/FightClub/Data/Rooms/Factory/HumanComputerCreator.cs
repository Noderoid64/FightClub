namespace FightClub
{
    public class HumanComputerCreator : RoomCreator
    {
        public FightRoomForTwo Create(Player Human, Player Computer)
        {
            HumanComputerRoom HCR = new HumanComputerRoom(human:Human, computer:Computer);
            return HCR;
        }
        public override FightRoomForTwo Create()
        {
            Player Computer = new Player("Bot");
            Player Human = new Player("Misha");
            return Create(Human,Computer);
        }
    }
}
