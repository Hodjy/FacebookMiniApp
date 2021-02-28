using FacebookWrapper.ObjectModel;


namespace A21_Ex03
{
    public class LoggedInUser : ILoggedInUser
    {
        private UserToLoggedInUser m_LoggedInUser;
        private readonly string rm_DefaultName = "Application User";
        private readonly string rm_DefaultPictureURL = "https://i.4cdn.org/v/1609174013137.png";

        public LoggedInUser()
        {
        }

        public string Name
        {
            get
            {
                string stringToReturn = rm_DefaultName;

                if(m_LoggedInUser != null)
                {
                    stringToReturn = m_LoggedInUser.Name;
                }

                return stringToReturn;
            }
        }

        public string PictureURL
        {
            get
            {
                string pictureURLToReturn = rm_DefaultPictureURL;

                if(m_LoggedInUser != null)
                {
                    pictureURLToReturn = m_LoggedInUser.PictureURL;
                }

                return pictureURLToReturn;
            }
        }

        public FacebookObjectCollection<Post> WallPosts
        {
            get
            {
                FacebookObjectCollection<Post> wallPostsToReturn = null;

                if (m_LoggedInUser != null)
                {
                    wallPostsToReturn = m_LoggedInUser.WallPosts;
                }

                return wallPostsToReturn;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                FacebookObjectCollection<User> friendsToReturn = null;

                if (m_LoggedInUser != null)
                {
                    friendsToReturn = m_LoggedInUser.Friends;
                }

                return friendsToReturn;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                FacebookObjectCollection<Event> eventsToReturn = null;

                if (m_LoggedInUser != null)
                {
                    eventsToReturn = m_LoggedInUser.Events;
                }

                return eventsToReturn;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                FacebookObjectCollection<Group> groupsToReturn = null;

                if (m_LoggedInUser != null)
                {
                    groupsToReturn = m_LoggedInUser.Groups;
                }

                return groupsToReturn;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                FacebookObjectCollection<Album> albumsToReturn = null;

                if (m_LoggedInUser != null)
                {
                    albumsToReturn = m_LoggedInUser.Albums;
                }

                return albumsToReturn;
            }
        }

        internal UserToLoggedInUser User
        {
            set
            {
                m_LoggedInUser = value;
            }
        }
    }
}