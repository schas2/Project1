using StatePatternTest.Structures;

namespace StatePatternTest.States
{
    public class RoomFinished : RoomState
    {
        public RoomFinished() : base("Room is finished")
        {
        }

        public override void Visit(Room room)
        {
            throw new System.NotImplementedException();
        }
    }
}
