using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class ActionMenuItem : MenuItem
    {
        protected readonly List<IActionFunction> r_MenuListener = new List<IActionFunction>();

        public ActionMenuItem(string i_ActionTitle)
            : base(i_ActionTitle)
        {
        }

        public void AddNewMenuItemToList(IActionFunction i_Listener)
        {
            r_MenuListener.Add(i_Listener);
        }

        public void Clicked()
        {
            foreach(IActionFunction element in r_MenuListener)
            {
                element.FunctionAction();
            }
        }

        internal override void RunUserChoice()
        {
            Clicked();
        }
    }
}