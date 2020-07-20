using System;

namespace Lesson4
{
    class ChessHorse
    {

        static int[,] desk = new int[8, 8];
        static int[,] steps = { {2,1}, {1,2}, {-1,2}, {-2,1}, {-2,-1}, {-1,-2}, 
            {1,-2}, {2,-1} };
        static bool flag;

        public static void Horse()
        {
            int x = 0, y = 0;
            desk[x, y] = 1;
            Step(x, y);
            Print(desk);
            Console.ReadLine();
        }

        static void Step(int x, int y)
        {
            if (Check(desk))
            {
                flag = true;
                return;
            }
                
            for (int i = 0; i < steps.GetLength(0); i++)
            {
                if (x + steps[i, 0] < 8 && x + steps[i, 0] >= 0)
                {
                    if (y + steps[i, 1] < 8 && y + steps[i, 1] >= 0)
                    {
                        if (desk[x + steps[i, 0], y + steps[i, 1]] == 0)
                        {
                            desk[x + steps[i, 0], y + steps[i, 1]] = 1;
                            Step(x + steps[i, 0], y + steps[i, 1]);
                        }
                    }
                }
            }
            if(!flag) desk[x, y] = 0;
        }

        static bool Check(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0) return false;
                }
            }
            return true;
        }

        static void Print(int[,] arr)
        {
            //Вывод массива на консоль
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
