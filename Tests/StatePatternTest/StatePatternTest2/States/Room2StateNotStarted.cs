using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room2StateNotStarted : Room2State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": started");
            room.SetState(new Room2StateStarted());
        }
    }
}
