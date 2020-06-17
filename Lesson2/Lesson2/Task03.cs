using System;
using FC = MenuLib.FastConsole;

namespace Lesson2
{
    /*3. **Исполнитель «Калькулятор» преобразует целое число, записанное на экране. У
     * исполнителя две команды, каждой присвоен номер:
     * 1. Прибавь 1.
     * 2. Умножь на 2.
     * Первая команда увеличивает число на экране на 1, вторая увеличивает его в 2 раза.
     * Определить, сколько существует программ, которые преобразуют число 3 в число 20:
     * а. С использованием массива.
     * b. *С использованием рекурсии.*/
    class Task03
    {
        public static void Calc()
        {
            FC.Input("Введите a", out int a);
            FC.Input("Введите b", out int b);
            CalcRec(a, b);
            Console.WriteLine($"Кол-во вариантов: {counter}, общее количество запусков функции {k}");
            CalcNoRec(a, b);
            FC.Pause();
        }
        static int counter = 0;
        static int k = 0;
        static void CalcRec(int a, int b)
        {
            k++;
            if (b > a)
            {
                if (b % 2 == 0) CalcRec(a, b / 2);
                CalcRec(a, b - 1);
            }
            else
                if (a == b) counter++;
        }
        static void CalcNoRec(int a, int b)
        {
            int[] arr = new int[b + 1];
            arr[b]++;
            for(int i = b; i > a; i--)
            {
                if (i % 2 == 0) arr[i / 2] += arr[i];
                arr[i - 1] += arr[i];
            }
            Console.WriteLine($"Кол-во вариантов: {arr[a]}");
        }
    }
}
