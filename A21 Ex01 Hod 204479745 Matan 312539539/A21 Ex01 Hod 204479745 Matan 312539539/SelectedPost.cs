using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public class SelectedPost
    {
        private static PostedItem m_SelectedItem = null;
        private string m_PictureURL; // Needs to determine what type of object in order to get. (All)Might do Meth+Adapter.
        private string m_PostMessage;

        public SelectedPost()
        {
            m_PictureURL = string.Empty;
            m_PostMessage = string.Empty;
        }

        public FacebookObjectCollection<Comment> Comments
        {
            get
            {
                checkAndThrowExeptionIfSelectedItemIsNull();

                return m_SelectedItem.Comments;
            }
        }
        
        public int LikedByCount
        {
            get
            {
                checkAndThrowExeptionIfSelectedItemIsNull();

                return m_SelectedItem.LikedBy.Count;
            }
        }

        public int CommentsCount
        {
            get
            {
                checkAndThrowExeptionIfSelectedItemIsNull();

                return m_SelectedItem.Comments.Count;
            }
        }

        public string PostMessage
        {
            get
            {
                checkAndThrowExeptionIfSelectedItemIsNull();

                return m_PostMessage;
            }
        }

        public string PictureURL
        {
            get
            {
                checkAndThrowExeptionIfSelectedItemIsNull();

                return m_PictureURL;
            }
        }

        public bool IsLikedByUser(User i_UserToCheck)
        {
            bool isLiked = false;

            checkAndThrowExeptionIfSelectedItemIsNull();

            if (m_SelectedItem.LikedBy.Contains(i_UserToCheck))
            {
                isLiked = true;
            }

            return isLiked;
        }

        public void CommentOnPost(string i_TextToComment)
        {
            checkAndThrowExeptionIfSelectedItemIsNull();
            m_SelectedItem.Comment(i_TextToComment);
        }

        public void LikePost()
        {
            checkAndThrowExeptionIfSelectedItemIsNull();
            m_SelectedItem.Like();
        }

        public void UnlikePost()
        {
            checkAndThrowExeptionIfSelectedItemIsNull();
            m_SelectedItem.Unlike();
        }

        public void ChangeSelectedItem(PostedItem i_NewSelectedItem, string i_PictureURL, string i_Message)
        {
            m_SelectedItem = i_NewSelectedItem;
            m_PictureURL = i_PictureURL;
            m_PostMessage = i_Message;
        }

        public void ClearSelectedItem()
        {
            m_SelectedItem = null;
            m_PictureURL = string.Empty;
            m_PostMessage = string.Empty;
        }

        private void checkAndThrowExeptionIfSelectedItemIsNull()
        {
            string errMsg = "SelectedItem is null.";

            if (m_SelectedItem == null)
            {
                throw new Exception(errMsg);
            }
        }
    }
}
