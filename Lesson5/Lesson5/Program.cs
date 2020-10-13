using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenu = { Task01, Task03 };
            Menu menu = new Menu(delMenu);
            menu.ChooseMenu();
        }

        static void Task01()
        {
            //Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
            FC.Input("Введите число", out int num);
            Stack stack = new Stack();
            do
            {
                stack.Push(num % 2);
                num /= 2;
            } while (num != 0);

            while (stack.Count != 0)
                Console.Write(stack.Pop());
            FC.Pause();
        }
        static void Task03()
        {
            //Написать программу, которая определяет, является ли введённая скобочная последовательность правильной.
            string str = FC.Input("Введите скобочную последовательность");
            char temp;
            Stack<char> stack = new Stack<char>();
            foreach(char ch in str)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                    stack.Push(ch);
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("Количество открывающихся скобок не равно количеству закрывающихся");
                        FC.Pause();
                        return;
                    }
                    temp = stack.Pop();
                    if (ch - temp > 2 || ch - temp < 1)
                    {
                        Console.WriteLine("Скобочная последовательность не правильная");
                        FC.Pause();
                        return;
                    }
                }
            }
            if (stack.Count > 0)
                Console.WriteLine("Количество открывающихся скобок не равно количеству закрывающихся");
            else
                Console.WriteLine("Скобочная последовательность правильная!");
            FC.Pause();
        }
    }
}
