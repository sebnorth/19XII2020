using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++) // j - numer wiersza
            {
                for (int i = 0; i < n; i++) // i - w której kolumnie stawiamy gwiazdkę
                {
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }

            Console.ReadKey();
        }
    }
}
