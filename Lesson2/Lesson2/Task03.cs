using MenuLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FC.Pause();
        }
        static int counter = 0;
        static int k = 0;
        static void CalcRec(int a, int b)
        {
            k++;
            if (b > a)
            {
                if (b % 2 == 0)
                {
                    CalcRec(a, b - 1);
                    CalcRec(a, b / 2);
                }
                else
                    CalcRec(a, b - 1);
            }
            else
                if (a == b) counter++;
        }
    }
}
