using System;

namespace Opgave7
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast 5 tal:");
                int[] numbers = new int[5];
                int subtraction = 0;
                int multiplication = 0;

                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Indtast {i + 1}. tal:");
                    string numberInput = Console.ReadLine();
                    int.TryParse(numberInput, out numbers[i]);
                }

                Console.WriteLine($"Du har indtastet disse tal:");
                for(int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                    subtraction = numbers[0] - numbers[1] - numbers[2] - numbers[3] - numbers[4];
                    multiplication = numbers[0] * numbers[1] * numbers[2] * numbers[3] * numbers[4];
                }
                Console.WriteLine($"De 5 tal trukket fra hinanden: {subtraction}");
                Console.WriteLine($"De 5 tal ganget med hinanden: {multiplication}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
