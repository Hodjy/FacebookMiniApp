using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    static class ConnectionManager
    {
        static LoginResult m_LoginResult;
        static User m_LoggedInUser;

        public static void commitLoginIfNull(string i_AppID)
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
                    "user_hometown"
                    );
            }
        }
    }
}
