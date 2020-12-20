using System;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class PostedInformationAdapterFactory
    {
        public static IPostedCollectionsAdapter getAdapter(eAdapterType i_Type)
        {
            IPostedCollectionsAdapter PostedItem = null;
            switch (i_Type)
            {
                case eAdapterType.User:
                    PostedItem = new UserAdapter();
                    break;
                case eAdapterType.Event:
                    PostedItem = new EventAdapter();
                    break;
                case eAdapterType.Group:
                    PostedItem = new GroupAdapter();
                    break;
                case eAdapterType.Album:
                    PostedItem = new AlbumAdapter();
                    break;
                default:
                    throw new Exception("Not supported");
            }

            return PostedItem;
        }

        public enum eAdapterType
        {
            User,
            Event,
            Group,
            Album,
        }
    }
}
