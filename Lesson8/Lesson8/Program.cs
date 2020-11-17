using System;
using MenuLib;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenu = { Count, Quick, Insertation };
            Menu menu = new Menu(delMenu);
            menu.ChooseMenu();
        }

        static void Count()
        {
            //Реализовать сортировку подсчетом
            Console.WriteLine("Сортировка подсчетом");
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            CountSort(arr);
            Console.ReadLine();
        }
        static void CountSort(int[] arr)
        {
            //Сортировка подсчетом.

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

        static void Quick()
        {
            //Реализовать быструю сортировку
            Console.WriteLine("Быстрая сортировка");
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            QuickSort(arr, 0, arr.Length - 1);
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.ReadLine();
        }
        static void QuickSort(int[] arr, int first, int last)
        {
            //Быстрая сортировка
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

        static void Insertation()
        {
            //Реализовать алгоритм сортировки вставками с бинарным поиском
            Console.WriteLine("Сортировка вставками с бинарным поиском");
            int[] arr = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                arr[i] = rnd.Next(0, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            InsertSortBinary(arr);
            foreach (int item in arr)
                Console.Write(item + " ");
            Console.ReadLine();
        }
        static void InsertSort(int[] arr)
        {
            int j, key;
            for (int i = 1; i < arr.Length; i++)
            {
                j = i;
                key = arr[i];
                while (j > 0 && arr[j - 1] > key)
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = key;
            }
        }

        static void InsertSortBinary(int[] arr)
        {
            //Сортировка вставками с бинарным поиском
            int j, key;
            int left, right, middle;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    key = arr[i];
                    left = 0;
                    right = i - 1;
                    
                    while (left < right)
                    {
                        middle = (right + left) / 2;
                        if (arr[middle] > key)
                            right = middle;
                        else
                            left = middle + 1;
                    }

                    j = i;
                    while (j > left)
                    {
                        arr[j] = arr[j - 1];
                        j--;
                    }
                    arr[left] = key; 
                }
            }
        }
    }
}
