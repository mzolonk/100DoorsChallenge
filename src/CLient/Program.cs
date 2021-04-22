using System;
using System.Collections.Generic;
using System.Linq;
using Doors;
using Doors.Helpers;
using Doors.Models;

namespace CLient
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new FlippingDoors();
            var door = house.Doors;
            Logic.DoSomeFlipping(0, ref door);
            Console.Write("0  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(1, ref door);
            Console.Write("1  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(2, ref door);
            Console.Write("2  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(3, ref door);
            Console.Write("3  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(4, ref door);
            Console.Write("4  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(5, ref door);
            Console.Write("5  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(6, ref door);
            Console.Write("6  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(7, ref door);
            Console.Write("7  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(8, ref door);
            Console.Write("8  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(9, ref door);
            Console.Write("9  : ");
            Output(door);

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(10, ref door);
            Console.Write("10 : ");
            Output(door);

            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");
            Console.WriteLine(".");

            house = new FlippingDoors();
            door = house.Doors;
            Logic.DoSomeFlipping(100, ref door);
            Console.Write("100 : ");
            Output(door);
            Console.ReadLine();          
        }

        private static void Output(List<Door> doors)
        {
            for (int i = 0; i < doors.Count(); i++)
            {
                Console.Write( doors[i].State == DoorState.Opened? "@": "#");
            }
            Console.WriteLine("");
        }
    }
}
