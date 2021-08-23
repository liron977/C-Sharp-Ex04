using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : IActionFunction
    {
        public void FunctionAction()
        {
            Console.WriteLine("Version: 21.3.4.8933");
        }
    }
}