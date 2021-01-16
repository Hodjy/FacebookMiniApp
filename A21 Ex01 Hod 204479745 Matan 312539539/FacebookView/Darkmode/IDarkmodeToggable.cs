using System.Drawing;

namespace A21_Ex01_Hod_204479745_Matan_312539539
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
