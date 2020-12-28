using FacebookWrapper.ObjectModel;


namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal class UserToLoggedInUserAdapter : ILoggedInUser
    {
        private User m_AdaptedUser;

        public UserToLoggedInUserAdapter(User i_UserToAdapt)
        {
            m_AdaptedUser = i_UserToAdapt;
        }

        public string Name
        {
            get
            {
                return m_AdaptedUser.Name;
            }
        }

        public string PictureURL
        {
            get
            {
                return m_AdaptedUser.PictureNormalURL;
            }
        }

        public FacebookObjectCollection<Post> WallPosts
        {
            get
            {
                return m_AdaptedUser.WallPosts;
            }
        }

        public FacebookObjectCollection<User> Friends
        {
            get
            {
                return m_AdaptedUser.Friends;
            }
        }

        public FacebookObjectCollection<Event> Events
        {
            get
            {
                return m_AdaptedUser.Events;
            }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get
            {
                return m_AdaptedUser.Groups;
            }
        }

        public FacebookObjectCollection<Album> Albums
        {
            get
            {
                return m_AdaptedUser.Albums;
            }
        }

        public User LoggedInUser
        {
            get
            {
                return m_AdaptedUser;
            }
        }
    }
}