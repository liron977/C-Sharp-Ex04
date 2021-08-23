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
        internal override void RunUserChoice()
        {
            Clicked();

        }
    }
}
