using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson7
{
    internal class Graphs
    {
        #region Fields

        private int[,] arrMatrix;
        private int[] arr;
        private int[] arrDistance;
        private int size;
        private Stack<int> stack;
        private Queue<int> queue;

        #endregion

        #region Constructor
        public Graphs(string path)
        {
            ReadMatrix(path);
        }
        #endregion

        #region Methods

        private void ReadMatrix(string path)
        {
            //Считать матрицу смежности из файла
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                size = int.Parse(sr.ReadLine());
                arrMatrix = new int[size, size];

                string[] arrTemp;
                for (int i = 0; i < size; i++)
                {
                    arrTemp = sr.ReadLine().Split(' ');
                    for (int j = 0; j < size; j++)
                    {
                        arrMatrix[i, j] = int.Parse(arrTemp[j]);
                    }
                }
                sr.Close();
                fs.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        public void PrintMatrix()
        {
            //Распечатать матрицу
            Console.WriteLine($"Раземер матрицы: {size}x{size}");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{arrMatrix[i, j],2} ");
                }
                Console.WriteLine();
            }
        }

        public void Depth()
        {
            //Написать рекурсивную функцию обхода графа в глубину.
            stack = new Stack<int>();
            arr = new int[size];
            RecurDepth(0);
            Console.WriteLine("Обход графа в глубину завершен");
        }

        private void RecurDepth(int i)
        {
            arr[i] = 1;
            for (int j = 0; j < arrMatrix.GetLength(1); j++)
            {
                if (arrMatrix[i, j] == 1)
                {
                    if (arr[j] == 0)
                    {
                        stack.Push(j);
                        arr[j] = 1;
                    }
                }
            }
            arr[i] = 2;
            if (stack.Count != 0)
                RecurDepth(stack.Pop());
        }

        public void Widht()
        {
            //Написать функцию обхода графа в ширину.
            queue = new Queue<int>();
            arr = new int[size];
            RecurWidth(0);
            Console.WriteLine("Обход графа в ширину завершен");
        }

        private void RecurWidth(int i)
        {
            arr[i] = 1;
            for (int j = 0; j < arrMatrix.GetLength(1); j++)
            {
                if (arrMatrix[i, j] == 1)
                {
                    if (arr[j] == 0)
                    {
                        queue.Enqueue(j);
                        arr[j] = 1;
                    }
                }
            }
            arr[i] = 2;
            if (queue.Count != 0)
                RecurWidth(queue.Dequeue());
        }

        public void Dijkstra(int num)
        {
            //Алгоритм Дейкстры
            queue = new Queue<int>();
            arr = new int[size];
            arrDistance = new int[size];
            for (int i = 0; i < size; i++)
            {
                arrDistance[i] = int.MaxValue;
            }
            arrDistance[num] = 0;
            RecurDijkstra(num);
        }

        private void RecurDijkstra(int i)
        {
            int dist = 0;
            for (int j = 0; j < size; j++)
            {
                if (arrMatrix[i, j] != 0)
                {
                    if (arr[j] != 1)
                    {
                        dist = arrDistance[i] + arrMatrix[i, j];
                        if (dist < arrDistance[j])
                        {
                            queue.Enqueue(j);
                            arrDistance[j] = arrDistance[i] + arrMatrix[i, j];
                        }
                    }
                }
            }
            arr[i] = 1;
            if (queue.Count != 0)
                RecurDijkstra(queue.Dequeue());
        }

        public void FindShortPath(int i)
        {
            //Поиск кратчайшего пути
            for (int j = 0; j < size; j++)
            {
                if (arrMatrix[i, j] != 0)
                {
                    if (arrDistance[i] - arrMatrix[i, j] == arrDistance[j])
                    {
                        queue.Enqueue(j);
                        FindShortPath(j);
                    }
                }
            }
        }
        #endregion
    }
}
