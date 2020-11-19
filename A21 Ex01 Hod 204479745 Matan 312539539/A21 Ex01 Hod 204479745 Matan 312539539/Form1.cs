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

            if (m_CurrentConnection.LoginResult == null)
            {
                logInUser();
            }
            else
            {
                logOutUser();
            }
        }

        private void logInUser()
        {
            string loginError = string.Empty;

            try
            {
                loginError = m_CurrentConnection.LogInUser("3925570110805927");
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not log in to the facebook server.");
            }

            if (!string.IsNullOrEmpty(loginError))
            {
                MessageBox.Show(loginError);
            }
            else
            {
                Text = string.Format("Mini Facebook - {0}", m_CurrentConnection.LoggedInUser.Name);
                connectionButton.Text = "Log Out";
                userLabel.Text = m_CurrentConnection.LoggedInUser.Name;
                fetchUserInfo();
            }
        }

        private void logOutUser()
        {
            m_CurrentConnection.LogOutUser();
            clearAllData();
            connectionButton.Text = "Log In";
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(m_CurrentConnection.LoggedInUser.PictureNormalURL);
            updateCollectionsItemsTabControllListBoxes(m_CurrentConnection.LoggedInUser); // needs to be converted to nomral Fetch<T>
            fetch<User>(m_CurrentConnection.LoggedInUser.Friends, friendsListBox);
            fetch<Event>(m_CurrentConnection.LoggedInUser.Events, eventsListBox);
            fetch<Album>(m_CurrentConnection.LoggedInUser.Albums, albumsListBox);
            fetch<Group>(m_CurrentConnection.LoggedInUser.Groups, groupsListBox);
            //fetch<Post>(m_CurrentConnection.LoggedInUser.WallPosts, postsListBox);
        }

        private void clearAllData()
        {
            profilePictureBox.CancelAsync();
            clearAllListBoxes();
            clearAllSelectedPostInformation();
        }

        private void clearAllListBoxes()
        {
            friendsListBox.Items.Clear();
            albumsListBox.Items.Clear();
            groupsListBox.Items.Clear();
            eventsListBox.Items.Clear();
            postsListBox.Items.Clear();
        }

        private void updateCollectionsItemsTabControllListBoxes(User i_UserToFetchPosts) //TODO CHANGE METHOD
        {
            clearCollectionsItemsTabControlListBoxes();

            foreach (Post item in i_UserToFetchPosts.Posts)
            {
                if (item.PictureURL == null)
                {
                    postsListBox.Items.Add(item);
                }
                else
                {
                    picturesListBox.Items.Add(item);
                }
            }
            //postsListBox.DataSource = i_UserToFetchPosts.WallPosts;

            if (i_UserToFetchPosts.WallPosts.Count == 0)
            {
                postsListBox.Items.Add(string.Format("{0} has no posts", i_UserToFetchPosts.Name));
            }
        }

        private void clearCollectionsItemsTabControlListBoxes()
        {
            postsListBox.Items.Clear();
            picturesListBox.Items.Clear();
        }

        private void fetch<T>(FacebookObjectCollection<T> i_Collection, ListBox i_ListBoxToUpdate)
        {
            foreach (T evnt in i_Collection) // TODO - how to deal with posts with pictures and posts without.
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
            postsListBox.Items.Clear();

            if (friendsListBox.SelectedItem is User)
            {
                User selectedFriend = friendsListBox.SelectedItem as User;
                fetch<Post>(selectedFriend.WallPosts, postsListBox);
            }
        }

        private void AlbumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postsListBox.Items.Clear();

            if (albumsListBox.SelectedItem is Album)
            {
                Album selectedAlbum = albumsListBox.SelectedItem as Album;
                fetch<Photo>(selectedAlbum.Photos, postsListBox);
            }
        }

        private void GroupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postsListBox.Items.Clear();

            if (groupsListBox.SelectedItem is Group)
            {
                Group selectedGroup = groupsListBox.SelectedItem as Group;
                fetch<Post>(selectedGroup.WallPosts, postsListBox);
            }
        }

        private void EventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            postsListBox.Items.Clear();

            if (eventsListBox.SelectedItem is Event)
            {
                Event selectedEvent = eventsListBox.SelectedItem as Event;
                fetch<Post>(selectedEvent.WallPosts, postsListBox);
            }
        }

        private void MyPostsButton_Click(object sender, EventArgs e)
        {
            postsListBox.Items.Clear();
            updateCollectionsItemsTabControllListBoxes(m_CurrentConnection.LoggedInUser);
        }

        private void PostsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBox(postsListBox);
        }

        private void updateListBox(ListBox i_ListBoxToUpdate)
        {
            Post selectedPost;
            Status selectedStatus;
            Photo selectedPhoto;

            clearAllSelectedPostInformation();

            if (i_ListBoxToUpdate.SelectedItem is Post)
            {
                selectedPost = i_ListBoxToUpdate.SelectedItem as Post;
                fetchPostedItemDetails(selectedPost, selectedPost.PictureURL);
            }
            else if (i_ListBoxToUpdate.SelectedItem is Status)
            {
                selectedStatus = i_ListBoxToUpdate.SelectedItem as Status;
                fetchPostedItemDetails(selectedStatus);
            }
            else if (i_ListBoxToUpdate.SelectedItem is Photo)
            {
                selectedPhoto = i_ListBoxToUpdate.SelectedItem as Photo;
                fetchPostedItemDetails(selectedPhoto, selectedPhoto.PictureNormalURL);
            }
        }

        private void clearAllSelectedPostInformation()
        {
            postPictureBox.CancelAsync();
            postTextBox.Clear();
            postCommentsListBox.Items.Clear();
            pommentTextBox.Clear();
        }

        private void fetchPostedItemDetails(PostedItem i_SelectedItem, string i_PictureURL = null)
        {
            // show post picture, if there isnt one, show the poster profile picture
            if (i_PictureURL == null)
            {
                try
                {
                    postPictureBox.LoadAsync(i_SelectedItem.From.PictureNormalURL);
                }
                catch (Exception e) // in case of an unavailable profilepicture, will show default picture.
                {
                    postPictureBox.LoadAsync();
                }
                
            }
            else
            {
                postPictureBox.LoadAsync(i_PictureURL);
            }

            postTextBox.Text = i_SelectedItem.Message;
            try
            {
                fetch<Comment>(i_SelectedItem.Comments, postCommentsListBox);
            }
            catch (Exception e)
            {
                MessageBox.Show("Missing permission.");
            }
            
            updatePostedItemInformation(i_SelectedItem);
        }

        private void updatePostedItemInformation(PostedItem i_SelectedItem)
        {
            updateLikesLabel(i_SelectedItem);
            updateCommentsLabel(i_SelectedItem);
            updateLikeButtonName(i_SelectedItem);
        }

        private void updateCommentsLabel(PostedItem i_SelectedItem)
        {
            try
            {
                commentsLabel.Text = string.Format("Comments: {0}", i_SelectedItem.Comments.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem receiving the amount of comments.");
            }
        }

        private void updateLikesLabel(PostedItem i_SelectedItem)
        {
            try
            {
                likesLabel.Text = string.Format("Likes: {0}", i_SelectedItem.LikedBy.Count);
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem receiving the amount of likes.");
            }
            
        }

        private void updateLikeButtonName(PostedItem i_SelectedItem)
        {
            try
            {
                if (isLikedByUser(i_SelectedItem, m_CurrentConnection.LoggedInUser))
                {
                    likeButton.Text = "Dislike";
                }
                else
                {
                    likeButton.Text = "Like";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem determining user post like.");
            }
            
        }

        private void LikeButton_Click(object sender, EventArgs e)
        {
            Post selectedPost = postsListBox.SelectedItem as Post;

            try
            {
                if (selectedPost != null)
                {
                    if (isLikedByUser(selectedPost, m_CurrentConnection.LoggedInUser))
                    {
                        selectedPost.Unlike();
                        updatePostedItemInformation(selectedPost);
                    }
                    else
                    {
                        selectedPost.Like();
                        updatePostedItemInformation(selectedPost);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem liking the post.");
            }
        }

        private bool isLikedByUser(PostedItem i_PostToCheck, User i_UserToCheck)
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
            string comment = pommentTextBox.Text;
            string errorMsg = "An error occured while trying to comment";
            Post selectedPost = postsListBox.SelectedItem as Post;

            try
            {
                if (!string.IsNullOrEmpty(comment))
                {
                    selectedPost.Comment(comment);
                    updatePostedItemInformation(selectedPost);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was a problem commenting on the post.");
            }
            
        }

        private void picturesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBox(picturesListBox);
        }
    }

}