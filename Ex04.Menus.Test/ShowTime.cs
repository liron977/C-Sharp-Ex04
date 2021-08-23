using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal class ShowTime : IActionFunction
    {
        public void FunctionAction()
        {
            DateTime thisDay = DateTime.Now;
            Console.WriteLine(thisDay.ToLongTimeString());
        }
    }
}