﻿namespace Ex04.Menus.Delegates
{
    public class MainMenu : SubMenu
    {
        public MainMenu(string i_Exit, string i_MainMenuTitle, int i_MenuLevel) : base(i_Exit, i_MainMenuTitle, i_MenuLevel)
        {

        }

        public void PresentMenu()
        {
            RunUserChoice();
        }
    }
}
