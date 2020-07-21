using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lab_07_20_20
{
    class Program
    {
        static void Main(string[] args)
        {

            string continuePrompt = "y";



            while (continuePrompt == "y" || continuePrompt == "y")
            {
                Console.Write("Welcome to the Grand Circus Room Calculator! Please enter a number for dimensions of the room");                
                Console.Write(" Enter Length: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                double width = double.Parse(Console.ReadLine());
                Console.Write("Enter height:");
                double height = double.Parse(Console.ReadLine());
                
                double area = (length * width);

                double perimeter = (2 * length) + (2 * width);

                double volume = (length * width * height);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.Write("Would you like to continue? (y/n): ");
                continuePrompt = Console.ReadLine();

            }                             
        }
    }
}
