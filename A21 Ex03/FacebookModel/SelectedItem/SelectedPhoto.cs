﻿using FacebookWrapper.ObjectModel;

namespace A21_Ex03
{
    internal class SelectedPhoto : ISelectedItem
    {
        private Photo m_SelectedPhoto;

        public SelectedPhoto(Photo i_SelectedPhoto)
        {
            m_SelectedPhoto = i_SelectedPhoto;
        }

        public string Message
        {
            get
            {
                return m_SelectedPhoto.Message;   
            }
        }

        public string PictureURL
        {
            get
            {
                return m_SelectedPhoto.PictureNormalURL;
            }
        }

        public FacebookObjectCollection<Comment> Comments
        {
            get
            {
                return m_SelectedPhoto.Comments;
            }
        }

        public bool isLikedByUser(User i_UserToCheck)
        {
            bool isLiked = false;

            isLiked = m_SelectedPhoto.LikedBy.Contains(i_UserToCheck);

            return isLiked;
        }

        public int CommentsCount
        {
            get
            {
                return m_SelectedPhoto.Comments.Count;
            }
        }

        public int LikesCount
        {
            get
            {
                return m_SelectedPhoto.LikedBy.Count;
            }
        }

        public void CommentOnPost(string i_TextToComment)
        {
            m_SelectedPhoto.Comment(i_TextToComment);
        }

        public void LikePost()
        {
            m_SelectedPhoto.Like();
        }

        public void DislikePost()
        {
            m_SelectedPhoto.Unlike();
        }
    }
}