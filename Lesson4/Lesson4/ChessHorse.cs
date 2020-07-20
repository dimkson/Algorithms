using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class ChessHorse
    {
        static int[,] desk = new int[8, 8];
        static int[,] steps = { {2,1}, {1,2}, {-1,2}, {-2,1}, {-2,-1}, {-1,-2}, 
            {1,-2}, {2,-1} };

        public static void Horse()
        {
            desk[0, 0] = 1;
            int x = 0, y = 0;
            Step(x, y);
        }

        static void Step(int x, int y)
        {
            if (Check(desk))
                return;
            for (int i = 0; i < steps.GetLength(0); i++)
            {
                if (x + steps[i, 0] < 8 && x + steps[i, 0] >= 0)
                {
                    if (y + steps[i, 1] < 8 && y + steps[i, 1] >= 0)
                    {
                        if (desk[x + steps[i, 0], y + steps[i, 1]] == 0)
                        {
                            //x += steps[i, 0];
                            //y += steps[i, 1];
                            desk[x + steps[i, 0], y + steps[i, 1]] = 1;
                            Step(x + steps[i, 0], y + steps[i, 1]);
                        }
                    }
                }
            }
            desk[x, y] = 0;
            //if (Step(x, y)) return true; ;
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
    }
}
