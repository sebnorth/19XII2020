using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            // etap 1 - wzór trójkąt z gwiazdek
            // etap 2 - podmieniamy gwiazdki na liczby

            Console.WriteLine("Podaj n: ");
            int n = int.Parse(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {

                for (int i = 0; i <= j; i++)
                {
                    Console.Write("{0,4} ", (j+1)*(i+1));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
