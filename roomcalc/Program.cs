using System;

namespace RoomCalculator
{
    class Program
    {
        static double roomLength;
        static double roomWidth;
        static double roomHeight;

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What is the Length of the room?");
                    roomLength = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the width of the room?");
                    roomWidth = double.Parse(Console.ReadLine());
                    Console.WriteLine("What is the height of the room?");
                    roomHeight = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Sorry, that is not a valid input. Please enter a number value");
                    continue;
                }
            }
            double roomArea = GetArea(roomLength, roomWidth);
            double roomPerimeter = GetPerimeter(roomWidth, roomLength);
            double roomVolume = GetVolume(roomWidth, roomLength, roomHeight);
            double roomSurfaceArea = GetSurfaceArea(roomWidth,roomLength,roomHeight);
            Console.WriteLine($"The area of this room is {roomArea}.");
            Console.WriteLine($"The perimeter of this room is {roomPerimeter}.");
            Console.WriteLine($"The volume of this room is {roomVolume}.");
            Console.WriteLine($"The Surface Area of this room is {roomSurfaceArea}.");

            if (roomArea <= 250)
            {
                Console.WriteLine("This is a small room.");
            }
            else if (roomArea > 250 && roomArea <= 650)
            {
                Console.WriteLine("This is a medium room.");

            }
            else
            {
                Console.WriteLine("This is a large room.");
            }


        }
        public static double GetArea(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double GetPerimeter(double num1, double num2)
        {
            return num1 * 2 + num2 * 2;
        }

        public static double GetVolume(double num1, double num2, double num3)
        {
            return num1 * num2 * num3;
        }

        public static double GetSurfaceArea(double num1, double num2, double num3)
        {
            return 2 * (num1 * num2 + num3 * num2 + num3 * num1);
        }
    }
}
