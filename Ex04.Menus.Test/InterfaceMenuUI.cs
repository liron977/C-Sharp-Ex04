using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    internal static class InterfaceMenuUI
    {
        internal static void RunInterfaceMenu()
        {
            MainMenu mainMenu = new MainMenu("Exit", "Main Interface", 1);
            SubMenu subMenuVersionAndSpaces = new SubMenu("Back", "Version and Spaces", 2);
            SubMenu subMenuDateAndTime = new SubMenu("Back", "Show Date/Time", 2);
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
            menuItemSpaces.AddNewListenerToList(new CountSpaces());
            menuItemVersion.AddNewListenerToList(new ShowVersion());
            menuItemDate.AddNewListenerToList(new ShowDate());
            menuItemTime.AddNewListenerToList(new ShowTime());
            mainMenu.PresentMenu();
        }
    }
}