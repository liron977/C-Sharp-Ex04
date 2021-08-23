using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal static class DelegatesMenuUI
    {
        public static void RunDelegatesMenu()
        {
            ShowVersion showVersionFunc = new ShowVersion();
            CountSpaces countSpacesFunc = new CountSpaces();
            ShowDate showDateFunc = new ShowDate();
            ShowTime showTimeFunc = new ShowTime();
            MainMenu mainMenu = new MainMenu("Exit", "Main Delegates", 1);
            SubMenu subMenuVersionAndSpaces = new SubMenu("Back", "Version and Spaces", 2);
            SubMenu subMenuDateAndTime = new SubMenu("Back", "Date And Time", 2);
            ActionMenuItem menuItemVersion = new ActionMenuItem("Version");
            ActionMenuItem menuItemSpaces = new ActionMenuItem("Spaces");
            ActionMenuItem menuItemDate = new ActionMenuItem("Date");
            ActionMenuItem menuItemTime = new ActionMenuItem("Time");

            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemVersion);
            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemSpaces);
            subMenuDateAndTime.AddNewMenuItemToList(menuItemDate);
            subMenuDateAndTime.AddNewMenuItemToList(menuItemTime);
            mainMenu.AddNewMenuItemToList(subMenuVersionAndSpaces);
            mainMenu.AddNewMenuItemToList(subMenuDateAndTime);
            menuItemSpaces.Listeners += countSpacesFunc.FunctionAction;
            menuItemVersion.Listeners += showVersionFunc.FunctionAction;
            menuItemDate.Listeners += showDateFunc.FunctionAction;
            menuItemTime.Listeners += showTimeFunc.FunctionAction;
            mainMenu.PresentMenu();
        }
    }
}