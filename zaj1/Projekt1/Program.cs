using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = new int[10];
            var wartosc = 10;

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = wartosc;
                wartosc--;
            }

            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + " ");
                if(tab1[i] == 10 || tab1[i] == 8 || tab1[i] == 5)
                {
                    Console.WriteLine();
                }
                
            }
            Console.ReadKey();
        }
    }
}
