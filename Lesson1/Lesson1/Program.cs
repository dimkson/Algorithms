using MenuLib;
using System;
using FC = MenuLib.FastConsole;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenus = new Menu.delMenu[] { Task01, Task02, Task03,
                Task04, Task05, Task06, Task07, Task08, Task09, Task10, Task11, Task12, Task13, Task14};
            Menu menu = new Menu(delMenus);
            menu.ChooseMenu();
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
            else if (D == 0)
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
        static void Task08()
        {
            //8. Ввести a и b и вывести квадраты и кубы чисел от a до b.
            FC.Input("Введите a", out int a);
            FC.Input("Введите b", out int b);
            for (int i = a; i <= b; i++)
                Console.WriteLine($"x={i,5} : x^2={i * i,5} : x^3={i * i * i,5}");
            FC.Pause();
        }
        static void Task09()
        {
            /*9. Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти
             * частное от деления нацело N на K, а также остаток от этого деления.*/
            FC.Input("Введите первое число", out int N);
            FC.Input("Введите второе число", out int K);
            int count = 0;
            while (N > K)
            {
                N -= K;
                count++;
            }
            Console.WriteLine($"N делить на K:\nЧастное - {count}\nОстаток - {N}");
            FC.Pause();
        }
        static void Task10()
        {
            /*10. Дано целое число N > 0. С помощью операций деления нацело и взятия остатка от деления
             * определить, имеются ли в записи числа N нечётные цифры. Если имеются, то вывести True, если нет 
             * – вывести False.*/
            FC.Input("Введите число", out int N);
            bool flag = false;
            while (N > 0)
            {
                if ((N % 10) % 2 == 0)
                {
                    flag = true;
                    break;
                }
                N /= 10;
            }
            Console.WriteLine(flag.ToString());
            FC.Pause();
        }
        static void Task11()
        {
            /*11. С клавиатуры вводятся числа, пока не будет введён 0. Подсчитать среднее арифметическое всех
             * положительных чётных чисел, оканчивающихся на 8.*/
            int num, count = 0, sum = 0;
            do
            {
                FC.Input("Введите число или 0 для выхода", out num);
                if (num > 0 && num % 10 == 8)
                {
                    sum += num;
                    count++;
                }
            } while (num != 0);
            if (count > 0)
                Console.WriteLine($"Среднее арифметическое положительных чисел оканчивающихся на 8: {sum / count:D}");
            else
                Console.WriteLine($"Нет чисел, удовлетворяющих условию");
            FC.Pause();
        }
        static void Task12()
        {
            //12. Написать функцию нахождения максимального из трёх чисел.
            FC.Input("Введите первое число", out int max);
            FC.Input("Введите второе число", out int b);
            FC.Input("Введите третье число", out int c);
            if (max < b) max = b;
            if (max < c) max = c;
            Console.WriteLine($"Максимальное число {max}");
            FC.Pause();
        }
        static void Task13()
        {
            /*13. * Написать функцию, генерирующую случайное число от 1 до 100:
             * a. С использованием стандартной функции rand().
             * b. Без использования стандартной функции rand().*/
            Random random = new Random();
            Console.WriteLine($"Стандартная функция Random: {random.Next(1, 100)}");           
            Console.WriteLine($"Нестандартный Random: {(10 * DateTime.Now.Second + 50) % 100}");
            FC.Pause();
        }
        static void Task14()
        {
            /*14. * Автоморфные числа. Натуральное число называется автоморфным, если оно равно последним
             * цифрам своего квадрата. Например, 25^2 = 625. Напишите программу, которая получает на
             * вход натуральное число N и выводит на экран все автоморфные числа, не превосходящие N.*/
            int temp, count;
            double square, ost;
            FC.Input("Введите число", out int N);
            Console.WriteLine("Автоморфные числа: ");
            for(int i = 1; i <= N; i++)
            {
                count = 1;
                temp = i;
                while (temp > 0)
                {
                    count *= 10;
                    temp /= 10;
                }
                square = Math.Pow(i, 2);
                ost = square % count;
                if (i == ost)
                    Console.Write(i + " ");
            }
            FC.Pause();
        }
    }
}
