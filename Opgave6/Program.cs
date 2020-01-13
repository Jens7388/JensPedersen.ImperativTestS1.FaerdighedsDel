using System;

namespace Opgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast prisen på to forskellige varer, og se både totalprisen og discountprisen" +
                "(10% besparelse på første vare, 20% på  anden vare");

                Console.WriteLine("Indtast første pris: ");
                string priceInput = Console.ReadLine();
                double.TryParse(priceInput, out double firstPrice);

                Console.WriteLine("Indtast anden pris :");
                priceInput = Console.ReadLine();
                double.TryParse(priceInput, out double secondPrice);

                double totalPrice = firstPrice + secondPrice;
                double discountPrice = (firstPrice * 0.9) + (secondPrice * 0.8);
                Console.WriteLine($"Totalprisen er {totalPrice} kr");
                Console.WriteLine($"Discountprisen er {discountPrice} kr");
                Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
