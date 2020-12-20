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
        public static SelectedPost m_SelectedPost;

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

        public static FacebookObjectCollection<Post> UserWallPosts
        {
            get
            {
                return ConnectionManager.LoggedInUser.WallPosts;
            }
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
