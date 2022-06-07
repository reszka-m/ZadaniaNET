using System;
using System.IO;
using System.Linq;

namespace Zaj4_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ściężkę do folderu");
            string folderPath = Console.ReadLine();
            var size = Directory.GetFiles(@folderPath, "*", SearchOption.AllDirectories).Sum(t => (new FileInfo(t).Length));
            Console.WriteLine(size);

        }
    }
}
