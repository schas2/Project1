using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room1StateStarted : Room1State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": finished");
            room.SetState(new Room1StateFinished());
        }
    }
}
