// See https://aka.ms/new-console-template for more information
using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Colorfunction("White");
            Colorfunction("lolo");
            // This is a simple console application that prints "Hello, World!" to the console.
            // You can run this application using the .NET CLI or Visual Studio.
        }

        static void Colorfunction(string life)
        {
            var colors = new string[] { "Red", "Green", "Blue", life };

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}