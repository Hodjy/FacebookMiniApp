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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void logInUser()
        {
            string loginError = string.Empty;

            try
            {
                loginError = ConnectionManager.LogInUser("3925570110805927");
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
                Text = string.Format("Mini Facebook - {0}", ConnectionManager.LoggedInUser.Name);
                connectionButton.Text = "Log Out";
                userLabel.Text = ConnectionManager.LoggedInUser.Name;
                fetchUserInfo();
            }
        }

        private void logOutUser()
        {
            ConnectionManager.LogOutUser();
            clearAllData();
            connectionButton.Text = "Log In";
        }

        private void fetchUserInfo()
        {
            profilePictureBox.LoadAsync(ConnectionManager.LoggedInUser.PictureNormalURL);
            updateCollectionsItemsTabControllListBoxes(ConnectionManager.LoggedInUser.Posts); // needs to be converted to nomral Fetch<T>
            fetch<User>(ConnectionManager.LoggedInUser.Friends, friendsListBox);
            fetch<Event>(ConnectionManager.LoggedInUser.Events, eventsListBox);
            fetch<Album>(ConnectionManager.LoggedInUser.Albums, albumsListBox);
            fetch<Group>(ConnectionManager.LoggedInUser.Groups, groupsListBox);
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

        private void clearAllSelectedPostInformation()
        {
            postPictureBox.CancelAsync();
            postTextBox.Clear();
            postCommentsListBox.Items.Clear();
            pommentTextBox.Clear();
        }

        private void updateCollectionsItemsTabControllListBoxes(FacebookObjectCollection<Post> i_PostsCollection)
        {
            clearCollectionsItemsTabControlListBoxes();
            try
            {
                foreach (Post item in i_PostsCollection) // add text posts to postsListBox and picture posts to picturesListBox
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

                if (i_PostsCollection.Count == 0)
                {
                    postsListBox.Items.Add("No posts to show");
                    picturesListBox.Items.Add("No pictures to show");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was a problem updating the posts and pictures list.");
            }
        }

        private void addItemToCollectionItemsTabControlListBoxes(Post i_CurrentPost)
        {
            if (i_CurrentPost.PictureURL == null)
            {
                postsListBox.Items.Add(i_CurrentPost);
            }
            else
            {
                picturesListBox.Items.Add(i_CurrentPost);
            }
        }

        private void clearCollectionsItemsTabControlListBoxes()
        {
            postsListBox.Items.Clear();
            picturesListBox.Items.Clear();
        }

        private void fetch<T>(FacebookObjectCollection<T> i_Collection, ListBox i_ListBoxToUpdate)
        {
            try
            {
                foreach (T evnt in i_Collection)
                {
                    i_ListBoxToUpdate.Items.Add(evnt);
                }

                if (i_Collection.Count() == 0)
                {
                    i_ListBoxToUpdate.Items.Add(string.Format("{0} has no {1}", ConnectionManager.LoggedInUser.Name, typeof(T).Name));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("There was a problem fetching {0}", typeof(T).Name));
            }

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

        private void fetchPostedItemDetails(PostedItem i_SelectedItem, string i_PictureURL = null)
        {
            // show post picture, if there isnt one, show the poster profile picture
            if (i_PictureURL == null)
            {
                try
                {
                    postPictureBox.LoadAsync(i_SelectedItem.From.PictureNormalURL);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Failed to load image.");
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
                if (isLikedByUser(i_SelectedItem, ConnectionManager.LoggedInUser))
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

        private bool isLikedByUser(PostedItem i_PostToCheck, User i_UserToCheck)
        {
            bool isLiked = false;

            if (i_PostToCheck.LikedBy.Contains(i_UserToCheck))
            {
                isLiked = true;
            }

            return isLiked;
        }

        private void updateTabControlByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_SelectedDate)
        {
            clearCollectionsItemsTabControlListBoxes();

            try
            {
                foreach (Post currentPost in i_PostsToFilter)
                {
                    if (currentPost.CreatedTime >= i_SelectedDate)
                    {
                        addItemToCollectionItemsTabControlListBoxes(currentPost);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was problem while filtering posts");
            }
        }

        private void updateTabControlByLikes(FacebookObjectCollection<Post> i_PostsToFilter, int i_MinLikesCount)
        {
            clearCollectionsItemsTabControlListBoxes();

            try
            {
                foreach (Post currentPost in i_PostsToFilter)
                {
                    if (currentPost.LikedBy.Count >= i_MinLikesCount)
                    {
                        addItemToCollectionItemsTabControlListBoxes(currentPost);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There was problem while filtering posts");
            }
        }

        // EVENTS

        private void connectionButton_Click(object sender, EventArgs e)
        {

            if (ConnectionManager.LoginResult == null)
            {
                logInUser();
            }
            else
            {
                logOutUser();
            }
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (friendsListBox.SelectedItem is User)
            {
                try
                {
                    User selectedFriend = friendsListBox.SelectedItem as User;
                    updateCollectionsItemsTabControllListBoxes(selectedFriend.WallPosts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Friends.");
                }
            }
        }

        private void albumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCollectionsItemsTabControlListBoxes();

            if (albumsListBox.SelectedItem is Album)
            {
                try
                {
                    Album selectedAlbum = albumsListBox.SelectedItem as Album;
                    fetch<Photo>(selectedAlbum.Photos, picturesListBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Pictures.");
                }
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (groupsListBox.SelectedItem is Group)
            {
                try
                {
                    Group selectedGroup = groupsListBox.SelectedItem as Group;
                    updateCollectionsItemsTabControllListBoxes(selectedGroup.WallPosts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Groups.");
                }
            }
        }

        private void eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (eventsListBox.SelectedItem is Event)
            {
                try
                {
                    Event selectedEvent = eventsListBox.SelectedItem as Event;
                    updateCollectionsItemsTabControllListBoxes(selectedEvent.WallPosts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Events.");
                }
            }
        }

        private void myPostsButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateCollectionsItemsTabControllListBoxes(ConnectionManager.LoggedInUser.WallPosts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem receiving Posts.");
            }
        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBox(postsListBox);
        }

        private void picturesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBox(picturesListBox);
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            Post selectedPost = postsListBox.SelectedItem as Post;

            try
            {
                if (selectedPost != null)
                {
                    if (isLikedByUser(selectedPost, ConnectionManager.LoggedInUser))
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

        private void commentButton_Click(object sender, EventArgs e)
        {
            string comment = pommentTextBox.Text;
            Post selectedPost = postsListBox.SelectedItem as Post;

            try
            {
                if (!string.IsNullOrEmpty(comment))
                {
                    selectedPost.Comment(comment);
                    updatePostedItemInformation(selectedPost);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem commenting on the post.");
            }

        }

        private void dateFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateTabControlByDate(ConnectionManager.LoggedInUser.Posts, postsDateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem Filtering.");
            }
        }

        private void likesFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateTabControlByLikes(ConnectionManager.LoggedInUser.Posts, Decimal.ToInt32(likesNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem Filtering.");
            }
        }
    }
}