using FacebookWrapper.ObjectModel;
using System.Collections;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class UserAdapter : IPostedCollectionsAdapter
    {
        private User m_User;

        public UserAdapter(User i_User)
        {
            m_User = i_User;
        }

        public ArrayList GetPosts()
        {
            ArrayList listToReturn = new ArrayList(m_User.WallPosts);

            return listToReturn;
        }
    }
}
