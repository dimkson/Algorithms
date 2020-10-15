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
            Menu.delMenu[] delMenu = { Task01, Task03, Task05, Task06 };
            Menu menu = new Menu(delMenu);
            menu.ChooseMenu();
        }

        #region Задание 1
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
        #endregion

        #region Задание 3
        static void Task03()
        {
            //Написать программу, которая определяет, является ли введённая скобочная последовательность правильной.
            string str = FC.Input("Введите скобочную последовательность");
            char temp;
            Stack<char> stack = new Stack<char>();
            foreach (char ch in str)
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
        #endregion

        #region Задание 5
        static void Task05()
        {
            //Реализовать алгоритм перевода из инфиксной записи арифметического выражения в постфиксную.
            string str = FC.Input("Введите арифметическое выражение");
            string outStr = string.Empty;
            char lastChar = ' ';

            Stack<char> stack = new Stack<char>();
            foreach (char ch in str)
            {
                if (char.IsDigit(ch))
                {
                    outStr += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                    lastChar = '(';
                }
                else if (ch == ')')
                {
                    char temp;
                    do
                    {
                        temp = stack.Pop();
                        if (temp != '(')
                            outStr += temp;
                    } while (temp != '(');
                }
                else
                {
                    outStr += ' ';
                    if (Priority(ch) <= Priority(lastChar))
                    {
                        outStr += stack.Pop();
                        outStr += ' ';
                    }
                    stack.Push(ch);
                    lastChar = ch;
                }
            }
            while (stack.Count != 0)
            {
                outStr += stack.Pop();
                outStr += ' ';
            }
            Console.WriteLine(outStr);
            FC.Pause();
        } 
        static int Priority(char ch)
        {
            switch (ch)
            {
                //case '(':
                //    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
        #endregion

        #region Задание 6
        static void Task06()
        {
            //Реализовать очередь с использованием массива.
            MyQueue myQueue = new MyQueue(5);
            for (int i = 0; i < 7; i++)
            {
                myQueue.Enqueue(i+1);
            }
            for (int i = 0; i < 3; i++)
            {
                myQueue.Dequeue();
            }
            for (int i = 0; i < 5; i++)
            {
                myQueue.Enqueue(i+10);
            }
            FC.Pause();
        }
        #endregion

        #region Задание 7
        static void Task7()
        {
            //Реализовать двустороннюю очередь.

        }
        #endregion
    }
}
