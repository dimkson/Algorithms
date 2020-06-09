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
            Menu.delMenu[] delMenus = new Menu.delMenu[] { Task01,Task02, Task03,
                Task04, Task05, Task06, Task07};
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
        static void Task04()
        {
            //4. Написать программу нахождения корней заданного квадратного уравнения.
            FC.Input("Введите a", out int a);
            FC.Input("Введите b", out int b);
            FC.Input("Введите c", out int c);
            Console.WriteLine($"Квадратное уравнение: {a}x^2+({b}x)+({c})=0");
            double D = b * b - 4 * a * c;
            double res1, res2;
            if (D > 0)
            {
                res1 = (-b + Math.Sqrt(D)) / (2 * a);
                res2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Корни уравнения x1={res1}, x2={res2}");
            }
            else if(D==0)
            {
                res1 = -b / 2 * a;
                Console.WriteLine($"Корень уравнения x={res1}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет корней");
            }
            FC.Pause();
        }
        static void Task05()
        {
            /*5. С клавиатуры вводится номер месяца.
             * Требуется определить, к какому времени года он относится.*/
            FC.Input("Введите номер месяца", out int month);
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("Зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Необходимо ввести число от 1 до 12");
                    break;
            }
            FC.Pause();
        }
        static void Task06()
        {
            /*6. Ввести возраст человека (от 1 до 150 лет) 
             * и вывести его вместе со словом «год», «года» или «лет».*/
            FC.Input("Введите возраст", out int age);
            string years;
            int temp = age % 100;
            if ((temp > 10 && temp < 15))
                years = "лет";
            else
            {
                temp = age % 10;
                if (temp == 1)
                    years = "год";
                else if (temp > 1 && temp < 5)
                    years = "года";
                else
                    years = "лет";
            }
            Console.WriteLine($"Возраст {age} {years}");
            FC.Pause();
        }
        static void Task07()
        {
            /*7. С клавиатуры вводятся числовые координаты двух полей шахматной доски 
             * (x1, y1, x2, y2).
             * Требуется определить, относятся ли к поля к одному цвету или нет.*/
            FC.Input("Введите x1", out int x1);
            FC.Input("Введите y1", out int y1);
            FC.Input("Введите x2", out int x2);
            FC.Input("Введите y2", out int y2);
            bool flag = (x1 + y1) % 2 == (x2 + y2) % 2;
            Console.WriteLine("Поля " + (flag ? "" : "не ") + "относятся к одному цвету");
            FC.Pause();
        }
    }

}
