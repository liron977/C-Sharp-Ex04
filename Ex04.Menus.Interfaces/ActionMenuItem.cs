using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        protected readonly List<IActionFunction> r_menuListener = new List<IActionFunction>();
        public ActionMenuItem(string i_ActionTitle):base(i_ActionTitle)
        {

           }
        public void AddNewMenuItemToList(IActionFunction i_Listener)
        {
          
            r_menuListener.Add(i_Listener);
        }

        public void Clicked()
        {
            foreach(IActionFunction element in r_menuListener)
            {
                element.FunctionAction();
            }
        }
       public override void RunUserChoise()
        {
            Clicked();

        }
    }
}
