using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room2StateFinished : Room2State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": already finished");
        }
    }
}
