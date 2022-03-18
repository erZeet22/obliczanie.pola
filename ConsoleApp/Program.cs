using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string r;
            double conv;

            Console.Write("Podaj średnice twojego koła: ");
            
            r = Console.ReadLine();

            conv = Convert.ToInt32(r);

            double wynik = Math.PI * (conv * conv);


            Console.WriteLine($"Pole twojego koła wynosi {Math.Round(wynik)}");

        }
    }
}
