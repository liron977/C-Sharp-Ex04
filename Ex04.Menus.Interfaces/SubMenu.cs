using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex04.Menus.Interfaces
{
   public class SubMenu :Menu
    {
        bool m_Back;
       public  MainMenu m_SubMenuParant;

        public SubMenu(MainMenu i_MainMenu,string i_Back,string i_SubMenuTitle):base(i_Back, i_SubMenuTitle)
        {
            m_SubMenuParant = i_MainMenu;
        }
      public override void Click(int i_UserInput)
        {
            (r_menuListener[i_UserInput-1] as IActionFunction).FunctionAction();
            Thread.Sleep(1000);
            base.printMenuList();
        }


    }
}
