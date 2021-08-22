using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu :Menu
    {
      public override void Click(int i_UserInput)
        {

            if (r_menuOptionList[i_UserInput-1] is SubMenu) {
                (r_menuOptionList[i_UserInput-1] as Menu).printMenuList();
                    }
            
        }

        /*   public void MainMenu()
           {

           }
   */
    }
}
