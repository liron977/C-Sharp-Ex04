using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu :SubMenu
    {

        public MainMenu( string i_Exit,string i_MainMenuTitle,int i_MenuLevel) : base(i_Exit,i_MainMenuTitle, i_MenuLevel)
        {
           
        }
        public void PresentMenu()
        {
            RunUserChoise();
        }
    }
}
