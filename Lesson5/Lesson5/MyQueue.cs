using System;

namespace Lesson5
{
    class MyQueue<T>
    {
        //Класс реализует очередь на основе массива
        #region Поля

        private T[] queue;
        private int maxSize;
        private int head, tail;
        private bool reverse;

        #endregion

        #region Конструктор

        public MyQueue(int maxSize)
        {
            this.maxSize = maxSize;
            queue = new T[maxSize];
            head = tail = 0;
            reverse = false;
        }

        #endregion

        #region Методы

        public void Enqueue(T item)
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
        public T Dequeue()
        {
            if (!reverse)
            {
                if (head == tail)
                {
                    Console.WriteLine("Очередь пуста");
                    return default;
                }
            }

            T item;
            item = queue[tail];
            queue[tail] = default;
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
