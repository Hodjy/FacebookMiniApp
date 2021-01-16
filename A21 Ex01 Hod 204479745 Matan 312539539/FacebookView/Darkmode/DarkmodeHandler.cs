using System;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class DarkmodeHandler : IDarkmodeHandler
    {
        private IDarkmodeHandler m_NextInChain;
        public event Action EventDarkmodeToggled;

        public DarkmodeHandler()
        {
        }

        public IDarkmodeHandler NextInChain
        {
            set
            {
                m_NextInChain = value;
            }
        }

        public void ToggleDarkmode()
        {
            EventDarkmodeToggled.Invoke();

            if (m_NextInChain != null)
            {
                m_NextInChain.ToggleDarkmode();
            }
        }
    }
}
