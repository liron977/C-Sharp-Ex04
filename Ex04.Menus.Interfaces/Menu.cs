using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
   public abstract class Menu
    {
        protected readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();
        protected readonly List<object> r_menuListener = new List<object>();
        protected readonly string r_QuitMenu;
        protected readonly string r_MenuTitle;

        public Menu(string i_QuitMenu,string i_MenuTitle)
        {
            r_QuitMenu = i_QuitMenu;
            r_MenuTitle = i_MenuTitle;
        }
        public void AddNewMenuItemToList(MenuItem i_NewMenuItem,object i_Listener)
        {
            r_MenuItemsList.Add(i_NewMenuItem);
            r_menuListener.Add(i_Listener);
        }
        public void printMenuList()
        {
            System.Console.Clear();
            Console.WriteLine(r_MenuTitle);
            Console.WriteLine("0-{0}", r_QuitMenu);
            foreach(MenuItem element in r_MenuItemsList)
            {
                Console.WriteLine(element.MenuTitle);
               
            }
            getUserChoise();
        }
        public abstract void Click(int i_UserInput);

        public void getUserChoise()
        {
            String userInput;
            int userSelectedOption;
            userInput = Console.ReadLine();
           int.TryParse(userInput,out userSelectedOption);
            if (userSelectedOption!=0)
            {
                this.Click(userSelectedOption);

            }
            else
            {
                if(this is SubMenu)
                {
                    (this as SubMenu).m_SubMenuParant.printMenuList();
                }

            }
        }
    }
}
