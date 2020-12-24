using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public interface ISelectedItem
    {
        string Message
        {
            get;
        }

        string Picture
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

        void CommentOnPost(string i_TextToComment);

        void LikePost();

        void DislikePost();
    }
}
