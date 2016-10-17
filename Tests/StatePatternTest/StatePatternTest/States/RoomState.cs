using StatePatternTest.Structures;

namespace StatePatternTest.States
{
    public abstract class RoomState
    {
        public string RoomStateText { get; }

        protected RoomState(string roomStateText)
        {
            RoomStateText = roomStateText;
        }

        public abstract void Visit(Room room);
    }
}
