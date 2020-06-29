using MenuLib;
using System;
using FC = MenuLib.FastConsole;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenu = { Bubble, Shaker, Binary, Selection, SortCompare };
            Menu menu = new Menu(delMenu);
            menu.ChooseMenu();
        }
        static void Bubble()
        {
            //Сортировка пузырьком и оптимизированная сортировка пузырьком
            FC.Input("Введите размер массива", out int num);
            int[] array = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            //BubbleSort bubbleSort = new BubbleSort(num);
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine("\nКоличество операций: " +
                BubbleSort.BubbleSortSimple(array));
            Console.ReadLine();
            Console.WriteLine("Оптимизированная сортировка пузырьком");
            Console.WriteLine("\nКоличество операций: " +
                BubbleSort.BubbleSortOptimized(array));
            FC.Pause();
        }
        static void Shaker()
        {
            //Шейкерная сортировка
            FC.Input("Введите размер массива", out int num);
            int[] array = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            Console.WriteLine("\nКоличество операций: " +
                CocktailShakerSort.ShakerSort(array));
            Console.ReadLine();     
        }
        static void Binary()
        {
            //Бинарный поиск
            FC.Input("Введите размер массива", out int num);
            int[] array = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            Array.Sort(array);
            FC.Input("Введите искомое значение", out int target);
            Console.WriteLine("Результат: " + BinarySearchClass.BinarySearch(array, target));
            FC.Pause();
        }
        static void Selection()
        {
            //Сортировка выбором
            FC.Input("Введите размер массива", out int num);
            int[] array = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            Console.WriteLine("\nКоличество операций: " +
                SelectionSortClass.SelectionSort(array));
            Console.ReadLine();
        }

        static void SortCompare()
        {
            //Сравнение эффективности сортировок
            FC.Input("Введите размер массива", out int num);
            int[] array = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(1, 100);
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine("\nКоличество операций: " +
                BubbleSort.BubbleSortSimple(array));
            Console.ReadLine();
            Console.WriteLine("Оптимизированная сортировка пузырьком");
            Console.WriteLine("\nКоличество операций: " +
                BubbleSort.BubbleSortOptimized(array));
            Console.ReadLine();
            Console.WriteLine("Шейкурная сортировка");
            Console.WriteLine("\nКоличество операций: " +
                CocktailShakerSort.ShakerSort(array));
            Console.ReadLine();
            Console.WriteLine("Сортировка выбором");
            Console.WriteLine("\nКоличество операций: " +
                SelectionSortClass.SelectionSort(array));
            Console.ReadLine();
        }
    }
}
