using System;

namespace _02._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add radians:");
            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;
            Console.WriteLine();
            Console.WriteLine("Result:");
            Console.WriteLine("{0:f2} radians = {1:f2} degrees",radians, degrees);
        }
    }
}
