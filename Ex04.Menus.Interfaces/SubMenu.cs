using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.Threading;
namespace Ex04.Menus.Interfaces
{
   public class SubMenu :MenuItem
    {
        bool m_Back;
        protected readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();
        protected readonly string r_Quit;
        public SubMenu(string i_Quit, string i_SubMenuTitle) : base(i_SubMenuTitle)
        {
            r_Quit = i_Quit;
        }
        public void AddNewMenuItemToList(MenuItem i_NewMenuItem)
        {
            r_MenuItemsList.Add(i_NewMenuItem);
           
        }
        public void printMenuList()
            {
                System.Console.Clear();
                Console.WriteLine(base.MenuTitle);
                Console.WriteLine("0-{0}", r_Quit);
                foreach (MenuItem element in r_MenuItemsList)
                {
                    Console.WriteLine(element.MenuTitle);

                }
            }

        public override void RunUserChoise()
        {
            
            String userInput;
            int userSelectedOption;
            bool quitMenu=false;
            while (!quitMenu)
            {
                printMenuList();
                userInput = Console.ReadLine();
                int.TryParse(userInput, out userSelectedOption);
                quitMenu = userSelectedOption == 0;
      
                r_MenuItemsList[userSelectedOption-1].RunUserChoise();
                Thread.Sleep(1000);
                System.Console.Clear();



            }
            /*if (userSelectedOption != 0)
            {
                this.Click(userSelectedOption);

            }
            else
            {
                if (this is SubMenu)
                {
                    (this as SubMenu).m_SubMenuParant.printMenuList();
                }

            }*/
        }
       


    }
}
