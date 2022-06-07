using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Zaj4_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = Console.ReadLine();
            string filePath = "C:\\Users\\Jakub\\Desktop\\" + fileName;

            string folderName = Console.ReadLine();

            Directory.CreateDirectory(folderName);

            var plik = File.Create(filePath);
            plik.Close();

            TextWriter tw = new StreamWriter(filePath);

            for (int i=0; i < 10; i++)
            {
                
                Random rnd = new Random();
                int number = rnd.Next(1, 100);

                tw.WriteLine(number);
                
            }
            tw.Close();



            var file = File.ReadAllLines(filePath);
            var numbersStringList = new List<string>(file);

            List<int> numbers = numbersStringList.Select(s => int.Parse(s)).ToList();

            int[] nums = numbers.ToArray();

            Sorting quicksort = new Sorting();

           quicksort.QuickSort(nums, 0, nums.Length -1);

            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }

        }

        public class Sorting
        {
            public void QuickSort(int[] arr, int start, int end)
            {
                int i;
                if (start < end)
                {
                    i = Partition(arr, start, end);

                    QuickSort(arr, start, i - 1);
                    QuickSort(arr, i + 1, end);
                }
            }

            public int Partition(int[] arr, int start, int end)
            {
                int temp;
                int p = arr[end];
                int i = start - 1;

                for (int j = start; j <= end - 1; j++)
                {
                    if (arr[j] <= p)
                    {
                        i++;
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

                temp = arr[i + 1];
                arr[i + 1] = arr[end];
                arr[end] = temp;
                return i + 1;
            }
        }
        
    }
}
