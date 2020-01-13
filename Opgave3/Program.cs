using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast et tal mellem 1 og 10:");
                string numberInput = Console.ReadLine();
                int.TryParse(numberInput, out int number);
                if(number > 0 && number <= 10)
                {
                    if(number > 5)
                    {
                        Console.WriteLine("Tallet er større end 5");
                    }
                    else if(number == 5)
                    {
                        Console.WriteLine("Tallet er præcis 5");
                    }
                    else
                    {
                        Console.WriteLine("Tallet er mindre end 5");
                    }
                }
                else
                {
                    Console.WriteLine("Du indtastede ikke et gyldigt tal, prøv igen.");
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
