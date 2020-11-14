using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[50];
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Task01(arr);
            Console.ReadLine();
        }
        static void Task01(int[] arr)
        {
            //Реализовать сортировку подсчетом.

            int max = arr[0];
            foreach (int item in arr)
            {
                if (item > max) max = item;
            }
            int[] arrCount = new int[max + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arrCount[arr[i]]++;
            }
            for (int i = 0; i < arrCount.Length; i++)
            {
                for (int j = 0; j < arrCount[i]; j++)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
