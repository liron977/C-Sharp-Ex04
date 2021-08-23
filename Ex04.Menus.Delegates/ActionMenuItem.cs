namespace Ex04.Menus.Delegates
{
    public delegate void ClickedEventHandler();

    public class ActionMenuItem : MenuItem
    {
        public event ClickedEventHandler Clicked;

        public ActionMenuItem(string i_ActionTitle)
            : base(i_ActionTitle)
        {
        }

        private void OnClicked()
        {
            if(Clicked != null)
            {
                System.Console.Clear();
                Clicked.Invoke();
            }
        }

        internal override void RunUserChoice()
        {
            OnClicked();
        }
    }
}