using System;
using System.IO;

namespace Zaj4_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Co chcesz usunąć (napisz plik lub folder)");
                string wybor = Console.ReadLine();

                if(wybor == "plik")
                {
                    Console.WriteLine("Podaj ściężkę pliku do usunięcia");
                    string filepath = Console.ReadLine();

                    Console.WriteLine("Jesteś pewny? (napisz tak lub nie)");
                    string usunPlik = Console.ReadLine();

                    if (usunPlik == "tak")
                    {
                        File.Delete(filepath);
                        break;
                    }
                    else
                    {
                        continue;
                    }

                    
                }
                if(wybor == "folder")
                {
                    Console.WriteLine("Podaj ściężkę katalogu do usunięcia");
                    string folderpath = Console.ReadLine();

                    Console.WriteLine("Jesteś pewny? (napisz tak lub nie)");
                    string usunFolder = Console.ReadLine();

                    if(usunFolder == "tak")
                    {
                        Directory.Delete(folderpath, true);
                        break;
                    }
                    else
                    {
                        continue;
                    }

                    
                }
            }
            

        }
    }
}
