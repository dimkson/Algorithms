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
            //int[] arr = new int[50];
            //Random rnd = new Random();
            //for (int i = 0; i < 50; i++)
            //{
            //    arr[i] = rnd.Next(0, 100);
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Task01(arr);
            Task02();
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

        static void Task02()
        {
            //Реализовать быструю сортировку
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
        static void QuickSort(int[] arr, int first, int last)
        {
            int i = first;
            int j = last;
            int x = arr[(first + last) / 2];
            do
            {
                while (arr[i] < x)
                    i++;
                while (arr[j] > x)
                    j--;
                if (i <= j)
                {
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i <= j);

            if (i < last)
                QuickSort(arr, i, last);
            if (first < j)
                QuickSort(arr, first, j);
        }
        static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
    }
}
