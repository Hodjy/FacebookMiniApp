using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    public interface ISelectedItem
    {
        string Message
        {
            get;
        }

        string PictureURL
        {
            get;
        }

        FacebookObjectCollection<Comment> Comments
        {
            get;
        }

        int CommentsCount
        {
            get;
        }

        int LikesCount
        {
            get;
        }

        bool isLikedByUser(User i_UserToCheck);

        void CommentOnPost(string i_TextToComment);

        void LikePost();

        void DislikePost();
    }
}