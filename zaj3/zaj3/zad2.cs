using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj3
{
    internal class zad2
    {
        public static void Delta()
        {
            try
            {
                Console.WriteLine("Podaj a");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("podaj b");
                var b = double.Parse(Console.ReadLine());
                Console.WriteLine("podaj c");
                var c = double.Parse(Console.ReadLine());
                Console.WriteLine("Wynik to{0}", LiczDelte(a, b, c));
            }
            catch (Exception e)
            {

                Console.WriteLine("cos zle podales{0}", e);
            }
        }
           
            
            
        

        private static double LiczDelte(double a,double b, double c)
        {
            var wynik = Math.Pow(b, 2) - (4 * a * c);
            return wynik;
        }
    }
}
