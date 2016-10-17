using StatePatternTest2.States;

namespace StatePatternTest2.Structures
{
    public class Room
    {
        private RoomState _state;

        public Room(RoomState state)
        {
            _state = state;
        }

        public void SetState(RoomState state)
        {
            _state = state;
        }

        public void Visit()
        {
            _state.Visit(this);
        }
    }
}
