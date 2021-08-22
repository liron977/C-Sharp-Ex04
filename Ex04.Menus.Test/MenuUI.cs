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
            SubMenu subMenuVersionAndSpaces=new SubMenu();
            SubMenu subMenuDateAndTime = new SubMenu();

            MainMenu mainMenu = new MainMenu();
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

            mainMenu.getUserChoise();
        }
    }
}
