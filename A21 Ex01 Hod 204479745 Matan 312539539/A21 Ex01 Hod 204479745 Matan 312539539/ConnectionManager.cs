using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public static class ConnectionManager
    {
        private static LoginResult sm_LoginResult;
        private static User sm_LoggedInUser;

        public static LoginResult LoginResult
        {
            get { return sm_LoginResult; }
        }

        public static User LoggedInUser
        {
            get { return sm_LoggedInUser; }
        }

        public static string LogInUser(string i_AppID)
        {
            string errorMessage = string.Empty;

            commitLogin(i_AppID);
            errorMessage = setLoggedInUser();

            return errorMessage;
        }

        private static void commitLogin(string i_AppID)
        {
            if (sm_LoginResult == null)
            {
                sm_LoginResult = FacebookService.Login(i_AppID,
                    "public_profile",
                    "email",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown",
                    "user_managed_groups",
                    "user_status"
                    );
                
            }
        }

        private static string setLoggedInUser()
        {
            string loginError = string.Empty;

            if (!string.IsNullOrEmpty(sm_LoginResult.AccessToken))
            {
                sm_LoggedInUser = sm_LoginResult.LoggedInUser;
            }
            else
            {
                loginError = sm_LoginResult.ErrorMessage;
            }

            return loginError;
        }

        public static void LogOutUser()
        {
            sm_LoginResult = null;
        }

        public static string GetProfilePic()
        {
            string pictureURL = sm_LoggedInUser.PictureNormalURL;
            Console.WriteLine(pictureURL);

            return pictureURL;
        }
    }
}