using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
   public abstract class Menu
    {
        protected readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();
        protected readonly List<object> r_menuOptionList = new List<object>();

        public void AddNewMenuItemToList(MenuItem i_NewMenuItem,object i_Listener)
        {
            r_MenuItemsList.Add(i_NewMenuItem);
            r_menuOptionList.Add(i_Listener);
        }
        public void printMenuList()
        {
            foreach(MenuItem element in r_MenuItemsList)
            {
                Console.WriteLine(element.MenuTitle);
               
            }
        }
        public abstract void Click(int i_UserInput);

        public void getUserChoise()
        {
            String userInput;
            int userSelectedOption;
            userInput = Console.ReadLine();
           int.TryParse(userInput,out userSelectedOption);
            this.Click(userSelectedOption);
        }
    }
}
