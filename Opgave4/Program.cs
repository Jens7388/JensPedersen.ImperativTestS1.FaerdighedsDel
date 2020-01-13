using System;

namespace Opgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Indtast 3 tal:");
                int addition = 0;
                int subtraction = 0;
                int multiplication = 0;
                int[] number = new int[3];

                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Indtast tal {i + 1} :");
                    string numberInput = Console.ReadLine();
                    int.TryParse(numberInput, out number[i]);
                    addition += number[i];
                    subtraction = number[0] - number[1] - number[2];
                    multiplication = number[0] * number[1] * number[2];
                }
                Console.WriteLine($"Addition: {number[0]} + {number[1]} + {number[2]} = {addition}");
                Console.WriteLine($"Subtraktion: {number[0]} - {number[1]} - {number[2]} = {subtraction}");
                Console.WriteLine($"Multiplikation: {number[0]} * {number[1]} * {number[2]} = {multiplication}");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
