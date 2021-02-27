namespace A21_Ex03
{
    public class DarkModeToggler
    {
        public DarkModeToggler()
        {
        }

        public void ToggleDarkmode(IDarkmodeToggable i_ItemToToggle)
        {
            if(i_ItemToToggle.IsDarkmodeEnabled)
            {
                i_ItemToToggle.ItemColor = i_ItemToToggle.LightmodeColor;
            }
            else
            {
                i_ItemToToggle.ItemColor = i_ItemToToggle.DarkmodeColor;
            }

            i_ItemToToggle.IsDarkmodeEnabled = !i_ItemToToggle.IsDarkmodeEnabled;
        }
    }
}
