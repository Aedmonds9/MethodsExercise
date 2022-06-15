using System;

namespace Shortstoryapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Please type your name.");
            string userName;
            userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}. What is your favorite color?");
            string favColor;
            favColor = Console.ReadLine();
            Console.WriteLine($"Your favorite animal?");
            string favAnimal;
            favAnimal = Console.ReadLine();
            Console.WriteLine($"Finally, your favorite band?");
            string favBand;
            favBand = Console.ReadLine();
            Console.WriteLine($"Thank you. Now I will tell your life story. There once was a special person named {userName}.");
            Console.WriteLine($"They were fatally obsessed with { favBand } to the point of fanaticism.");
            Console.WriteLine($"For days they could talk about their love of {favAnimal}s");
            Console.WriteLine($"One day, the walked into a {favColor} cloud and came out with the power of super smell.");




        }
    }
}
