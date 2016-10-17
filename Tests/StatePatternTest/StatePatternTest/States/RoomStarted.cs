using StatePatternTest.Structures;

namespace StatePatternTest.States
{
    public class RoomStarted : RoomState
    {
        public RoomStarted() : base("Room is started")
        {
        }

        public override void Visit(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}
