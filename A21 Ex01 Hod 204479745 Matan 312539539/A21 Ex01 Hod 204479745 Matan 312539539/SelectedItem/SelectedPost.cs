using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    internal class SelectedPost : ISelectedItem
    {
        Post m_SelectedPost;

        public SelectedPost(Post i_SelectedPost)
        {
            m_SelectedPost = i_SelectedPost;
        }

        public string Message
        {
            get
            {
                return m_SelectedPost.Message;
            }
        }

        public string PictureURL
        {
            get
            {
                return m_SelectedPost.PictureURL;
            }
        }

        public FacebookObjectCollection<Comment> Comments
        {
            get
            {
                return m_SelectedPost.Comments;
            }
        }

        public bool isLikedByUser(User i_UserToCheck)
        {
            bool isLiked = false;

            isLiked = m_SelectedPost.LikedBy.Contains(i_UserToCheck);

            return isLiked;
        }

        public int CommentsCount
        {
            get
            {
                return m_SelectedPost.Comments.Count;
            }
        }

        public int LikesCount
        {
            get
            {
                return m_SelectedPost.LikedBy.Count;
            }
        }

        public void CommentOnPost(string i_TextToComment)
        {
            m_SelectedPost.Comment(i_TextToComment);
        }

        public void LikePost()
        {
            m_SelectedPost.Like();
        }

        public void DislikePost()
        {
            m_SelectedPost.Unlike();
        }
    }
}