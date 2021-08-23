namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_Title;

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }

        internal abstract void RunUserChoice();

        public string MenuTitle
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }
    }
}