using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersion :IActionFunction
    {
        public void FunctionAction()
        {
            Console.WriteLine("Version: 21.3.4.8933");
        }
    }
}
