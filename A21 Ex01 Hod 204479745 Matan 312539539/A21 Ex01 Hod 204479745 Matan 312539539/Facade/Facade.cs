using System;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class Facade // Maybe change to non-static class
    {
        private static LoggedInUser m_LoggedInUser = new LoggedInUser();
        private static readonly string sr_AppID = "3925570110805927";
        private static bool sm_IsUserLoggedIn = false;

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
            m_LoggedInUser.User = new UserToLoggedInUserAdapter(ConnectionManager.LoggedInUser);

            if(loginError == string.Empty)
            {
                sm_IsUserLoggedIn = true;
            }

            return loginError;
        }

        public static void LogOutUser()
        {
            ConnectionManager.LogOutUser();
            sm_IsUserLoggedIn = false;
        }

        public static bool IsUserLoggedIn
        {
            get
            {
                return sm_IsUserLoggedIn;
            }
        }

        public static ISelectedItem ConvertItemToSelectedItem(PostedItem m_PostedItem)
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

        public static bool isSelectedItemLikedByUser(ISelectedItem i_PostToCheck)
        {
            bool isLiked = false;

            isLiked = i_PostToCheck.isLikedByUser(ConnectionManager.LoggedInUser);

            return isLiked;
        }

        public static FacebookObjectCollection<Post> FilterPostsByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_DateToFilterBy)
        {
            FacebookObjectCollection<Post> filteredPosts;

            filteredPosts = FacebookFilters.FilterPostsByDate(i_PostsToFilter, i_DateToFilterBy);

            return filteredPosts;
        }

        public static FacebookObjectCollection<Post> FilterPostsByLikesCount(FacebookObjectCollection<Post> i_PostsToFilter, int i_MinLikesCount)
        {
            FacebookObjectCollection<Post> filteredPosts;

            filteredPosts = FacebookFilters.FilterPostsByLikesCount(i_PostsToFilter, i_MinLikesCount);

            return filteredPosts;
        }
    }
}