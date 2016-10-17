using StatePatternTest.States;

namespace StatePatternTest.Structures
{
    public class Room
    {
        private readonly string _name;
        private readonly RoomState _state;

        public Room(string name)
        {
            _name = name;
            _state = new RoomLocked();
        }

        public string ShowRoomState()
        {
            return $"Room {_name}: {_state.RoomStateText}";
        }

        public void VisitRoom()
        {
            _state.Visit(this);
        }
    }
}
