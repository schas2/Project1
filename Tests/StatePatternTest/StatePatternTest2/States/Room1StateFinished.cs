using System;
using StatePatternTest2.Structures;

namespace StatePatternTest2.States
{
    public class Room1StateFinished : Room1State
    {
        public override void Visit(Room room)
        {
            Console.WriteLine(Name + ": already finished");
        }
    }
}
