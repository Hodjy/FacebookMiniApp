using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public partial class Form1 : Form
    {
        ConnectionManager m_CurrentConnection;

        public Form1()
        {
            m_CurrentConnection = new ConnectionManager();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void connectionButton_Click(object sender, EventArgs e)
        {
            string loginError = string.Empty;

            if (m_CurrentConnection.LoginResult == null)
            {
                loginError = m_CurrentConnection.LogInUser("3925570110805927");
                if (!string.IsNullOrEmpty(loginError))
                {
                    MessageBox.Show(loginError);
                }
                else
                {
                    Text = string.Format("Mini Facebook - {0}", m_CurrentConnection.LoggedInUser.Name);
                    connectionButton.Text = "Log Out";
                    UserLabel1.Text = m_CurrentConnection.LoggedInUser.Name;
                    fetchUserInfo();
                }
            }
            else
            {
                m_CurrentConnection.LogOutUser();
                connectionButton.Text = "Log In";
            }
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(m_CurrentConnection.LoggedInUser.PictureNormalURL);
            fetchPosts(m_CurrentConnection.LoggedInUser);
            fetch<User>(m_CurrentConnection.LoggedInUser.Friends, FriendsListBox);
            fetch<Event>(m_CurrentConnection.LoggedInUser.Events, EventsListBox);
            fetch<Album>(m_CurrentConnection.LoggedInUser.Albums, AlbumsListBox);
            fetch<Group>(m_CurrentConnection.LoggedInUser.Groups, GroupsListBox);
        }

        private void fetchPosts(User i_UserToFetchPosts)
        {
            PostsListBox.Items.Clear();
            foreach (Post wallPost in i_UserToFetchPosts.WallPosts)
            {
                if (wallPost.Caption != null)
                {
                    PostsListBox.Items.Add(wallPost.Caption);
                }
                else
                {
                    PostsListBox.Items.Add(string.Format("[{0}]", wallPost.Type));
                }
            }

            if (i_UserToFetchPosts.WallPosts.Count == 0)
            {
                PostsListBox.Items.Add(string.Format("{0} has no posts", i_UserToFetchPosts.Name));
            }
        }

        private void fetch<T>(FacebookObjectCollection<T> i_Collection, ListBox i_ListBoxToUpdate)
        {
            foreach (T evnt in i_Collection)
            {
                i_ListBoxToUpdate.Items.Add(evnt);
            }

            if (i_Collection.Count() == 0)
            {
                i_ListBoxToUpdate.Items.Add(string.Format("{0} has no {1}", m_CurrentConnection.LoggedInUser.Name, typeof(T).Name));
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FriendsListBox.SelectedItem is User)
            {
                User selectedFriend = FriendsListBox.SelectedItem as User;
                fetchPosts(selectedFriend);
            }
            else
            {
                PostsListBox.Items.Clear();
            }
        }

        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AlbumsListBox.SelectedItem is Album)
            {
                Album selectedAlbum = AlbumsListBox.SelectedItem as Album;
                // TODO : fetch pictures list from selected album
            }
            else
            {
                PostsListBox.Items.Clear();
            }
        }

        private void GroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GroupsListBox.SelectedItem is Group)
            {
                Group selectedGroup = GroupsListBox.SelectedItem as Group;
                // TODO : fetch pictures list from selected album
            }
            else
            {
                PostsListBox.Items.Clear();
            }
        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EventsListBox.SelectedItem is Event)
            {
                Event selectedEvent = EventsListBox.SelectedItem as Event;
                // TODO : fetch pictures list from selected album
            }
            else
            {
                PostsListBox.Items.Clear();
            }
        }

        private void MyPostsButton_Click(object sender, EventArgs e)
        {
            PostsListBox.Items.Clear();
            fetchPosts(m_CurrentConnection.LoggedInUser);
        }

        private void PostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PostsListBox.SelectedItem is Post)
            {
                Post selectedPost = PostsListBox.SelectedItem as Post;
                fetchPostsDetails(selectedPost);
            }
        }

        private void fetchPostsDetails(Post selectedPost)
        {
            // show post picture, if there isnt one, show the poster profile picture
            if (selectedPost.PictureURL == null)
            {
                PostPictureBox.LoadAsync(selectedPost.From.PictureLargeURL);
            }
            else
            {
                PostPictureBox.LoadAsync(selectedPost.PictureURL);
            }

            PostTextBox.Text = selectedPost.Message;
            fetch<Comment>(selectedPost.Comments, PostCommentsListBox);
            updatePostInformation(selectedPost);
        }

        private void updatePostInformation(Post selectedPost)
        {
            LikesLabel.Text = string.Format("Likes: {0}", selectedPost.LikedBy.Count);
            CommentsLabel.Text = string.Format("Comments: {0}", selectedPost.Comments.Count);

            if (isLikedByUser(selectedPost, m_CurrentConnection.LoggedInUser))
            {
                LikeButton.Text = "Dislike";
            }
            else
            {
                LikeButton.Text = "Like";
            }
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            Post selectedPost = PostsListBox.SelectedItem as Post;

            if (selectedPost != null)
            {
                if (isLikedByUser(selectedPost, m_CurrentConnection.LoggedInUser))
                {
                    selectedPost.Unlike();
                    updatePostInformation(selectedPost);
                }
                else
                {
                    selectedPost.Like();
                    updatePostInformation(selectedPost);
                }
            }
        }

        private bool isLikedByUser(Post i_PostToCheck, User i_UserToCheck)
        {
            bool isLiked = false;

            if (i_PostToCheck.LikedBy.Contains(i_UserToCheck))
            {
                isLiked = true;
            }

            return isLiked;
        }

        private void CommentButton_Click(object sender, EventArgs e)
        {
            // TODO: Comment button click event
            throw new NotImplementedException();
        }
    }

}