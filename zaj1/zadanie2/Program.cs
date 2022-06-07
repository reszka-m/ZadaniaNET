using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            WypelnienieTablicy();
            Console.ReadKey();
        }

        private static void WypelnienieTablicy()
        {
            int[] arr = new int[50];

            for (int i = 1; i <= 10; i++)
            {
                arr = Fibonacci(i);

                Console.Write("tab[{0}] = ", i);
                for (int j = arr[i]; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine("");
            }
        }
        private static int[] Rev(int num)
        {
            int[] tab2 = new int[num];
            for (int i = 0; i < num; num--)
            {
                tab2[i] = num;
            }
            return tab2;
        }
        private static int[] Fibonacci(int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException();

            var n = number + 1;
            var a = new int[n];
            a[0] = 0;

            if (number == 0)
                return a;

            a[1] = 1;

            for (var i = 2; i < n; i++)
                a[i] = a[i - 2] + a[i - 1];
            
            return a;
        }



       





    }
    
}
