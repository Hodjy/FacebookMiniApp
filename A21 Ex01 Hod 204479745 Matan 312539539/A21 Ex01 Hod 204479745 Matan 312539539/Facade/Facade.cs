using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class Facade // Maybe change to non-static class
    {
        public static SelectedPostSecond m_SelectedPost;
        private static LoggedInUser m_LoggedInUser = new LoggedInUser();
        private static readonly string sr_AppID = "3925570110805927";

        public static LoggedInUser LoggedInUser
        {
            get
            {
                return m_LoggedInUser;
            }
        }

        public static string LogInUser()
        {
            string loginError = string.Empty;

            loginError = ConnectionManager.LogInUser(sr_AppID);
            m_LoggedInUser.EmbeddedLoggedInUser = new UserToLoggedInUserAdapter(ConnectionManager.LoggedInUser);

            return loginError;
        }

        public static void LogOutUser()
        {
            ConnectionManager.LogOutUser();
        }

        public static ISelectedItem GetSelectedItemType(PostedItem m_PostedItem)
        {
            ISelectedItem selectedItemToReturn = null;

            if (m_PostedItem is Post)
            {
                selectedItemToReturn = new SelectedPost(m_PostedItem as Post);
            }
            else if (m_PostedItem is Photo)
            {
                selectedItemToReturn = new SelectedPhoto(m_PostedItem as Photo);
            }

            return selectedItemToReturn;
        }

        public static bool isPostLikedByUser(ISelectedItem i_PostToCheck)
        {
            bool isLiked = false;

            isLiked = i_PostToCheck.isLikedByUser(ConnectionManager.LoggedInUser);

            return isLiked;
        }

        // will be replaceed with proxy
        public static string LoggedInUserProfilePicture
        {
            get
            {
                return ConnectionManager.LoggedInUser.PictureNormalURL;
            }
        }

        // will be replaceed with proxy
        public static string LoggedInUserName
        {
            get
            {
                return ConnectionManager.LoggedInUser.Name;
            }
        }

        // will be replaced with proxy
        public static FacebookObjectCollection<Post> LoggedInUserWallPosts
        {
            get
            {
                return ConnectionManager.LoggedInUser.WallPosts;
            }
        }

        // will be replaced with proxy
        public static FacebookObjectCollection<User> LoggedInUserFriends
        {
            get
            {
                return ConnectionManager.LoggedInUser.Friends;
            }
        }
        
        // will be replaced with proxy
        public static FacebookObjectCollection<Event> UserEvents
        {
            get
            {
                return ConnectionManager.LoggedInUser.Events;
            }
        }

        // will be replaced with proxy
        public static FacebookObjectCollection<Album> LoggedInUserAlbums
        {
            get
            {
                return ConnectionManager.LoggedInUser.Albums;
            }
        }

        // will be replaced with proxy
        public static FacebookObjectCollection<Group> LoggedInUserGroups
        {
            get
            {
                return ConnectionManager.LoggedInUser.Groups;
            }
        }
    }
}