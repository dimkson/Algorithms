using System;
using FC = MenuLib.FastConsole;

namespace Lesson4
{
    class Routes
    {
        public static void Route()
        {
            /* За один ход королю разрешается передвинуться на одну клетку вниз или вправо.
             * Необходимо определить, сколько существует различных маршрутов,
             * из левого верхнего угла в правый нижний.
             * Подсчитать количество маршрутов с препятствиями. 
             * Реализовать чтение массива с препятствием и найти количество маршрутов.*/
            FC.Input("Введите количество строк", out int n);
            FC.Input("Введите количество столбцов", out int m);
            int[,] A = new int[n, m];
            int[,] map = new int[n, m];
            //Формируем массив с препятствиями
            Random random = new Random();
            int temp;
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    temp = random.Next(0, 10);
                    map[i, j] = temp != 0 ? 1 : 0;
                }
            }
            Print(map);
            Console.WriteLine();

            //Заполняем массив количеством маршрутов до каждой клетки
            if (map[0, 0] != 0) A[0, 0] = 1;
            for (int j = 1; j < m; j++)
                if (map[0, j] != 0) A[0, j] = A[0, j - 1];
            for(int i = 1; i < n; i++)
            {
                if (map[i, 0] != 0) A[i, 0] = A[i - 1, 0];
                for(int j = 1; j < m; j++)
                {
                    if (map[i, j] != 0)
                        A[i, j] = A[i - 1, j] + A[i, j - 1];
                }
            }
            Print(A);
            FC.Pause();

        }
        static void Print(int[,] arr)
        {
            //Вывод массива на консоль
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
