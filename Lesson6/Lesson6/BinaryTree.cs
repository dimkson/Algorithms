using System;
using System.IO;
using FC = MenuLib.FastConsole;

namespace Lesson6
{
    class BinaryTree
    {
        /* Переписать программу, реализующую двоичное дерево поиска:
         * Добавить в него обход дерева различными способами.
         * Реализовать поиск в нем.
         * Добавить в программу обработку коммандной строки с помощью которой можно указывать,
         * из какого файла считывать данные, каким образом обходить дерево.*/

        #region Поля
        private int[] arrInt, arrTree;
        private string[] arrStr;
        private int index;
        #endregion

        #region Конструктор
        public BinaryTree(string path)
        {
            //Считываем данные из файла и сохраняем их в массив arrInt
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                arrStr = sr.ReadToEnd().Split(' ');
                arrInt = new int[arrStr.Length];

                for (int i = 0; i < arrStr.Length; i++)
                {
                    arrInt[i] = int.Parse(arrStr[i]);
                }

                //Инициализируем массив для дерева
                arrTree = new int[arrStr.Length * 4];
                Tree(arrInt.Length, 1);
                sr.Close();
                fs.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.ReadLine();
            }
        }
        #endregion

        #region Методы

        private void Tree(int lenght, int pos)
        {
            //Создаем бинарное дерево рекурсивным способном.
            int nl, nr;
            if (lenght == 0) 
                return;
            else
            {
                arrTree[pos] = arrInt[index];
                index++;
                nl = lenght / 2;
                nr = lenght - nl - 1;
                Tree(nl, pos * 2);
                Tree(nr, pos * 2 + 1);
            }
        }

        public void Print(int pos = 1)
        {
            //Печать дерева в скобочном виде рекурсивным способом.
            if (arrTree[pos] != 0)
            {
                Console.Write(arrTree[pos]);
                if (arrTree[pos * 2] != 0 || arrTree[pos * 2 + 1] != 0)
                {
                    Console.Write('(');
                    if (arrTree[pos * 2] != 0)
                        Print(pos * 2);
                    else
                        Console.Write("null");
                    Console.Write(',');
                    if (arrTree[pos * 2 + 1] != 0)
                        Print(pos * 2 + 1);
                    else
                        Console.Write("null");
                    Console.Write(')');
                }
            }
        }

        public void Find()
        {
            //Выбор метода поиска
            int type;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Выберите тип обхода дерева:");
                    Console.WriteLine("1 - КЛП (pre-order)");
                    Console.WriteLine("2 - ЛКП (in-order)");
                    Console.WriteLine("3 - ЛПК (post-order)");
                    Console.WriteLine("0 - Выход");
                } while (!int.TryParse(Console.ReadLine(), out type));
                if (type == 0) return;
            } while (type > 3 || type < 1);

            Print();

            FC.Input("\nВведите искомое число", out int num);

            //Запус выбранного метода поиска
            switch (type)
            {
                case 1:
                    FindPreOrder(num);
                    break;
                case 2:
                    FindInOrder(num);
                    break;
                case 3:
                    FindPreOrder(num);
                    break;
                default:
                    break;
            }
            FC.Pause();
        }

        private void FindPreOrder(int i, int pos = 1)
        {
            //Обход дерева Корень - Лево - Право
            if (arrTree[pos] != 0)
            {
                if (arrTree[pos] == i)
                {
                    Console.WriteLine("Элемент найден в позиции " + pos);
                }
                else
                {
                    FindPreOrder(i, pos * 2);
                    FindPreOrder(i, pos * 2 + 1);
                }
            }
        }
        private void FindInOrder(int i, int pos = 1)
        {
            //Обход дерева Лево - Корень - Право
            if (arrTree[pos] != 0)
            {
                FindInOrder(i, pos * 2);
                if (arrTree[pos] == i)
                {
                    Console.WriteLine("Элемент найден в позиции " + pos);
                }
                FindInOrder(i, pos * 2 + 1);
            }
        }
        private void FindPostOrder(int i, int pos)
        {
            //Обход дерева Лево - Право - Корень
            if (arrTree[pos] != 0)
            {
                FindPostOrder(i, pos * 2);
                FindPostOrder(i, pos * 2 + 1);
                if (arrTree[pos] == i)
                {
                    Console.WriteLine("Элемент найден в позиции " + pos);
                }
            }
        }
        #endregion

    }
}
