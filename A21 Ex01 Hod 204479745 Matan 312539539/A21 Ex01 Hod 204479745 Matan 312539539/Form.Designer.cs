﻿namespace A21_Ex01_Hod_204479745_Matan_312539539
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
            System.Windows.Forms.Label commentsCountLabel;
            System.Windows.Forms.Label likedByCountLabel;
            System.Windows.Forms.Label postMessageLabel;
            System.Windows.Forms.Label pictureURLLabel;
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.userLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.userCollectionsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.albumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupsListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.postsGroupBox = new System.Windows.Forms.GroupBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.likesLabel = new System.Windows.Forms.Label();
            this.commentButton = new System.Windows.Forms.Button();
            this.likeButton = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postCommentsListBox = new System.Windows.Forms.ListBox();
            this.postPictureBox = new System.Windows.Forms.PictureBox();
            this.postsListBox = new System.Windows.Forms.ListBox();
            this.myPostsButton = new System.Windows.Forms.Button();
            this.collectionsItemsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.postsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFilterButton = new System.Windows.Forms.Button();
            this.likesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.likesFilterButton = new System.Windows.Forms.Button();
            this.commentsCountTextBox = new System.Windows.Forms.TextBox();
            this.likedByCountTextBox = new System.Windows.Forms.TextBox();
            this.postMessageTextBox = new System.Windows.Forms.TextBox();
            this.pictureURLPictureBox = new System.Windows.Forms.PictureBox();
            commentsCountLabel = new System.Windows.Forms.Label();
            likedByCountLabel = new System.Windows.Forms.Label();
            postMessageLabel = new System.Windows.Forms.Label();
            pictureURLLabel = new System.Windows.Forms.Label();
            this.UserGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.userCollectionsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.postsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            this.collectionsItemsTabControl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsCountLabel
            // 
            commentsCountLabel.AutoSize = true;
            commentsCountLabel.Location = new System.Drawing.Point(1248, 432);
            commentsCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            commentsCountLabel.Name = "commentsCountLabel";
            commentsCountLabel.Size = new System.Drawing.Size(78, 17);
            commentsCountLabel.TabIndex = 10;
            commentsCountLabel.Text = "Comments:";
            // 
            // likedByCountLabel
            // 
            likedByCountLabel.AutoSize = true;
            likedByCountLabel.Location = new System.Drawing.Point(1508, 432);
            likedByCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            likedByCountLabel.Name = "likedByCountLabel";
            likedByCountLabel.Size = new System.Drawing.Size(45, 17);
            likedByCountLabel.TabIndex = 12;
            likedByCountLabel.Text = "Likes:";
            // 
            // postMessageLabel
            // 
            postMessageLabel.AutoSize = true;
            postMessageLabel.Location = new System.Drawing.Point(1124, 368);
            postMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            postMessageLabel.Name = "postMessageLabel";
            postMessageLabel.Size = new System.Drawing.Size(101, 17);
            postMessageLabel.TabIndex = 14;
            postMessageLabel.Text = "Post Message:";
            // 
            // pictureURLLabel
            // 
            pictureURLLabel.AutoSize = true;
            pictureURLLabel.Location = new System.Drawing.Point(1236, 107);
            pictureURLLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pictureURLLabel.Name = "pictureURLLabel";
            pictureURLLabel.Size = new System.Drawing.Size(88, 17);
            pictureURLLabel.TabIndex = 16;
            pictureURLLabel.Text = "Picture URL:";
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.connectionButton);
            this.UserGroupBox.Controls.Add(this.userLabel);
            this.UserGroupBox.Controls.Add(this.profilePictureBox);
            this.UserGroupBox.Location = new System.Drawing.Point(16, 15);
            this.UserGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.UserGroupBox.Size = new System.Drawing.Size(283, 155);
            this.UserGroupBox.TabIndex = 0;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Member Information Group";
            // 
            // connectionButton
            // 
            this.connectionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectionButton.Location = new System.Drawing.Point(189, 110);
            this.connectionButton.Margin = new System.Windows.Forms.Padding(4);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(85, 28);
            this.connectionButton.TabIndex = 2;
            this.connectionButton.Text = "Log in";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userLabel.Location = new System.Drawing.Point(9, 117);
            this.userLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(126, 17);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Selected Memeber";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(187, 108);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // userCollectionsTabControl
            // 
            this.userCollectionsTabControl.Controls.Add(this.tabPage1);
            this.userCollectionsTabControl.Controls.Add(this.tabPage2);
            this.userCollectionsTabControl.Controls.Add(this.tabPage3);
            this.userCollectionsTabControl.Controls.Add(this.tabPage4);
            this.userCollectionsTabControl.Location = new System.Drawing.Point(16, 268);
            this.userCollectionsTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.userCollectionsTabControl.Name = "userCollectionsTabControl";
            this.userCollectionsTabControl.SelectedIndex = 0;
            this.userCollectionsTabControl.Size = new System.Drawing.Size(283, 325);
            this.userCollectionsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.friendsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(275, 296);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 16;
            this.friendsListBox.Location = new System.Drawing.Point(0, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(276, 292);
            this.friendsListBox.TabIndex = 0;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.albumsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(275, 296);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // albumsListBox
            // 
            this.albumsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.albumsListBox.DisplayMember = "Name";
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.ItemHeight = 16;
            this.albumsListBox.Location = new System.Drawing.Point(0, 0);
            this.albumsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(276, 292);
            this.albumsListBox.TabIndex = 1;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(275, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupsListBox
            // 
            this.groupsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.groupsListBox.DisplayMember = "Name";
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.ItemHeight = 16;
            this.groupsListBox.Location = new System.Drawing.Point(0, 0);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(276, 292);
            this.groupsListBox.TabIndex = 2;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.eventsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(275, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // eventsListBox
            // 
            this.eventsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 16;
            this.eventsListBox.Location = new System.Drawing.Point(0, 0);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(276, 292);
            this.eventsListBox.TabIndex = 2;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // postsGroupBox
            // 
            this.postsGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.postsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.postsGroupBox.Controls.Add(this.commentTextBox);
            this.postsGroupBox.Controls.Add(this.commentsLabel);
            this.postsGroupBox.Controls.Add(this.likesLabel);
            this.postsGroupBox.Controls.Add(this.commentButton);
            this.postsGroupBox.Controls.Add(this.likeButton);
            this.postsGroupBox.Controls.Add(this.postTextBox);
            this.postsGroupBox.Controls.Add(this.postCommentsListBox);
            this.postsGroupBox.Controls.Add(this.postPictureBox);
            this.postsGroupBox.Location = new System.Drawing.Point(629, 16);
            this.postsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.postsGroupBox.Name = "postsGroupBox";
            this.postsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.postsGroupBox.Size = new System.Drawing.Size(487, 583);
            this.postsGroupBox.TabIndex = 2;
            this.postsGroupBox.TabStop = false;
            this.postsGroupBox.Text = "PostGroup";
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.commentTextBox.Location = new System.Drawing.Point(8, 518);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(367, 50);
            this.commentTextBox.TabIndex = 12;
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
            // commentButton
            // 
            this.commentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentButton.Location = new System.Drawing.Point(379, 518);
            this.commentButton.Margin = new System.Windows.Forms.Padding(4);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(100, 50);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // likeButton
            // 
            this.likeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.likeButton.Location = new System.Drawing.Point(11, 108);
            this.likeButton.Margin = new System.Windows.Forms.Padding(4);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(100, 42);
            this.likeButton.TabIndex = 6;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.postTextBox.Location = new System.Drawing.Point(9, 242);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(468, 143);
            this.postTextBox.TabIndex = 5;
            // 
            // postCommentsListBox
            // 
            this.postCommentsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.postCommentsListBox.DisplayMember = "Message";
            this.postCommentsListBox.FormattingEnabled = true;
            this.postCommentsListBox.ItemHeight = 16;
            this.postCommentsListBox.Location = new System.Drawing.Point(8, 394);
            this.postCommentsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.postCommentsListBox.Name = "postCommentsListBox";
            this.postCommentsListBox.Size = new System.Drawing.Size(469, 116);
            this.postCommentsListBox.TabIndex = 4;
            // 
            // postPictureBox
            // 
            this.postPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.postPictureBox.Location = new System.Drawing.Point(119, 23);
            this.postPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(257, 203);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postPictureBox.TabIndex = 0;
            this.postPictureBox.TabStop = false;
            // 
            // postsListBox
            // 
            this.postsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.postsListBox.DisplayMember = "Message";
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.ItemHeight = 16;
            this.postsListBox.Location = new System.Drawing.Point(0, 0);
            this.postsListBox.Margin = new System.Windows.Forms.Padding(4);
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
            this.collectionsItemsTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.collectionsItemsTabControl.Name = "collectionsItemsTabControl";
            this.collectionsItemsTabControl.SelectedIndex = 0;
            this.collectionsItemsTabControl.Size = new System.Drawing.Size(267, 298);
            this.collectionsItemsTabControl.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.postsListBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
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
            // commentsCountTextBox
            // 
            this.commentsCountTextBox.Location = new System.Drawing.Point(1335, 428);
            this.commentsCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.commentsCountTextBox.Name = "commentsCountTextBox";
            this.commentsCountTextBox.Size = new System.Drawing.Size(55, 22);
            this.commentsCountTextBox.TabIndex = 11;
            // 
            // likedByCountTextBox
            // 
            this.likedByCountTextBox.Location = new System.Drawing.Point(1563, 428);
            this.likedByCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.likedByCountTextBox.Name = "likedByCountTextBox";
            this.likedByCountTextBox.Size = new System.Drawing.Size(55, 22);
            this.likedByCountTextBox.TabIndex = 13;
            // 
            // postMessageTextBox
            // 
            this.postMessageTextBox.Location = new System.Drawing.Point(1252, 364);
            this.postMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.postMessageTextBox.Multiline = true;
            this.postMessageTextBox.Name = "postMessageTextBox";
            this.postMessageTextBox.Size = new System.Drawing.Size(365, 56);
            this.postMessageTextBox.TabIndex = 15;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.Location = new System.Drawing.Point(1335, 107);
            this.pictureURLPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(208, 134);
            this.pictureURLPictureBox.TabIndex = 17;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // MainFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1721, 624);
            this.Controls.Add(pictureURLLabel);
            this.Controls.Add(this.pictureURLPictureBox);
            this.Controls.Add(commentsCountLabel);
            this.Controls.Add(this.commentsCountTextBox);
            this.Controls.Add(likedByCountLabel);
            this.Controls.Add(this.likedByCountTextBox);
            this.Controls.Add(postMessageLabel);
            this.Controls.Add(this.postMessageTextBox);
            this.Controls.Add(this.likesFilterButton);
            this.Controls.Add(this.likesNumericUpDown);
            this.Controls.Add(this.dateFilterButton);
            this.Controls.Add(this.postsDateTimePicker);
            this.Controls.Add(this.collectionsItemsTabControl);
            this.Controls.Add(this.myPostsButton);
            this.Controls.Add(this.postsGroupBox);
            this.Controls.Add(this.userCollectionsTabControl);
            this.Controls.Add(this.UserGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFacebookForm";
            this.Text = "Mini Facebook - User";
            this.Load += new System.EventHandler(this.Form_Load);
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.userCollectionsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.postsGroupBox.ResumeLayout(false);
            this.postsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            this.collectionsItemsTabControl.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureURLPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TabControl userCollectionsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox albumsListBox;
        private System.Windows.Forms.ListBox groupsListBox;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.GroupBox postsGroupBox;
        private System.Windows.Forms.ListBox postsListBox;
        private System.Windows.Forms.ListBox postCommentsListBox;
        private System.Windows.Forms.PictureBox postPictureBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.Label likesLabel;
        private System.Windows.Forms.Button commentButton;
        private System.Windows.Forms.Button likeButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Button myPostsButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TabControl collectionsItemsTabControl;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DateTimePicker postsDateTimePicker;
        private System.Windows.Forms.Button dateFilterButton;
        private System.Windows.Forms.NumericUpDown likesNumericUpDown;
        private System.Windows.Forms.Button likesFilterButton;
        private System.Windows.Forms.TextBox commentsCountTextBox;
        private System.Windows.Forms.TextBox likedByCountTextBox;
        private System.Windows.Forms.TextBox postMessageTextBox;
        private System.Windows.Forms.PictureBox pictureURLPictureBox;
    }
}
