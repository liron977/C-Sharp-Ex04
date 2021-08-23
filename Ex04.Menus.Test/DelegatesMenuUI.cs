using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal static class DelegatesMenuUI
    {
        internal static void RunDelegatesMenu()
        {
            ShowVersion showVersionFunc = new ShowVersion();
            CountSpaces countSpacesFunc = new CountSpaces();
            ShowDate showDateFunc = new ShowDate();
            ShowTime showTimeFunc = new ShowTime();
            MainMenu mainMenu = new MainMenu("Exit", "Main Delegates", 1);
            SubMenu subMenuVersionAndSpaces = new SubMenu("Back", "Version and Spaces", 2);
            SubMenu subMenuDateAndTime = new SubMenu("Back", "Date/Time", 2);
            ActionMenuItem menuItemVersion = new ActionMenuItem("Show Version");
            ActionMenuItem menuItemSpaces = new ActionMenuItem("Count Spaces");
            ActionMenuItem menuItemDate = new ActionMenuItem("Show Date");
            ActionMenuItem menuItemTime = new ActionMenuItem("Show Time");

            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemVersion);
            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemSpaces);
            subMenuDateAndTime.AddNewMenuItemToList(menuItemDate);
            subMenuDateAndTime.AddNewMenuItemToList(menuItemTime);
            mainMenu.AddNewMenuItemToList(subMenuVersionAndSpaces);
            mainMenu.AddNewMenuItemToList(subMenuDateAndTime);
            menuItemSpaces.Clicked += countSpacesFunc.FunctionAction;
            menuItemVersion.Clicked += showVersionFunc.FunctionAction;
            menuItemDate.Clicked += showDateFunc.FunctionAction;
            menuItemTime.Clicked += showTimeFunc.FunctionAction;
            mainMenu.PresentMenu();
        }
    }
}