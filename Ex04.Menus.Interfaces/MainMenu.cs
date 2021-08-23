using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu :SubMenu
    {

        public MainMenu( string i_Exit,string i_MainMenuTitle) : base(i_Exit,i_MainMenuTitle)
        {
           
        }
        public void PresentMenu()
        {
            RunUserChoise();
        }
    }
}
