using System;
using FC = MenuLib.FastConsole;

namespace Lesson2
{
    class Task02
    {
        /*2. Реализовать функцию возведения числа a в степень b:
         * a. Без рекурсии.
         * b. Рекурсивно.
         * c. *Рекурсивно, используя свойство чётности степени.*/
        public static void Pow()
        {
            FC.Input("Введите a", out int a);
            FC.Input("Введите b", out int b);
            PowNoRec(a, b);
            PowRec(1, a, b);
            PowRecFast(1, a, b);
            FC.Pause();
        }
        static void PowNoRec(int a, int b)
        {
            int res = 1;
            while (b != 0)
            {
                res *= a;
                b--;
            }
            Console.WriteLine($"а) A в степени B равно {res} (без рекурсии)");
        }
        static void PowRec(int res, int a, int b)
        {
            if (b > 0)
                PowRec(res * a, a, --b);
            else
                Console.WriteLine($"б) A в степени B равно {res} (с рекурсией)");
        }
        static void PowRecFast(int res, int a, int b)
        {
            if (b > 0)
            {
                if (b % 2 == 0)
                    PowRecFast(res, a * a, b / 2);
                else
                    PowRecFast(res * a, a, --b);
            }
            else
                Console.WriteLine($"в) A в степени B равно {res} (используя св-во четности)");
        }
    }
}
