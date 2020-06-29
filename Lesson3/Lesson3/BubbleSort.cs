using System;

namespace Lesson3
{
    class BubbleSort
    {
        public static int BubbleSortSimple(int[] array)
        {
            //Сортировка пузырьком без оптимизации
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);
            Console.WriteLine("Массив до сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            int count = 0;
            DateTime start = DateTime.Now;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    count++;
                    if (arr[j] > arr[j + 1])
                    {
                        count++;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
            TimeSpan total = DateTime.Now - start;
            Console.WriteLine("\nВремя работы алгоритма: " + total.TotalMilliseconds);
            Console.WriteLine("Массив после сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            return count;
        }

        public static int BubbleSortOptimized(int[] array)
        {
            //Сортировка пузырьком, добавлен флаг для выхода если массив отсортирован 
            //запоминается индекс последнего удачного обмена
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);
            Console.WriteLine("Массив до сортировки:");
            foreach (int n in arr) Console.Write(n + " ");
            int count = 0, right = arr.Length - 1, temp = 0;
            bool flag = true;
            DateTime start = DateTime.Now;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < right; j++)
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
                right = temp;
                if (flag) break;
                flag = true;
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
