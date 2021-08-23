using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        bool m_Back;
        protected readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();
        protected readonly string r_Quit;
        protected readonly int r_MenuLevel = 0;
        public SubMenu(string i_Quit, string i_SubMenuTitle, int i_MenuLevel) : base(i_SubMenuTitle)
        {
            r_Quit = i_Quit;
            r_MenuLevel = i_MenuLevel;
        }
        public void AddNewMenuItemToList(MenuItem i_NewMenuItem)
        {
            r_MenuItemsList.Add(i_NewMenuItem);

        }
        public void printMenuList()
        {
            int index = 0;
            System.Console.Clear();

            Console.WriteLine(string.Format(
                $@"The menu level is : {r_MenuLevel}.
{base.MenuTitle}
--------------------
{index} - {r_Quit}"));
            foreach (MenuItem element in r_MenuItemsList)
            {
                index++;

                Console.WriteLine($@"{index} - {element.MenuTitle}");

            }
        }

        public override void RunUserChoise()
        {
            String userInput;
            int userSelectedOption = -1;
            bool quitMenu = false;
            while (!quitMenu)
            {
                printMenuList();
                getValiduserInput(out userSelectedOption);
                quitMenu = userSelectedOption == 0;
                if (userSelectedOption != 0)
                {
                    r_MenuItemsList[userSelectedOption - 1].RunUserChoise();
                    Thread.Sleep(600);
                    System.Console.Clear();
                }
            }
        }
        private void getValiduserInput(out int o_userSelectedOption)
        {
            bool isValidInput = false;
            String userInput;
            bool isParsingSuccessed = true;
            o_userSelectedOption = -1;
            while (!isValidInput)
            {
                Console.WriteLine(string.Format(
                 $@" 
Please select an option"));

                userInput = Console.ReadLine();
                isParsingSuccessed = int.TryParse(userInput, out o_userSelectedOption);
                isValidInput = o_userSelectedOption >= 0 && o_userSelectedOption <= r_MenuItemsList.Count;
                if ((!isValidInput) || (!isParsingSuccessed))
                {
                    isValidInput = false;
                    Console.WriteLine("Invalid input,please choose an option from the menu");
                }

            }

        }




    }
}
