using System.Windows.Forms;
using System.Drawing;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class GroupBoxDarkmodeEnabler : IDarkmodeToggable
    {
        private GroupBox m_ToggableGroupBox;
        private bool m_IsDarkmodeEnabled;
        private Color m_DarkmodeColor;
        private Color m_LightmodeColor;
        private DarkModeToggler m_DarkmodeToggler;

        public GroupBoxDarkmodeEnabler(GroupBox i_GroupBox)
        {
            m_ToggableGroupBox = i_GroupBox;
            m_IsDarkmodeEnabled = false;
            m_LightmodeColor = Color.SteelBlue;
            m_DarkmodeColor = Color.Black;
            m_DarkmodeToggler = new DarkModeToggler();
        }

        public bool IsDarkmodeEnabled
        {
            get
            {
                return m_IsDarkmodeEnabled;
            }

            set
            {
                m_IsDarkmodeEnabled = value;
            }
        }

        public Color DarkmodeColor
        {
            get
            {
                return m_DarkmodeColor;
            }
        }

        public Color LightmodeColor
        {
            get
            {
                return m_LightmodeColor;
            }
        }

        public Color ItemColor
        {
            set
            {
                m_ToggableGroupBox.BackColor = value;
            }
        }

        public void ToggleDarkmode()
        {
            m_DarkmodeToggler.ToggleDarkmode(this);
        }
    }
}
