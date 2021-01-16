namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    partial class MainFacebookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.ILoggedInUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameLabel = new System.Windows.Forms.Label();
            this.connectionButton = new System.Windows.Forms.Button();
            this.userCollectionsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSelectedItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.myPostsButton = new System.Windows.Forms.Button();
            this.collectionsItemsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.postsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFilterButton = new System.Windows.Forms.Button();
            this.likesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.likesFilterButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            this.likeButton = new System.Windows.Forms.Button();
            this.likesCountLabel = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            this.likesLabel = new System.Windows.Forms.Label();
            this.commentsCountLabel = new System.Windows.Forms.Label();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentsListBox = new System.Windows.Forms.ListBox();
            this.postsGroupBox = new System.Windows.Forms.GroupBox();
            this.darkModeButton = new System.Windows.Forms.Button();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ILoggedInUserBindingSource)).BeginInit();
            this.userCollectionsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSelectedItemBindingSource)).BeginInit();
            this.collectionsItemsTabControl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.postsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.picturePictureBox);
            this.UserGroupBox.Controls.Add(this.userNameLabel);
            this.UserGroupBox.Controls.Add(this.connectionButton);
            this.UserGroupBox.Location = new System.Drawing.Point(15, 14);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserGroupBox.Size = new System.Drawing.Size(261, 175);
            this.UserGroupBox.TabIndex = 0;
            this.UserGroupBox.TabStop = false;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.ILoggedInUserBindingSource, "PictureURL", true));
            this.picturePictureBox.Location = new System.Drawing.Point(9, 12);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(132, 121);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 27;
            this.picturePictureBox.TabStop = false;
            // 
            // ILoggedInUserBindingSource
            // 
            this.ILoggedInUserBindingSource.DataSource = typeof(A21_Ex01_Hod_204479745_Matan_312539539.ILoggedInUser);
            // 
            // userNameLabel
            // 
            this.userNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ILoggedInUserBindingSource, "Name", true));
            this.userNameLabel.Location = new System.Drawing.Point(9, 140);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(127, 23);
            this.userNameLabel.TabIndex = 28;
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectionButton
            // 
            this.connectionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectionButton.Location = new System.Drawing.Point(163, 135);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(85, 28);
            this.connectionButton.TabIndex = 2;
            this.connectionButton.Text = "Log in";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // userCollectionsTabControl
            // 
            this.userCollectionsTabControl.Controls.Add(this.tabPage1);
            this.userCollectionsTabControl.Controls.Add(this.tabPage2);
            this.userCollectionsTabControl.Controls.Add(this.tabPage3);
            this.userCollectionsTabControl.Controls.Add(this.tabPage4);
            this.userCollectionsTabControl.Location = new System.Drawing.Point(16, 268);
            this.userCollectionsTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userCollectionsTabControl.Name = "userCollectionsTabControl";
            this.userCollectionsTabControl.SelectedIndex = 0;
            this.userCollectionsTabControl.Size = new System.Drawing.Size(285, 326);
            this.userCollectionsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.friendsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(277, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.friendsListBox.DataSource = this.friendsBindingSource;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(0, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(272, 292);
            this.friendsListBox.TabIndex = 16;
            this.friendsListBox.ValueMember = "About";
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendListListBox_SelectedIndexChanged);
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.ILoggedInUserBindingSource;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.albumsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(277, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // albumsListBox
            // 
            this.albumsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.albumsListBox.DataSource = this.albumsBindingSource;
            this.albumsListBox.DisplayMember = "Name";
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 16;
            this.albumsListBox.Location = new System.Drawing.Point(0, 0);
            this.albumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(276, 292);
            this.albumsListBox.TabIndex = 25;
            this.albumsListBox.ValueMember = "Id";
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.ILoggedInUserBindingSource;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(277, 297);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupsListBox
            // 
            this.groupsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.groupsListBox.DataSource = this.groupsBindingSource;
            this.groupsListBox.DisplayMember = "Name";
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 16;
            this.groupsListBox.Location = new System.Drawing.Point(0, 0);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(276, 292);
            this.groupsListBox.TabIndex = 25;
            this.groupsListBox.ValueMember = "Id";
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.ILoggedInUserBindingSource;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.eventsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(277, 297);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // eventsListBox
            // 
            this.eventsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.eventsListBox.DataSource = this.eventsBindingSource;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(0, 0);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(276, 292);
            this.eventsListBox.TabIndex = 25;
            this.eventsListBox.ValueMember = "Id";
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "Events";
            this.eventsBindingSource.DataSource = this.ILoggedInUserBindingSource;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.iSelectedItemBindingSource;
            // 
            // iSelectedItemBindingSource
            // 
            this.iSelectedItemBindingSource.DataSource = typeof(A21_Ex01_Hod_204479745_Matan_312539539.ISelectedItem);
            // 
            // postsListBox
            // 
            this.postsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.postsListBox.DisplayMember = "Name";
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 16;
            this.postsListBox.Location = new System.Drawing.Point(1, 0);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(255, 276);
            this.postsListBox.TabIndex = 3;
            this.postsListBox.SelectedIndexChanged += new System.EventHandler(this.postsListBox_SelectedIndexChanged);
            // 
            // myPostsButton
            // 
            this.myPostsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myPostsButton.Location = new System.Drawing.Point(471, 268);
            this.myPostsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myPostsButton.Name = "myPostsButton";
            this.myPostsButton.Size = new System.Drawing.Size(116, 31);
            this.myPostsButton.TabIndex = 4;
            this.myPostsButton.Text = "My Posts";
            this.myPostsButton.UseMnemonic = false;
            this.myPostsButton.UseVisualStyleBackColor = true;
            this.myPostsButton.Click += new System.EventHandler(this.myPostsButton_Click);
            // 
            // collectionsItemsTabControl
            // 
            this.collectionsItemsTabControl.Controls.Add(this.tabPage5);
            this.collectionsItemsTabControl.Location = new System.Drawing.Point(320, 295);
            this.collectionsItemsTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.collectionsItemsTabControl.Name = "collectionsItemsTabControl";
            this.collectionsItemsTabControl.SelectedIndex = 0;
            this.collectionsItemsTabControl.Size = new System.Drawing.Size(267, 298);
            this.collectionsItemsTabControl.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.postsListBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(259, 269);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Posts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // postsDateTimePicker
            // 
            this.postsDateTimePicker.Location = new System.Drawing.Point(320, 117);
            this.postsDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.postsDateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.postsDateTimePicker.Name = "postsDateTimePicker";
            this.postsDateTimePicker.Size = new System.Drawing.Size(245, 22);
            this.postsDateTimePicker.TabIndex = 6;
            // 
            // dateFilterButton
            // 
            this.dateFilterButton.Location = new System.Drawing.Point(320, 146);
            this.dateFilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateFilterButton.Name = "dateFilterButton";
            this.dateFilterButton.Size = new System.Drawing.Size(245, 27);
            this.dateFilterButton.TabIndex = 7;
            this.dateFilterButton.Text = "Filter posts by date";
            this.dateFilterButton.UseVisualStyleBackColor = true;
            this.dateFilterButton.Click += new System.EventHandler(this.dateFilterButton_Click);
            // 
            // likesNumericUpDown
            // 
            this.likesNumericUpDown.Location = new System.Drawing.Point(320, 28);
            this.likesNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likesNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.likesNumericUpDown.Name = "likesNumericUpDown";
            this.likesNumericUpDown.Size = new System.Drawing.Size(245, 22);
            this.likesNumericUpDown.TabIndex = 8;
            // 
            // likesFilterButton
            // 
            this.likesFilterButton.Location = new System.Drawing.Point(320, 58);
            this.likesFilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.likesFilterButton.Name = "likesFilterButton";
            this.likesFilterButton.Size = new System.Drawing.Size(245, 27);
            this.likesFilterButton.TabIndex = 9;
            this.likesFilterButton.Text = "Filter posts by likes";
            this.likesFilterButton.UseVisualStyleBackColor = true;
            this.likesFilterButton.Click += new System.EventHandler(this.likesFilterButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(9, 242);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(503, 143);
            this.messageTextBox.TabIndex = 14;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.iSelectedItemBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(119, 23);
            this.pictureURLPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(257, 203);
            this.pictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureURLPictureBox.TabIndex = 16;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // likeButton
            // 
            this.likeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.likeButton.Location = new System.Drawing.Point(11, 108);
            this.likeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(100, 42);
            this.likeButton.TabIndex = 6;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // likesCountLabel
            // 
            this.likesCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "LikesCount", true));
            this.likesCountLabel.Location = new System.Drawing.Point(461, 85);
            this.likesCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likesCountLabel.Name = "likesCountLabel";
            this.likesCountLabel.Size = new System.Drawing.Size(51, 28);
            this.likesCountLabel.TabIndex = 12;
            this.likesCountLabel.Text = "label1";
            this.likesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentButton
            // 
            this.commentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentButton.Location = new System.Drawing.Point(412, 519);
            this.commentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(100, 50);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // likesLabel
            // 
            this.likesLabel.AutoSize = true;
            this.likesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.likesLabel.Location = new System.Drawing.Point(384, 91);
            this.likesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(45, 17);
            this.likesLabel.TabIndex = 9;
            this.likesLabel.Text = "Likes:";
            // 
            // commentsCountLabel
            // 
            this.commentsCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "CommentsCount", true));
            this.commentsCountLabel.Location = new System.Drawing.Point(461, 122);
            this.commentsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsCountLabel.Name = "commentsCountLabel";
            this.commentsCountLabel.Size = new System.Drawing.Size(51, 28);
            this.commentsCountLabel.TabIndex = 10;
            this.commentsCountLabel.Text = "label1";
            this.commentsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentsLabel.Location = new System.Drawing.Point(384, 128);
            this.commentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(78, 17);
            this.commentsLabel.TabIndex = 11;
            this.commentsLabel.Text = "Comments:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.commentTextBox.Location = new System.Drawing.Point(8, 518);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(396, 50);
            this.commentTextBox.TabIndex = 12;
            // 
            // commentsListBox
            // 
            this.commentsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.commentsListBox.DataSource = this.commentsBindingSource;
            this.commentsListBox.DisplayMember = "Message";
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.ItemHeight = 16;
            this.commentsListBox.Location = new System.Drawing.Point(8, 394);
            this.commentsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(504, 116);
            this.commentsListBox.TabIndex = 16;
            this.commentsListBox.ValueMember = "Comments";
            // 
            // postsGroupBox
            // 
            this.postsGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.postsGroupBox.Controls.Add(this.commentsListBox);
            this.postsGroupBox.Controls.Add(this.commentTextBox);
            this.postsGroupBox.Controls.Add(this.commentsLabel);
            this.postsGroupBox.Controls.Add(this.commentsCountLabel);
            this.postsGroupBox.Controls.Add(this.likesLabel);
            this.postsGroupBox.Controls.Add(this.commentButton);
            this.postsGroupBox.Controls.Add(this.likesCountLabel);
            this.postsGroupBox.Controls.Add(this.likeButton);
            this.postsGroupBox.Controls.Add(this.pictureURLPictureBox);
            this.postsGroupBox.Controls.Add(this.messageTextBox);
            this.postsGroupBox.Location = new System.Drawing.Point(629, 16);
            this.postsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postsGroupBox.Name = "postsGroupBox";
            this.postsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postsGroupBox.Size = new System.Drawing.Size(540, 594);
            this.postsGroupBox.TabIndex = 2;
            this.postsGroupBox.TabStop = false;
            // 
            // darkModeButton
            // 
            this.darkModeButton.Location = new System.Drawing.Point(65, 219);
            this.darkModeButton.Name = "darkModeButton";
            this.darkModeButton.Size = new System.Drawing.Size(132, 23);
            this.darkModeButton.TabIndex = 10;
            this.darkModeButton.Text = "Dark Mode";
            this.darkModeButton.UseVisualStyleBackColor = true;
            this.darkModeButton.Click += new System.EventHandler(this.darkModeButton_Click);
            // 
            // MainFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1169, 615);
            this.Controls.Add(this.darkModeButton);
            this.Controls.Add(this.likesFilterButton);
            this.Controls.Add(this.likesNumericUpDown);
            this.Controls.Add(this.dateFilterButton);
            this.Controls.Add(this.postsDateTimePicker);
            this.Controls.Add(this.collectionsItemsTabControl);
            this.Controls.Add(this.myPostsButton);
            this.Controls.Add(this.postsGroupBox);
            this.Controls.Add(this.userCollectionsTabControl);
            this.Controls.Add(this.UserGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainFacebookForm";
            this.Text = "Mini Facebook - User";
            this.Load += new System.EventHandler(this.Form_Load);
            this.UserGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ILoggedInUserBindingSource)).EndInit();
            this.userCollectionsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSelectedItemBindingSource)).EndInit();
            this.collectionsItemsTabControl.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.postsGroupBox.ResumeLayout(false);
            this.postsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.TabControl userCollectionsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Button myPostsButton;
        private System.Windows.Forms.TabControl collectionsItemsTabControl;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DateTimePicker postsDateTimePicker;
        private System.Windows.Forms.Button dateFilterButton;
        private System.Windows.Forms.NumericUpDown likesNumericUpDown;
        private System.Windows.Forms.Button likesFilterButton;
        private System.Windows.Forms.BindingSource ILoggedInUserBindingSource;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private System.Windows.Forms.BindingSource iSelectedItemBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.Label likesCountLabel;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Label likesLabel;
        private System.Windows.Forms.Label commentsCountLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ListBox commentsListBox;
        private System.Windows.Forms.GroupBox postsGroupBox;
        private System.Windows.Forms.Button darkModeButton;
    }
}

