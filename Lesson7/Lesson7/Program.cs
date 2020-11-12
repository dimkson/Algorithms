using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Console.ReadLine();
        }
    }
}
