using System;
using System.Collections;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public partial class MainFacebookForm : Form
    {
        ILoggedInUser m_LoggedInUser;
        ISelectedItem m_SelectedItem;

        public MainFacebookForm()
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
                loginError = Facade.LogInUser();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not log in to the facebook server.");
            }

            InitiateFormInfo(loginError);
            fetchUserInfo();
        }

        private void InitiateFormInfo(string loginError)
        {
            if (!string.IsNullOrEmpty(loginError))
            {
                MessageBox.Show(loginError);
            }
            else
            {
                m_LoggedInUser = Facade.LoggedInUser;
                Text = string.Format("Mini Facebook - {0}", m_LoggedInUser.Name);
                connectionButton.Text = "Log Out";
            }
        }

        private void logOutUser()
        {
            Facade.LogOutUser();
            clearAllData();
            connectionButton.Text = "Log In";
        }

        private void fetchUserInfo()
        {
            try
            {
                ILoggedInUserBindingSource.DataSource = m_LoggedInUser;
                addItemsToListBox<Post>(m_LoggedInUser.WallPosts, postsListBox);
                iSelectedItemBindingSource.DataSource = postsListBox.Items;
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not fetch user info");
            }
        }

        private void clearAllData()
        {
            clearAllListBoxes();
            clearAllSelectedPostInformation();
        }

        private void clearAllListBoxes()
        {
            clearListBoxDataAndRefresh(postsListBox);
        }

        private void clearListBoxDataAndRefresh(ListBox i_ListBoxToClear)
        {
            i_ListBoxToClear.Items.Clear();
            i_ListBoxToClear.Refresh();
        }

        private void clearCollectionsItemsTabControlListBoxes()
        {
            postsListBox.Items.Clear();
        }  

        private void addItemsToListBox<T>(FacebookObjectCollection<T> i_Collection, ListBox i_ListBoxToUpdate)
        {
            try
            {
                foreach (T evnt in i_Collection)
                {
                    i_ListBoxToUpdate.Items.Add(evnt);
                }

                if (i_Collection.Count == 0)
                {
                    i_ListBoxToUpdate.Items.Add(string.Format("{0} has no {1}", m_LoggedInUser.Name, typeof(T).Name));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("There was a problem fetching {0}", typeof(T).Name));
            }

        }

        private void updateLikeButtonName()
        {
            try
            {
                if (Facade.isSelectedItemLikedByUser(m_SelectedItem))
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

        private void clearAllSelectedPostInformation()
        {
            commentTextBox.Clear();
        }

        private void updateListBoxByDate(FacebookObjectCollection<Post> i_PostsToFilter, DateTime i_SelectedDate)
        {
            FacebookObjectCollection<Post> filteredPosts;

            clearCollectionsItemsTabControlListBoxes();
            filteredPosts = Facade.FilterPostsByDate(i_PostsToFilter, i_SelectedDate);
            addItemsToListBox<Post>(filteredPosts, postsListBox);
        }
        
        private void updateListBoxByLikes(FacebookObjectCollection<Post> i_PostsToFilter, int i_MinLikesCount)
        {
            FacebookObjectCollection<Post> filteredPosts;

            clearCollectionsItemsTabControlListBoxes();
            filteredPosts = Facade.FilterPostsByLikesCount(i_PostsToFilter, i_MinLikesCount);
            addItemsToListBox<Post>(filteredPosts, postsListBox);

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

        private void myPostsButton_Click(object sender, EventArgs e)
        {
            try
            {
                addItemsToListBox<Post>(m_LoggedInUser.WallPosts, postsListBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem receiving Posts.");
            }
        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_SelectedItem = Facade.ConvertItemToSelectedItem((PostedItem)postsListBox.SelectedItem);
                iSelectedItemBindingSource.DataSource = m_SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem occured while trying to display the post.");
            }
        }

        private void likeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_SelectedItem != null)
                {
                    if (Facade.isSelectedItemLikedByUser(m_SelectedItem))
                    {
                        m_SelectedItem.DislikePost();
                    }
                    else
                    {
                        m_SelectedItem.LikePost();
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
            string commentText = commentTextBox.Text;

            try
            {
                if (!string.IsNullOrEmpty(commentText))
                {
                    m_SelectedItem.CommentOnPost(commentText);
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
                updateListBoxByDate(m_LoggedInUser.WallPosts, postsDateTimePicker.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was problem while filtering posts");
            }
        }

        private void likesFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                updateListBoxByLikes(m_LoggedInUser.WallPosts, Decimal.ToInt32(likesNumericUpDown.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was problem while filtering posts");
            }
        }

        private void friendListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCollectionsItemsTabControlListBoxes();

            if (friendsListBox.SelectedItem is User)
            {
                try
                {
                    User selectedFriend = friendsListBox.SelectedItem as User;
                    addItemsToListBox<Post>(selectedFriend.WallPosts, postsListBox);
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
                    addItemsToListBox<Photo>(selectedAlbum.Photos, postsListBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Albums.");
                }
            }
        }

        private void groupsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCollectionsItemsTabControlListBoxes();

            if (groupsListBox.SelectedItem is Group)
            {
                try
                {
                    Group selectedGroup = groupsListBox.SelectedItem as Group;
                    addItemsToListBox<Post>(selectedGroup.WallPosts, postsListBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Groups.");
                }
            }
        }

        private void eventsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearCollectionsItemsTabControlListBoxes();

            if (eventsListBox.SelectedItem is Event)
            {
                try
                {
                    Event selectedGroup = eventsListBox.SelectedItem as Event;
                    addItemsToListBox<Post>(selectedGroup.WallPosts, postsListBox);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Events.");
                }
            }
        }
    }
}