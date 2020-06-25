using System;
using System.Collections.Generic;
using FC = MenuLib.FastConsole;

namespace Lesson2
{
    //1. Реализовать функцию перевода чисел из десятичной системы в двоичную, используя рекурсию.
    class Task01
    {
        static List<int> list = new List<int>();
        public static void Convert()
        {
            FC.Input("Введите число в десятичной системе счисления", out int num);
            DecToBin(num);
            foreach (int n in list) Console.Write(n);
            FC.Pause();
        }
        static void DecToBin(int n)
        {
            if (n > 0)
            {
                DecToBin(n / 2);
                list.Add(n % 2);
            }
        }
    }
}
