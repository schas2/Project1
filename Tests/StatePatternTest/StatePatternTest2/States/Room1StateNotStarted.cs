using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room1StateNotStarted : Room1State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": started");
            room.SetState(new Room1StateStarted());
        }
    }
}
