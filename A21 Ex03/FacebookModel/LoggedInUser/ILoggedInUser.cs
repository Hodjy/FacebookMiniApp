using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    public interface ILoggedInUser
    {
        string Name
        {
            get;
        }

        string PictureURL
        {
            get;
        }

        FacebookObjectCollection<Post> WallPosts
        {
            get;
        }

        FacebookObjectCollection<User> Friends
        {
            get;
        }

        FacebookObjectCollection<Event> Events
        {
            get;
        }

        FacebookObjectCollection<Group> Groups
        {
            get;
        }

        FacebookObjectCollection<Album> Albums
        {
            get;
        }

    }
}