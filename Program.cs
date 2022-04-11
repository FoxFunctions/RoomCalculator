using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the Length of the room?");
            double roomLength = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the width of the room?");
            double roomWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the height of the room?");
            double roomHeight = double.Parse(Console.ReadLine());
            double roomArea = roomLength * roomWidth;
            double roomPerimeter = roomWidth * 2 + roomLength * 2;
            double roomVolume = roomWidth * roomLength * roomHeight;
            double roomSurfaceArea = 2 * (roomWidth * roomLength + roomHeight * roomLength + roomHeight * roomWidth);
            Console.WriteLine($"The area of this room is {roomArea}.");
            Console.WriteLine($"The perimeter of this room is {roomPerimeter}.");
            Console.WriteLine($"The volume of this room is {roomVolume}.");
            Console.WriteLine($"The Surface Area of this room is {roomSurfaceArea}.");

            


            if (roomArea <= 250)
            {
                Console.WriteLine("This is a small room.");
            } else if (roomArea >250 && roomArea <= 650)
            {
                Console.WriteLine("This is a medium room.");

            } else
            {
                Console.WriteLine("This is a large room.");
            }


        }
    }
}
