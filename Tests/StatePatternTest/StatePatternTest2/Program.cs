using System;
using StatePatternTest2.States;
using StatePatternTest2.Structures;

namespace StatePatternTest2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var building = new Building();

            var room1 = new Room(new Room1StateNotStarted());
            building.AddRoom(room1);
            var room2 = new Room(new Room2StateNotStarted());
            building.AddRoom(room2);

            building.VisitRoom();
            building.VisitRoom();
            building.VisitRoom();
            building.VisitRoom();
            building.VisitRoom();

            building.SwitchRoom(room2);
            building.VisitRoom();
            building.VisitRoom();
            building.VisitRoom();
            building.VisitRoom();

            building.SwitchRoom(room1);
            building.VisitRoom();
            building.VisitRoom();

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
