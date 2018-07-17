using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Lab2
{
    class Program
    {
        static void Main(string[] args) // Program finds the area and perimeter of a room through prompt
        {
            double Length, Width, Area, Perimeter, Height,Volume;
            bool userInput;
            do
            {
                Console.WriteLine("Enter Length:");
                Length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                Height = double.Parse(Console.ReadLine());
                Area = Length * Width;
                Perimeter = 2 * (Length + Width);
                Volume = Length * Width * Height;
                Console.WriteLine($"The area is {Area}");
                Console.WriteLine($"The Perimeter is {Perimeter}");
                Console.WriteLine($"The Volume is {Volume}");
                Console.WriteLine("Go Again? (true/false)");
                userInput = Convert.ToBoolean(Console.ReadLine());
            } while (userInput == true);
        }
    }
}
