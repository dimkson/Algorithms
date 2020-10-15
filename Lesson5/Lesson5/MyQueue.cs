using System;

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

        public void Enqueue(int item)
        {
            if (reverse)
            {
                if (head == tail)
                {
                    Console.WriteLine("Очередь переполнена!");
                    return;
                }
            }

            queue[head] = item;
            head++;

            if (head == maxSize)
            {
                head = 0;
                reverse = true;
            }
        }
        public int Dequeue()
        {
            if (!reverse)
            {
                if (head == tail)
                {
                    Console.WriteLine("Очередь пуста");
                    return 0;
                }
            }

            int item;
            item = queue[tail];
            queue[tail] = 0;
            tail++;

            if (tail == maxSize)
            {
                tail = 0;
                reverse = false;
            }
            return item;
        }

        #endregion
    }
}
