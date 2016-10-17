using StatePatternTest.Structures;

namespace StatePatternTest.States
{
    public class RoomNotStarted : RoomState
    {
        public RoomNotStarted() : base("Room is not started yet")
        {

        }

        public override void Visit(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}
