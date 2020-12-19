using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = n - 1; i >= 0; i--) // i - ilość spacji, jednocześnie numeruje nam wiersze
            {

                if (i == n - 1 || i == n - 2 || i == 0)
                {
                    // spacje
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    // krzyżyki n-i
                    for (int k = 0; k < n - i; k++)
                    {
                        Console.Write("X");
                    }

                    // nowa linia
                    Console.WriteLine();
                }

                else {

                    // spacje
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("X");

                    for (int k = 0; k < n - i - 2; k++)
                    {
                        Console.Write(" ");
                    }
                    
                    Console.Write("X");

                    // nowa linia
                    Console.WriteLine();
                }
            }


            Console.ReadKey();
        }
    }
}
