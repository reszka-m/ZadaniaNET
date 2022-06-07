using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zaj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Zad1{
        private double liczba;
        private char znak;

        public Zad1(double liczba1)
        {
            this.liczba = liczba1;
        }

        public Zad1(char znak1)
        {
            this.znak = znak1;
        }

        public Zad1(double liczba2, char znak2)
        {
            this.liczba = liczba2;
            this.znak = znak2;
        }

        public Zad1(double liczba3, double liczba4)
        {
            while (liczba3 != liczba4)
            {
                if (liczba3 > liczba4)
                    liczba3 -= liczba4;
                else
                    liczba4 -= liczba3;
            }
        }

        public Zad1(int[] tablica)
        {
            int i, j, zakres, dokad;

            zakres = tablica.Length;
            dokad = (int)Math.Floor(Math.Sqrt(zakres));

            for (i = 1; i <= zakres; i++) tablica[i] = i;

            for (i = 2; i <= dokad; i++)
            {
                if (tablica[i] != 0)
                {
                    j = i + i;
                    while (j <= zakres)
                    {
                        tablica[j] = 0;
                        j += i;
                    }
                }
            }

            for (i = 2; i <= zakres; i++)
                if (tablica[i] != 0)
                    Console.WriteLine(i + ", ");
        }
    }
}
