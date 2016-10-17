using StatePatternTest.Structures;

namespace StatePatternTest.States
{
    public class RoomLocked : RoomState
    {
        public RoomLocked() : base("Room is locked")
        {
        }

        public override void Visit(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}
