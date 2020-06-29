using System;

namespace Lesson3
{
    class BinarySearchClass
    {
        public static int BinarySearch(int[] array, int target)
        {
            //Бинарный поиск
            int[] arr = new int[array.Length];
            array.CopyTo(arr, 0);
            Console.WriteLine("Исходный массив:");
            foreach (int n in arr) Console.Write(n + " ");
            int left = 0, right = arr.Length - 1, count = 0;
            int position = left + (right - left) / 2;
            while (arr[position] != target && left <= right)
            {
                if (arr[position] > target)
                    right = position - 1;
                else
                    left = position + 1;
                count++;
                position = (right - left) / 2 + left;
            }
            Console.WriteLine("\nКоличество операций: " + count);
            if (arr[position] == target) return position;
            else return -1;
        }
    }
}
