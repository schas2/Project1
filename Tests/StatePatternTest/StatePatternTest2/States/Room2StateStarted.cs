using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room2StateStarted : Room2State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": finished");
            room.SetState(new Room2StateFinished());
        }
    }
}
