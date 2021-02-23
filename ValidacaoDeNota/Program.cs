using System;
using System.Globalization;

namespace ValidacaoDeNota
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = 0.0;
            int i = 0;
            while (i != 2)
            {   string entry = Console.ReadLine();
                double grade;
                grade = double.Parse(entry, CultureInfo.InvariantCulture);
                
                if (grade >= 0 && grade <= 10)
                {
                    grades += grade;
                    i++;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }  
            double avarage = grades / 2;
            Console.WriteLine($"media = {avarage.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}