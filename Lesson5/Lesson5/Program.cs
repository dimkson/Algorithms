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
            Menu.delMenu[] delMenu = { Task01 };
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
    }
}
