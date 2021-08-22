using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu :Menu
    {
        bool m_Exit = false;

        public MainMenu( string i_Exit,string i_MainMenuTitle) : base(i_Exit, i_MainMenuTitle)
        {
           
        }
        public override void Click(int i_UserInput)
        {

            if (r_menuListener[i_UserInput-1] is SubMenu) {
                (r_menuListener[i_UserInput-1] as Menu).printMenuList();
                    }
            


        }

        /*   public void MainMenu()
           {

           }
   */
    }
}
