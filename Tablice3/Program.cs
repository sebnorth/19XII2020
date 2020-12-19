using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice3
{
    class Program
    {

        static bool FirstLast6(int[] tab) {

            if (tab[0] == 6 || tab[tab.Length - 1] == 6)
                return true;
            else
                return false;
        }


        static void Main(string[] args)
        {
            int[] x = { 1, 2, 6 };


            Console.WriteLine(FirstLast6(x));

            Console.WriteLine(FirstLast6(new int[] { 6,1,2,3}));

            Console.WriteLine(FirstLast6(new int[] { 13, 6, 1, 2, 3 }));

            Console.ReadKey();
        }
    }
}
