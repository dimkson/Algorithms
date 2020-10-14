using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class MyQueue
    {
        #region Поля

        int[] queue;
        int maxSize;
        int head, tail;
        bool reverse;

        #endregion

        #region Конструктор

        public MyQueue(int maxSize)
        {
            this.maxSize = maxSize;
            queue = new int[maxSize];
            head = tail = 0;
            reverse = false;
        }

        #endregion

        #region Методы

        public void Push(int item)
        {
            if (head == maxSize)
            {
                if(head+1==tail)
                head = 0;
            }


            if (!reverse)
            {
                if (head < maxSize)
                {
                    queue[head] = item;
                    head++;
                }
                else
                {
                    if (tail != 0)
                    {
                        head = 0;
                        queue[head] = item;
                        reverse = true;
                        Console.WriteLine("Head Reverse!"); 
                    }
                    else
                        Console.WriteLine("Очередь переполнена!");
                }
            }
            else
            {
                if (head < tail)
                {
                    queue[head] = item;
                    head++;
                }
                else
                {
                    Console.WriteLine("Очередь переполнена!");
                }
            }


        }
        public int Pop()
        {
            if (head == tail)
            {
                Console.WriteLine("Очередь пуста");
                return 0;
            }

            if (reverse)
            {
                if (tail == maxSize)
                {
                    tail = 0;
                    reverse = false;
                    Console.WriteLine("Tail Reverse");
                }
            }

            int item;
            item = queue[tail];
            queue[tail] = 0;
            tail++;
            return item;
        }

        #endregion
    }
}
