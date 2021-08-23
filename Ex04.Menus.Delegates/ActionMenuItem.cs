using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void Listeners();
    public class ActionMenuItem : MenuItem
    {
        public event Listeners Listeners;
        public ActionMenuItem(string i_ActionTitle) : base(i_ActionTitle)
        {

        }
       

        public void Clicked()
        {
            if(Listeners != null)
            {
                Listeners.Invoke();
            }
            
        }
        public override void RunUserChoise()
        {
            Clicked();

        }
    }
}
