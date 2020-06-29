using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class CocktailShakerSort
    {
        public static int ShakerSort()
        {
            int[] arr = new int[500];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            //int[] arr = { 2, 5, 4, 6, 4, 9 };
            Console.WriteLine("Массив до сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            int count = 0,
                left = 0,
                right = arr.Length - 1,
                temp = 0;
            bool flag = true;
            DateTime start = DateTime.Now;
            while (left < right)
            {
                for (int j = left; j < right; j++)
                {
                    count++;
                    if (arr[j] > arr[j + 1])
                    {
                        count++;
                        flag = false;
                        temp = j;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (flag) break;
                flag = true;
                right = temp;
                for (int j = right; j > left; j--)
                {
                    count++;
                    if (arr[j] < arr[j - 1])
                    {
                        count++;
                        flag = false;
                        temp = j;
                        Swap(ref arr[j], ref arr[j - 1]);
                    }
                }
                if (flag) break;
                flag = true;
                left = temp;
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
