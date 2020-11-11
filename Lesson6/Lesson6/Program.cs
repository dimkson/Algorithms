using System;
using System.IO;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenus = { Task01, Task02 };
            Menu menu = new Menu(delMenus);
            menu.ChooseMenu();
        }

        #region Задание1
        static void Task01()
        {
            //Реализовать простейшую хэш-функцию.
            //На вход функции подается строка, на выходе получается сумма кодов символов.
            string str = FC.Input("Введите строку");
            int hash = 0;
            foreach (char ch in str)
            {
                hash += ch;
            }
            Console.WriteLine("Hash function: " + hash);
            FC.Pause();
        }
        #endregion

        #region Задание2
        static void Task02()
        {
            //Бинарное дерево
            string path = FC.Input("Укажите путь к файлу");
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден!");
                FC.Pause();
                return;
            }

            BinaryTree binaryTree = new BinaryTree(path);

            binaryTree.Find();
        }
        #endregion
    }
}
