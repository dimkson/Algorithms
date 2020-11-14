using System;
using FC = MenuLib.FastConsole;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Graphs graphs = new Graphs("graph.txt");
            graphs.PrintMatrix();
            FC.Input("Введите номер стартовой вершины", out int num);
            graphs.Dijkstra(num);
            FC.Input("Введите номер конечной вершины", out num);
            graphs.FindShortPath(num);
            Console.ReadLine();
        }
    }
}
