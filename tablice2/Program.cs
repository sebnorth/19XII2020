using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice2
{
    class Program
    {

        static int PodwojElement(int[] tab, int indeks) {

            return 2 * tab[indeks];
        }
        
        static void Main(string[] args)
        {
            int[] tablica = { -1, -10, -100, -1000 };

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.Write("{0} ", PodwojElement(tablica, i)); 
            }
            

            Console.ReadKey();
        }
    }
}
