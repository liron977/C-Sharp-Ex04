using System;
using System.Collections.Generic;
using System.Threading;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        protected readonly List<MenuItem> r_MenuItemsList = new List<MenuItem>();
        protected readonly string r_Quit;
        protected readonly int r_MenuLevel;

        public SubMenu(string i_Quit, string i_SubMenuTitle, int i_MenuLevel)
            : base(i_SubMenuTitle)
        {
            r_Quit = i_Quit;
            r_MenuLevel = i_MenuLevel;
        }

        public void AddNewMenuItemToList(MenuItem i_NewMenuItem)
        {
            r_MenuItemsList.Add(i_NewMenuItem);
        }

        private void printMenuList()
        {
            int index = 0;

            Console.Clear();
            Console.WriteLine(
                string.Format(
                    $@"The menu level is : {r_MenuLevel}.
{MenuTitle}
--------------------
{index} - {r_Quit}"));
            foreach(MenuItem element in r_MenuItemsList)
            {
                index++;

                Console.WriteLine($@"{index} - {element.MenuTitle}");
            }
        }

        internal override void RunUserChoice()
        {
            int userSelectedOption;
            bool quitMenu = false;

            while(!quitMenu)
            {
                printMenuList();
                getValidUserInput(out userSelectedOption);
                quitMenu = userSelectedOption == 0;
                if(userSelectedOption != 0)
                {
                    r_MenuItemsList[userSelectedOption - 1].RunUserChoice();
                    Thread.Sleep(600);
                    Console.Clear();
                }
            }
        }

        private void getValidUserInput(out int o_UserSelectedOption)
        {
            bool isValidInput = false;
            string userInput;
            bool isParsingSucceeded;

            o_UserSelectedOption = -1;
            while(!isValidInput)
            {
                Console.WriteLine(
                    string.Format(
                        $@" 
Please select an option"));

                userInput = Console.ReadLine();
                isParsingSucceeded = int.TryParse(userInput, out o_UserSelectedOption);
                isValidInput = o_UserSelectedOption >= 0 && o_UserSelectedOption <= r_MenuItemsList.Count;
                if((!isValidInput) || (!isParsingSucceeded))
                {
                    isValidInput = false;
                    Console.WriteLine("Invalid input,please choose an option from the menu");
                }
            }
        }
    }
}