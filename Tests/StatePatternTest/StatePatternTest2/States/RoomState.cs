using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public abstract class RoomState
    {
        public abstract void Visit(Room room);
    }
}
