using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;


namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class LoggedInUser : ILoggedInUser
    {
        private UserToLoggedInUserAdapter m_LoggedInUser;

        public string Name
        {
            get
            {
                return m_LoggedInUser.Name;
            }
        }

        public string PictureURL
        {
            get
            {
                return m_LoggedInUser.PictureURL;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return m_LoggedInUser.Friends;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return m_LoggedInUser.Events;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return m_LoggedInUser.Groups;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_LoggedInUser.Albums;
            }
        }

        public UserToLoggedInUserAdapter EmbeddedLoggedInUser
        {
            set
            {
                m_LoggedInUser = value;
            }
        }
    }
}
