using System.Drawing;

namespace A21_Ex03
{
    public interface IDarkmodeToggable
    {
       bool IsDarkmodeEnabled
        {
            get;
            set;
        }

        Color DarkmodeColor
        {
            get;
        }

        Color LightmodeColor
        {
            get;
        }

        Color ItemColor
        {
            set;
        }

        void ToggleDarkmode();
    }
}
