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
           

            MainMenu mainMenu = new MainMenu("Exit","Main Interface");
            SubMenu subMenuVersionAndSpaces = new SubMenu("Back", "Version and Spaces");
            SubMenu subMenuDateAndTime = new SubMenu("Back", "Date And Time");
            ActionMenuItem menuItemVersionAndSpaces = new ActionMenuItem("1- Version and Spaces");
            ActionMenuItem menuItemDateAndTime = new ActionMenuItem("2- Show Date/Time");
            ActionMenuItem menuItemVersion = new ActionMenuItem("1- Version");
            ActionMenuItem menuItemSpaces = new ActionMenuItem("2-Spaces");
            ActionMenuItem menuItemDate = new ActionMenuItem("1-Date");
            ActionMenuItem menuItemTime = new ActionMenuItem("2-Time");
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
