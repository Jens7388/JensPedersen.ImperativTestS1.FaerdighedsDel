using System;

namespace Opgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast en pris, der består af både kroner og ører, og se dets momsbeløb");
                string priceInput = Console.ReadLine();
                double.TryParse(priceInput, out double price);
                double moms = price * 0.25;
                Console.WriteLine($"Momsen på denne pris er: {moms}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
