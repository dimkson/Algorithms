using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenus = new Menu.delMenu[] { Task01,Task02, Task03 };
            Menu menu = new Menu(delMenus);
            menu.ChooseMenu();
            //Type type = typeof(FastConsole);
            //MethodInfo[] methodInfos = type.GetMethods();
            //foreach(var v in methodInfos)
            //{
            //    Console.WriteLine(v.Name);
            //}
            //FC.Pause();

        }

        static void Task01()
        {
            /*1. Ввести вес и рост человека. 
             * Рассчитать и вывести индекс массы тела по формуле I = m / (h * h), где
             * m – масса тела в килограммах, h – рост в метрах.*/
            FC.Input("Введите массу тела в кг", out int weight);
            FC.Input("Введите рост в метрах", out double height);
            Console.WriteLine($"Индекс массы тела равен: {weight / (height * height):#.##}");
            FC.Pause();
        }
        static void Task02()
        {
            //2. Найти максимальное из четырёх чисел. Массивы не использовать.
            FC.Input("Введите первое число", out int max);
            FC.Input("Введите второе число", out int b);
            FC.Input("Введите третье число", out int c);
            FC.Input("Введите четвертое число", out int d);
            if (max < b) max = b;
            if (max < c) max = c;
            if (max < d) max = d;
            Console.WriteLine($"Максимальное число: {max}");
            FC.Pause();
        }
        static void Task03()
        {
            /*3. Написать программу обмена значениями двух целочисленных переменных:
             * a. С использованием третьей переменной.
             * b. *Без использования третьей переменной.*/
            FC.Input("Введите первое число", out int a);
            FC.Input("Введите второе число", out int b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Первое число: {a}, второе число: {b}");
            FC.Pause();
        }
    }

}
