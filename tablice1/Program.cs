using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = { 1,2,3,4,10};

            // tablica[4] = 100;

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = 100;
            }


            foreach (int item in tablica)
            {
                
                Console.WriteLine(item);
            }

            Console.WriteLine(tablica);

            Console.ReadKey();

            //int x;
            //Console.WriteLine(x);
        }
    }
}
