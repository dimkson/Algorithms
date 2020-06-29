using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort(500);
            Console.WriteLine("\nКоличество операций: " +
                bubbleSort.BubbleSortSimple());
            Console.ReadLine();
            Console.WriteLine("\nКоличество операций: " +
                bubbleSort.BubbleSortOptimized());
            Console.ReadLine();
            Console.WriteLine("\nКоличество операций: " +
                CocktailShakerSort.ShakerSort());
            Console.ReadLine();
        }
    }
}
