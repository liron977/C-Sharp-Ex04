using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
        internal class ShowDate : IActionFunction
        {
            public void FunctionAction()
            {
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString());
            }
        }
}
