using System.Windows.Forms;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class GroupBoxVisualCommand : ICommand
    {
        private GroupBox m_GroupBoxToHandle;

        public GroupBoxVisualCommand(GroupBox i_GroupBoxToHandle)
        {
            m_GroupBoxToHandle = i_GroupBoxToHandle;
        }

        public void ExecuteCommand()
        {
            m_GroupBoxToHandle.Visible = true;
            m_GroupBoxToHandle.Enabled = true;
        }

        public void UndoCommand()
        {
            m_GroupBoxToHandle.Visible = false;
            m_GroupBoxToHandle.Enabled = false;
        }
    }
}
