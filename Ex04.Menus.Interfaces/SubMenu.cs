using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
   public class SubMenu :Menu
    {
      public override void Click(int i_UserInput)
        {
            (r_menuOptionList[i_UserInput] as IActionFunction).FunctionAction();


        }


    }
}
