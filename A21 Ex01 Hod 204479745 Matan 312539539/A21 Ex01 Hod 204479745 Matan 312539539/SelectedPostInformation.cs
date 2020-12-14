using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public sealed class SelectedPostInformation
    {
        private static SelectedPostInformation m_SelectedPostInformationSingleton;
        private static PostedItem m_SelectedItem;
        private static string m_PictureURL; // Needs to determin what type of object in order to get. Might do Meth+Adaptor.

        private SelectedPostInformation()
        {

        }

        public SelectedPostInformation SelectedPostInformationSingleton
        {
            get
            {
                if (m_SelectedPostInformationSingleton == null)
                {
                    m_SelectedPostInformationSingleton = new SelectedPostInformation();
                }

                return new SelectedPostInformation();
            }
        }

        public PostedItem SelectedItem
        {
            set
            {
                m_SelectedItem = value;

                if (m_SelectedItem is Post)
                {
                    m_PictureURL = (m_SelectedItem as Post).PictureURL;
                }
                else if (m_SelectedItem is Status)
                {
                    m_PictureURL = string.Empty;
                }
                else if(m_SelectedItem is Photo)
                {
                    m_PictureURL = (m_SelectedItem as Photo).PictureNormalURL;
                }
            }
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

                return m_SelectedItem.Message;
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
