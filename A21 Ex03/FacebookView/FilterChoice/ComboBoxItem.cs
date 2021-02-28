namespace A21_Ex03
{
    public class ComboBoxItem
    {
        private ICommand m_Command;
        private string m_ItemDescription;

        public ComboBoxItem(ICommand i_Request, string i_ItemDescription)
        {
            m_Command = i_Request;
            m_ItemDescription = i_ItemDescription;
        }

        public string Name
        {
            get
            {
                return m_ItemDescription;
            }
        }

        public ICommand Command
        {
            get
            {
                return m_Command;
            }
        }
    }
}
