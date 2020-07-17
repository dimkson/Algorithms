using System;

namespace Lesson4
{
    class Sequences
    {
        public static void Sequence()
        {
            //Решить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы.
            string str1 = "geekbrains";
            string str2 = "geekminds";
            int[,] arr = new int[str1.Length + 1, str2.Length + 1];
            for(int i = 1; i <= str1.Length; i++)
            {
                for(int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        arr[i, j] = arr[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                    }
                }
            }
            Print(arr);
            Console.WriteLine("\nМаксимальная длина подпоследовательности - "
                + arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1]);
            Console.ReadLine();
        }
        static void Print(int[,] arr)
        {
            //Вывод массива на консоль
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
