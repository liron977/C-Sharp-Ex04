using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
   public class MenuUI
    {
        public void RunMenu()
        {
           

            MainMenu mainMenu = new MainMenu("Exit","Main Interface",1);
            SubMenu subMenuVersionAndSpaces = new SubMenu("Back", "Version and Spaces",2);
            SubMenu subMenuDateAndTime = new SubMenu("Back", "Date And Time",2);
            ActionMenuItem menuItemVersionAndSpaces = new ActionMenuItem("Version and Spaces");
            ActionMenuItem menuItemDateAndTime = new ActionMenuItem("Show Date/Time");
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
            menuItemSpaces.AddNewMenuItemToList(new CountSpaces());
            menuItemVersion.AddNewMenuItemToList(new ShowVersion());
            menuItemDate.AddNewMenuItemToList(new ShowDate());
            menuItemTime.AddNewMenuItemToList(new ShowTime());

            mainMenu.PresentMenu();

            //mainMenu.getUserChoise();
        }
    }
}
