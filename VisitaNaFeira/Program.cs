using System;

namespace VisitaNaFeira
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            var numbers = entry.Split(" ");

            int a = int.Parse(numbers[0]);
            int b = int.Parse(numbers[1]);            
            int x = a + b;

            Console.WriteLine($"X = {x}");
        }
    }
}
