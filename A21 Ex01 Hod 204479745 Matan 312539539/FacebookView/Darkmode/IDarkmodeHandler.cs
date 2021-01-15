namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public interface IDarkmodeHandler
    {
        IDarkmodeHandler NextInChain
        {
            set;
        }

        void ToggleDarkmode();
    }
}
