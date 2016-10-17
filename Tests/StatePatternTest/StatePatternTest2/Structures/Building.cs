using System.Collections.Generic;

namespace StatePatternTest2.Structures
{
    public class Building
    {
        public List<Room> Rooms { get; }

        private Room _currentRoom;

        public Building()
        {
            Rooms = new List<Room>();
            _currentRoom = null;
        }

        public void AddRoom(Room room)
        {
            if (_currentRoom == null)
            {
                _currentRoom = room;
            }
            Rooms.Add(room);
        }

        public void VisitRoom()
        {
            _currentRoom?.Visit();
        }

        public void SwitchRoom(Room room)
        {
            _currentRoom = room;
        }
    }
}
