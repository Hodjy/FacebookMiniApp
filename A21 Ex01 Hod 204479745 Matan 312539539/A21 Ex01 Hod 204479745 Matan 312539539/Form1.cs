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
                    Text = string.Format("Logged in as {0}", m_CurrentConnection.LoggedInUser.Name);
                    connectionButton.Text = "Log Out";
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
            fetchWallPosts();
            fetchAlbums();
            fetchGroups();
            fetchEvents();
        }

        private void fetchWallPosts()
        {
            foreach (Post wallPost in m_CurrentConnection.LoggedInUser.WallPosts)
            {
                if (wallPost.Caption != null)
                {
                    TimelineListBox.Items.Add(wallPost.Caption);
                }
                else
                {
                    TimelineListBox.Items.Add(string.Format("[{0}]", wallPost.Type));
                }
            }

            if (m_CurrentConnection.LoggedInUser.WallPosts.Count == 0)
            {
                MessageBox.Show(string.Format("{0} has no wall posts", m_CurrentConnection.LoggedInUser.Name));
            }
        }

        private void fetchAlbums()
        {
            AlbumsListBox.DisplayMember = "Name";
            foreach (Album album in m_CurrentConnection.LoggedInUser.Albums)
            {
                AlbumsListBox.Items.Add(album);
            }

            if (m_CurrentConnection.LoggedInUser.Albums.Count == 0)
            {
                MessageBox.Show(string.Format("{0} has no albums", m_CurrentConnection.LoggedInUser.Name));
            }
        }

        private void fetchGroups()
        {
            GroupsListBox.DisplayMember = "Name";
            foreach (Group group in m_CurrentConnection.LoggedInUser.Groups)
            {
                GroupsListBox.Items.Add(group);
            }

            if (m_CurrentConnection.LoggedInUser.Groups.Count == 0)
            {
                MessageBox.Show(string.Format("{0} has no groups", m_CurrentConnection.LoggedInUser.Name));
            }
        }

        private void fetchEvents()
        {
            EventsListBox.DisplayMember = "Name";
            foreach (Event evnt in m_CurrentConnection.LoggedInUser.Events)
            {
                EventsListBox.Items.Add(evnt);
            }

            if (m_CurrentConnection.LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show(string.Format("{0} has no events", m_CurrentConnection.LoggedInUser.Name));
            }
        }

    }
}