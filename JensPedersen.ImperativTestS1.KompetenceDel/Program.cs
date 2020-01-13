using System;

namespace JensPedersen.ImperativTestS1.KompetenceDel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while(run == true)
            {
                int productCount = 0;
                double sum = 0;
                string[] productName = new string[productCount];
                double[] productCost = new double[productCount];

                Console.WriteLine("Vælg venligst en af følgende muligheder:");
                Console.WriteLine("a. Indtast varer");
                Console.WriteLine("b. Udregn total");
                Console.WriteLine("c. Afslut");
                string input = Console.ReadLine().ToLower();

                //Man skal starte med "a"!
                if(input == "a")
                {
                    Console.Write("Hvor mange varer ønsker du at indtaste?: ");
                    input = Console.ReadLine().ToLower();
                    int.TryParse(input, out productCount);
                    productName = new string[productCount];
                    productCost = new double[productCount];
                    for(int i = 0; i < productCount; i++)
                    {
                        Console.Write($"Indtast {i + 1}. vares navn: ");
                        productName[i] = Console.ReadLine();
                        Console.Write($"Indtast {i + 1}. vares pris: ");
                        input = Console.ReadLine();
                        double.TryParse(input, out productCost[i]);
                        sum += productCost[i];
                    }
                    Console.WriteLine("Færdig. Du kan nu gå videre til 'b'");
                    Console.WriteLine("b. Udregn total");
                    Console.WriteLine("c. Afslut");

                    input = Console.ReadLine();
                    if(input == "b")
                    {
                        for(int i = 0; i < productCount; i++)
                        {
                            Console.WriteLine($"{i + 1}. Vares navn: {productName[i]}");
                            Console.WriteLine($"{i + 1}. Vares pris: {productCost[i]}\n");
                        }
                        Console.WriteLine($"Varernes samlede pris: {sum}");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if(input == "c")
                    {
                        Console.WriteLine("Farvel");
                        run = false;
                    }
                    else
                    {
                        Console.WriteLine("Ugyldigt Input! Prøv igen,");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if(input == "b")
                {
                    Console.WriteLine("Indtast venligst dine varer først!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(input == "c")
                {
                    Console.WriteLine("Farvel");
                    run = false;
                }
                else
                {
                    Console.WriteLine("Ugyldigt Input! Prøv igen,");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
