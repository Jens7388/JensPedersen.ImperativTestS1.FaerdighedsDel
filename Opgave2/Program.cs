using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej bruger. Indtast venligst dit navn her: ");
            string nameInput = Console.ReadLine();
            Console.WriteLine($"Dit navn er: {nameInput}");
            Console.ReadLine();
        }
    }
}
