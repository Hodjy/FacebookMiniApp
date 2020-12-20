using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class FacebookBasicMethods
    {
        public static SelectedPost m_SelectedPost = new SelectedPost();

        public static string LoggedInUserName
        {
            get
            {
                return ConnectionManager.LoggedInUser.Name;
            }
        }

        public static string LoggedInUserProfilePicture
        {
            get
            {
                return ConnectionManager.LoggedInUser.PictureNormalURL;
            }
        }

        public static string LogInUser()
        {
            string loginError = string.Empty;

            loginError = ConnectionManager.LogInUser("3925570110805927");

            return loginError;
        }

        public static void LogOutUser()
        {
            ConnectionManager.LogOutUser();
        }

        private static FacebookObjectCollection<Post> getUserWallPostsOrWallPhotos(bool i_isStoringPicturelessPost)
        {
            FacebookObjectCollection<Post> userWallPostsCollection = ConnectionManager.LoggedInUser.WallPosts;
            FacebookObjectCollection<Post> postsToReturn = new FacebookObjectCollection<Post>();

            foreach (Post item in userWallPostsCollection)
            {
                if((item.PictureURL == null) == i_isStoringPicturelessPost)
                {
                    postsToReturn.Add(item);
                }
            }

            return postsToReturn;
        }

        public static FacebookObjectCollection<Post> GetUserWallPosts()
        {
            return getUserWallPostsOrWallPhotos(true);
        }

        public static FacebookObjectCollection<Post> GetUserWallPhotos()
        {
            return getUserWallPostsOrWallPhotos(false);
        }

        public static FacebookObjectCollection<User> UserFriends
        {
            get
            {
                return ConnectionManager.LoggedInUser.Friends;
            }
        }

        public static FacebookObjectCollection<Event> UserEvents
        {
            get
            {
                return ConnectionManager.LoggedInUser.Events;
            }
        }

        public static FacebookObjectCollection<Album> UserAlbums
        {
            get
            {
                return ConnectionManager.LoggedInUser.Albums;
            }
        }

        public static FacebookObjectCollection<Group> UserGroups
        {
            get
            {
                return ConnectionManager.LoggedInUser.Groups;
            }
        }


    }
}
