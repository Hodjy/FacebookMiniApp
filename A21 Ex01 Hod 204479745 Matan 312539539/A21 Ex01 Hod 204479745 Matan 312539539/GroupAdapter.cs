using FacebookWrapper.ObjectModel;
using System.Collections;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class GroupAdapter : IPostedCollectionsAdapter
    {
        private Group m_Group;

        public GroupAdapter(Group i_Group)
        {
            m_Group = i_Group;
        }

        public ArrayList GetPosts()
        {
            ArrayList listToReturn = new ArrayList(m_Group.WallPosts);

            return listToReturn;
        }
    }
}
