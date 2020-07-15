using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class SelectionSortClass
    {
        public static int SelectionSort(int[] array)
        {
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);
            Console.WriteLine("Массив до сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            int min, pos, count = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                min = arr[i];
                pos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    count++;
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        pos = j;
                    }
                }
                count++;
                if (i != pos) Swap(ref arr[i], ref arr[pos]);
            }
            TimeSpan total = DateTime.Now - start;
            Console.WriteLine("\nВремя работы алгоритма: " + total.TotalMilliseconds);
            Console.WriteLine("Массив после сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            return count;
        }
        private static void Swap(ref int i, ref int j)
        {
            i = i + j;
            j = i - j;
            i = i - j;
        }
    }
}
