using FacebookWrapper.ObjectModel;
using System.Collections;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class AlbumAdapter : IPostedCollectionsAdapter
    {
        private Album m_Album;

        public AlbumAdapter(Album i_Album)
        {
            m_Album = i_Album;
        }

        public ArrayList GetPosts()
        {
            ArrayList listToReturn = new ArrayList(m_Album.Photos);

            return listToReturn;
        }
    }
}
