using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Reflection.Metadata;

namespace RoomSizeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Room Size Generator!");
            Console.WriteLine("----------------------------------------\n");
            string more = "y";
            do
            {
                Console.Write("Enter the width of the room in inches:");
                int width = int.Parse(Console.ReadLine());
                Console.Write("Enter the length of the room in inches:");
                int length = int.Parse(Console.ReadLine());
                int perimeter = (2 * width) + (2 * length);
                int area = (width * length);
                Console.WriteLine();
                Console.WriteLine($"Perimeter = {perimeter} inches");
                Console.WriteLine($"Area = {area} square inches");
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? (y/n)");
                more = Console.ReadLine();
            } while (more == "y");

            Console.WriteLine("Goodbye");
        }
    }
}
