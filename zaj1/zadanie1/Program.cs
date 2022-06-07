using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i > 0; i--)
            {
                if (i % 3 == 0 && i % 2 != 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("");

            var o = 100;
            while (o>0)
            {
                if (o % 3 == 0 && o % 2 != 0)
                    Console.WriteLine(o);
                o--;
            }

            Console.ReadKey();
        }
    }
}
