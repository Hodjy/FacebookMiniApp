using System.Windows.Forms;
using System.Drawing;

namespace A21_Ex03
{
    public class LabelDarkmodeEnabler : IDarkmodeToggable
    {
        private Label m_ToggableLabel;
        private bool m_IsDarkmodeEnabled;
        private Color m_DarkmodeColor;
        private Color m_LightmodeColor;
        private DarkModeToggler m_DarkmodeToggler;

        public LabelDarkmodeEnabler(Label i_Label)
        {
            m_ToggableLabel = i_Label;
            m_IsDarkmodeEnabled = false;
            m_LightmodeColor = SystemColors.ControlText;
            m_DarkmodeColor = Color.White;
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
                m_ToggableLabel.ForeColor = value;
            }
        }

        public void ToggleDarkmode()
        {
            m_DarkmodeToggler.ToggleDarkmode(this);
        }
    }
}
