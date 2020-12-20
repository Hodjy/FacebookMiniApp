using System.Collections;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class EventAdapter : IPostedCollectionsAdapter
    {
        private Event m_Event;

        public EventAdapter(Event i_Event)
        {
            m_Event = i_Event;
        }

        public ArrayList GetPosts()
        {
            ArrayList listTorReturn = new ArrayList(m_Event.WallPosts);

            return listTorReturn;
        }
    }
}
