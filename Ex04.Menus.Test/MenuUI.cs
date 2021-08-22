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
            SubMenu subMenuVersionAndSpaces = new SubMenu(mainMenu,"Back", "Version and Spaces");
            SubMenu subMenuDateAndTime = new SubMenu(mainMenu, "Back", "Date And Time");
            MenuItem menuItemVersionAndSpaces = new MenuItem("1- Version and Spaces");
            MenuItem menuItemDateAndTime = new MenuItem("2- Show Date/Time");
            MenuItem menuItemVersion = new MenuItem("1- Version");
            MenuItem menuItemSpaces = new MenuItem("2-Spaces");
            MenuItem menuItemDate = new MenuItem("1-Date");
            MenuItem menuItemTime = new MenuItem("2-Time");
            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemVersion, new ShowVersion());
            subMenuVersionAndSpaces.AddNewMenuItemToList(menuItemSpaces, new CountSpaces());
            subMenuDateAndTime.AddNewMenuItemToList(menuItemDate, new ShowDate());
            subMenuDateAndTime.AddNewMenuItemToList(menuItemTime, new ShowTime());

            mainMenu.AddNewMenuItemToList(menuItemVersionAndSpaces, subMenuVersionAndSpaces);
            mainMenu.AddNewMenuItemToList(menuItemDateAndTime, subMenuDateAndTime);
            mainMenu.printMenuList();

            //mainMenu.getUserChoise();
        }
    }
}
