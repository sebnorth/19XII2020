using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choinka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            int p = 2 * n - 1; // wzór na ilość gwiazdek w podstawie choinki

            int z; // zmienna przechowująca znak: spację lub *

            for (int i = 1; i <= n; i++) // numer wiersza
            {
                int x = 2 * i - 1; // wzór na ilość gwiazdek

                // pierwszy ciąg spacji
                for (z = 0; z < (p-x)/2; z++)
                {
                    Console.Write(" ");
                }

                // ciąg gwiazdek
                for ( z = 0; z < x; z++)
                {
                    Console.Write("*");
                }
                // drugi ciąg spacji
                for (z = 0; z < (p - x) / 2; z++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
