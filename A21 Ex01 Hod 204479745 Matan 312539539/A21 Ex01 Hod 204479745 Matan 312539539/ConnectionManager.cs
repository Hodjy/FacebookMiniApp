using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class ConnectionManager
    {
        private static LoginResult m_LoginResult;
        private static User m_LoggedInUser;

        public ConnectionManager()
        {
        }

        public LoginResult LoginResult
        {
            get { return m_LoginResult; }
        }

        public User LoggedInUser
        {
            get { return m_LoggedInUser; }
        }

        public string LogInUser(string i_AppID)
        {
            string errorMessage = string.Empty;

            commitLogin(i_AppID);
            errorMessage = setLoggedInUser();

            return errorMessage;
        }

        private void commitLogin(string i_AppID)
        {
            if (m_LoginResult == null)
            {
                m_LoginResult = FacebookService.Login(i_AppID,
                    "public_profile",
                    "email",
                    "publish_to_groups",
                    "user_birthday",
                    "user_age_range",
                    "user_gender",
                    "user_link",
                    "user_tagged_places",
                    "user_videos",
                    "publish_to_groups",
                    "groups_access_member_info",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_location",
                    "user_photos",
                    "user_posts",
                    "user_hometown",
                    "user_managed_groups",
                    "read_page_mailboxes",
                    "user_status"
                    );
            }
        }

        private string setLoggedInUser()
        {
            string loginError = string.Empty;

            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
            else
            {
                loginError = m_LoginResult.ErrorMessage;
            }

            return loginError;
        }

        public void LogOutUser()
        {
            m_LoginResult = null;
        }

        public string GetProfilePic()
        {
            string pictureURL = m_LoggedInUser.PictureNormalURL;
            Console.WriteLine(pictureURL);

            return pictureURL;
        }
    }
}