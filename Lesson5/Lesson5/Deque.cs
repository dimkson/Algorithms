using System;

namespace Lesson5
{
    class Deque
    {
        #region Поля

        int[] deque;
        int maxSize;
        int head, tail, count;

        #endregion

        #region Конструктор

        public Deque(int maxSize)
        {
            this.maxSize = maxSize;
            deque = new int[maxSize];
            head = tail = count = 0;
        }
        #endregion

        #region Методы

        public void PushBack(int item)
        {
            if (count == 0)
            {
                head = tail = 0;
                deque[tail] = item;
                count++;
            }
            else
            {
                if (count != maxSize)
                {
                    int next = tail - 1;
                    if (next == -1) next = maxSize - 1;
                    tail = next;
                    deque[tail] = item;
                    count++;
                }
                else
                {
                    Console.WriteLine("Дек заполнен");
                }
            }
        }
        public int PopBack()
        {
            if (count != 0)
            {
                int item = deque[tail];
                deque[tail] = 0;
                int prev = tail + 1;
                if (prev == maxSize) prev = 0;
                tail = prev;
                count--;
                return item;
            }
            else
            {
                Console.WriteLine("Дек пуст");
                return 0;
            }
        }
        public void PushFront(int item)
        {
            if (count == 0)
            {
                head = tail = 0;
                deque[head] = item;
                count++;
            }
            else
            {
                if (count != maxSize)
                {
                    int next = head + 1;
                    if (next == maxSize) next = 0;
                    head = next;
                    deque[head] = item;
                    count++;
                }
                else
                {
                    Console.WriteLine("Дек заполнен");
                } 
            }
        }
        public int PopFront()
        {
            if (count != 0)
            {
                int item = deque[head];
                deque[head] = 0;
                int prev = head - 1;
                if (prev == -1) prev = maxSize - 1;
                head = prev;
                count--;
                return item;
            }
            else
            {
                Console.WriteLine("Дек пуст");
                return 0;
            }
        }

        #endregion
    }
}
