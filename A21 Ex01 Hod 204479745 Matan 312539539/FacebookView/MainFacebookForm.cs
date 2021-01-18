using System;
using System.Threading;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    public partial class MainFacebookForm : Form
    {
        private ILoggedInUser m_LoggedInUser;
        private ISelectedItem m_SelectedItem;
        private static readonly object sr_ListboxAddLock = new object();
        private List<IDarkmodeToggable> m_DarkmodeItems;


        public MainFacebookForm()
        {
            InitializeComponent();
            initializeDarkModeComponents();
        }

        private void Form_Load(object sender, EventArgs e)
        {           
        }

        private void logInUser()
        {
            string loginError = string.Empty;

            try
            {
                loginError = FacebookLogic.LogInUser();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not log in to the facebook server.");
            }

            InitiateFormInfo(loginError);
            new Thread(fetchUserInfo).Start();
        }

        private void InitiateFormInfo(string loginError)
        {
            if (!string.IsNullOrEmpty(loginError))
            {
                MessageBox.Show(loginError);
            }
            else
            {
                m_LoggedInUser = FacebookLogic.LoggedInUser;
                Text = string.Format("Mini Facebook - {0}", m_LoggedInUser.Name);
                connectionButton.Text = "Log Out";
            }
        }

        private void logOutUser()
        {
            FacebookLogic.LogOutUser();
            clearAllData();
            connectionButton.Text = "Log In";
        }

        private void fetchUserInfo()
        {
                new Thread(bindLoggedInUser).Start();
                new Thread(() => addItemsToPostListBox<Post>(m_LoggedInUser.WallPosts)).Start();
        }

        private void bindLoggedInUser()
        {
            try
            {
                ILoggedInUserBindingSource.DataSource = m_LoggedInUser;
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not fetch user info");
            }
        }

        private void bindSelectedItem()
        {
            try
            {
                iSelectedItemBindingSource.DataSource = m_SelectedItem;
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not show the post.");
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
            postsListBox.Invoke(new Action(() => postsListBox.Items.Clear()));
        }  

        private void addItemsToPostListBox<T>(FacebookObjectCollection<T> i_Collection)
        {
            lock(sr_ListboxAddLock)
            {
                try
                {
                    foreach (T item in i_Collection)
                    {
                        postsListBox.Invoke(new Action(() => postsListBox.Items.Add(item)));
                    }

                    if (i_Collection.Count == 0)
                    {
                        postsListBox.Invoke(new Action(() =>
                            postsListBox.Items.Add(string.Format("There are no {0}",typeof(T).Name))));
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("There was a problem fetching {0}", typeof(T).Name));
                }
            }
        }

        private void updateLikeButtonName()
        {
            try
            {
                if (FacebookLogic.IsSelectedItemLikedByUser(m_SelectedItem))
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
            filteredPosts = FacebookLogic.FilterPostsByDate(i_PostsToFilter, i_SelectedDate);
            addItemsToPostListBox<Post>(filteredPosts);
        }
        
        private void updateListBoxByLikes(FacebookObjectCollection<Post> i_PostsToFilter, int i_MinLikesCount)
        {
            FacebookObjectCollection<Post> filteredPosts;

            clearCollectionsItemsTabControlListBoxes();
            filteredPosts = FacebookLogic.FilterPostsByLikesCount(i_PostsToFilter, i_MinLikesCount);
            addItemsToPostListBox<Post>(filteredPosts);

        }

        private void initializeDarkModeComponents()
        {
            m_DarkmodeItems = new List<IDarkmodeToggable>();
            m_DarkmodeItems.Add(new FormDarkmodeProxy(this));
            m_DarkmodeItems.Add(new GroupBoxDarkmodeProxy(postsGroupBox));
            m_DarkmodeItems.Add(new LabelDarkmodeProxy(likesLabel));
            m_DarkmodeItems.Add(new LabelDarkmodeProxy(likesCountLabel));
            m_DarkmodeItems.Add(new LabelDarkmodeProxy(commentsLabel));
            m_DarkmodeItems.Add(new LabelDarkmodeProxy(commentsCountLabel));
        }

        private void toggleDarkMode()
        {
            foreach (IDarkmodeToggable item in m_DarkmodeItems)
            {
                item.ToggleDarkmode();
            }
        }

        // EVENTS

        private void connectionButton_Click(object sender, EventArgs e)
        {

            if (!FacebookLogic.IsUserLoggedIn)
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
            if(FacebookLogic.IsUserLoggedIn)
            {
                try
                {
                    new Thread (() => addItemsToPostListBox<Post>(m_LoggedInUser.WallPosts)).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Posts.");
                }
            }
        }

        private void postsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                m_SelectedItem = FacebookLogic.ConvertItemToSelectedItem((PostedItem)postsListBox.SelectedItem);
                new Thread(bindSelectedItem).Start();
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
                    if (FacebookLogic.IsSelectedItemLikedByUser(m_SelectedItem))
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
                    new Thread(() => addItemsToPostListBox<Post>(selectedFriend.WallPosts)).Start();
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
                    new Thread(() => addItemsToPostListBox<Photo>(selectedAlbum.Photos)).Start();
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
                    new Thread(() => addItemsToPostListBox<Post>(selectedGroup.WallPosts)).Start();
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
                    new Thread(() => addItemsToPostListBox<Post>(selectedGroup.WallPosts)).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem receiving Events.");
                }
            }
        }

        private void darkModeButton_Click(object sender, EventArgs e)
        {
            toggleDarkMode();
        }

        private void likesFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookLogic.setLikesFilterComparison(likesFilterComboBox.SelectedItem as string);
        }

        private void dateFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacebookLogic.setDateFilterComparison(dateFilterComboBox.SelectedItem as string);
        }
    }
}