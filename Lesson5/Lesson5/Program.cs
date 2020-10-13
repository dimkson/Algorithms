using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenu = { Task01 };
            Menu menu = new Menu(delMenu);
            menu.ChooseMenu();
        }

        static void Task01()
        {

        }
    }
}
