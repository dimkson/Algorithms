using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLib;
using FC = MenuLib.FastConsole;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.delMenu[] delMenus = { Routes.Route };
            Menu menu = new Menu(delMenus);
            menu.ChooseMenu();
        }
    }
}
