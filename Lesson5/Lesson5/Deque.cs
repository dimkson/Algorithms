using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Deque
    {
        #region Поля

        int[] deque;
        int maxSize;
        int head, tail;
        bool reverse;

        #endregion

        #region Конструктор

        public Deque(int maxSize)
        {
            this.maxSize = maxSize;
            deque = new int[maxSize];
            head = tail = 0;
            reverse = true;
        }
        #endregion

        #region Методы

        public void PushBack(int item)
        {

        }
        public int PopBack()
        {
            return 0;
        }
        public void PushFront(int item)
        {
            int next = head + 1;
            if (next == maxSize) next = 0;
            if (next != tail)
            {
                head = next;
                deque[head] = item;
            }
            else
            {
                Console.WriteLine("Дек заполнен");
            }
        }
        public int PopFront()
        {
            int prev = head - 1;
            if (prev == -1) prev = maxSize - 1;
            if (prev != tail)
            {
                int item = deque[prev];
                head = prev;
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
