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
            this.likesFilterComboBox = new System.Windows.Forms.ComboBox();
            this.dateFilterComboBox = new System.Windows.Forms.ComboBox();
            this.filterByLikesGroupBox = new System.Windows.Forms.GroupBox();
            this.filterByDateGroupBox = new System.Windows.Forms.GroupBox();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
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
            this.filterByLikesGroupBox.SuspendLayout();
            this.filterByDateGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.picturePictureBox);
            this.UserGroupBox.Controls.Add(this.userNameLabel);
            this.UserGroupBox.Controls.Add(this.connectionButton);
            this.UserGroupBox.Location = new System.Drawing.Point(11, 11);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(196, 142);
            this.UserGroupBox.TabIndex = 0;
            this.UserGroupBox.TabStop = false;
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BackColor = System.Drawing.Color.SteelBlue;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.ILoggedInUserBindingSource, "PictureURL", true));
            this.picturePictureBox.Location = new System.Drawing.Point(7, 10);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(99, 98);
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
            this.userNameLabel.Location = new System.Drawing.Point(7, 114);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 19);
            this.userNameLabel.TabIndex = 28;
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connectionButton
            // 
            this.connectionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectionButton.Location = new System.Drawing.Point(122, 110);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(64, 23);
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
            this.userCollectionsTabControl.Location = new System.Drawing.Point(12, 218);
            this.userCollectionsTabControl.Name = "userCollectionsTabControl";
            this.userCollectionsTabControl.SelectedIndex = 0;
            this.userCollectionsTabControl.Size = new System.Drawing.Size(214, 265);
            this.userCollectionsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.friendsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(206, 239);
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
            this.friendsListBox.Location = new System.Drawing.Point(0, 0);
            this.friendsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(205, 238);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(206, 239);
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
            this.albumsListBox.Location = new System.Drawing.Point(0, 0);
            this.albumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(208, 238);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(206, 239);
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
            this.groupsListBox.Location = new System.Drawing.Point(0, 0);
            this.groupsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(208, 238);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(206, 239);
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
            this.eventsListBox.Location = new System.Drawing.Point(0, 0);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(208, 238);
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
            this.postsListBox.Location = new System.Drawing.Point(1, 0);
            this.postsListBox.Name = "postsListBox";
            this.postsListBox.Size = new System.Drawing.Size(192, 225);
            this.postsListBox.TabIndex = 3;
            this.postsListBox.SelectedIndexChanged += new System.EventHandler(this.postsListBox_SelectedIndexChanged);
            // 
            // myPostsButton
            // 
            this.myPostsButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myPostsButton.Location = new System.Drawing.Point(353, 218);
            this.myPostsButton.Margin = new System.Windows.Forms.Padding(2);
            this.myPostsButton.Name = "myPostsButton";
            this.myPostsButton.Size = new System.Drawing.Size(87, 25);
            this.myPostsButton.TabIndex = 4;
            this.myPostsButton.Text = "My Posts";
            this.myPostsButton.UseMnemonic = false;
            this.myPostsButton.UseVisualStyleBackColor = true;
            this.myPostsButton.Click += new System.EventHandler(this.myPostsButton_Click);
            // 
            // collectionsItemsTabControl
            // 
            this.collectionsItemsTabControl.Controls.Add(this.tabPage5);
            this.collectionsItemsTabControl.Location = new System.Drawing.Point(240, 240);
            this.collectionsItemsTabControl.Name = "collectionsItemsTabControl";
            this.collectionsItemsTabControl.SelectedIndex = 0;
            this.collectionsItemsTabControl.Size = new System.Drawing.Size(200, 242);
            this.collectionsItemsTabControl.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.postsListBox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(192, 216);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Posts";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // postsDateTimePicker
            // 
            this.postsDateTimePicker.Location = new System.Drawing.Point(71, 18);
            this.postsDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.postsDateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.postsDateTimePicker.Name = "postsDateTimePicker";
            this.postsDateTimePicker.Size = new System.Drawing.Size(119, 20);
            this.postsDateTimePicker.TabIndex = 6;
            // 
            // dateFilterButton
            // 
            this.dateFilterButton.Location = new System.Drawing.Point(5, 42);
            this.dateFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.dateFilterButton.Name = "dateFilterButton";
            this.dateFilterButton.Size = new System.Drawing.Size(184, 22);
            this.dateFilterButton.TabIndex = 7;
            this.dateFilterButton.Text = "Filter posts by date";
            this.dateFilterButton.UseVisualStyleBackColor = true;
            this.dateFilterButton.Click += new System.EventHandler(this.dateFilterButton_Click);
            // 
            // likesNumericUpDown
            // 
            this.likesNumericUpDown.Location = new System.Drawing.Point(74, 20);
            this.likesNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.likesNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.likesNumericUpDown.Name = "likesNumericUpDown";
            this.likesNumericUpDown.Size = new System.Drawing.Size(118, 20);
            this.likesNumericUpDown.TabIndex = 8;
            // 
            // likesFilterButton
            // 
            this.likesFilterButton.Location = new System.Drawing.Point(8, 44);
            this.likesFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.likesFilterButton.Name = "likesFilterButton";
            this.likesFilterButton.Size = new System.Drawing.Size(184, 22);
            this.likesFilterButton.TabIndex = 9;
            this.likesFilterButton.Text = "Filter posts by likes";
            this.likesFilterButton.UseVisualStyleBackColor = true;
            this.likesFilterButton.Click += new System.EventHandler(this.likesFilterButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(7, 197);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(378, 117);
            this.messageTextBox.TabIndex = 14;
            // 
            // pictureURLPictureBox
            // 
            this.pictureURLPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.iSelectedItemBindingSource, "PictureURL", true));
            this.pictureURLPictureBox.Location = new System.Drawing.Point(89, 19);
            this.pictureURLPictureBox.Name = "pictureURLPictureBox";
            this.pictureURLPictureBox.Size = new System.Drawing.Size(193, 165);
            this.pictureURLPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureURLPictureBox.TabIndex = 16;
            this.pictureURLPictureBox.TabStop = false;
            // 
            // likeButton
            // 
            this.likeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.likeButton.Location = new System.Drawing.Point(8, 88);
            this.likeButton.Name = "likeButton";
            this.likeButton.Size = new System.Drawing.Size(75, 34);
            this.likeButton.TabIndex = 6;
            this.likeButton.Text = "Like";
            this.likeButton.UseVisualStyleBackColor = true;
            this.likeButton.Click += new System.EventHandler(this.likeButton_Click);
            // 
            // likesCountLabel
            // 
            this.likesCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "LikesCount", true));
            this.likesCountLabel.Location = new System.Drawing.Point(346, 69);
            this.likesCountLabel.Name = "likesCountLabel";
            this.likesCountLabel.Size = new System.Drawing.Size(38, 23);
            this.likesCountLabel.TabIndex = 12;
            this.likesCountLabel.Text = "label1";
            this.likesCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentButton
            // 
            this.commentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentButton.Location = new System.Drawing.Point(309, 422);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 41);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // likesLabel
            // 
            this.likesLabel.AutoSize = true;
            this.likesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.likesLabel.Location = new System.Drawing.Point(288, 74);
            this.likesLabel.Name = "likesLabel";
            this.likesLabel.Size = new System.Drawing.Size(35, 13);
            this.likesLabel.TabIndex = 9;
            this.likesLabel.Text = "Likes:";
            // 
            // commentsCountLabel
            // 
            this.commentsCountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.iSelectedItemBindingSource, "CommentsCount", true));
            this.commentsCountLabel.Location = new System.Drawing.Point(346, 99);
            this.commentsCountLabel.Name = "commentsCountLabel";
            this.commentsCountLabel.Size = new System.Drawing.Size(38, 23);
            this.commentsCountLabel.TabIndex = 10;
            this.commentsCountLabel.Text = "label1";
            this.commentsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentsLabel.Location = new System.Drawing.Point(288, 104);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(59, 13);
            this.commentsLabel.TabIndex = 11;
            this.commentsLabel.Text = "Comments:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.commentTextBox.Location = new System.Drawing.Point(6, 421);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(298, 41);
            this.commentTextBox.TabIndex = 12;
            // 
            // commentsListBox
            // 
            this.commentsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.commentsListBox.DataSource = this.commentsBindingSource;
            this.commentsListBox.DisplayMember = "Message";
            this.commentsListBox.FormattingEnabled = true;
            this.commentsListBox.Location = new System.Drawing.Point(6, 320);
            this.commentsListBox.Name = "commentsListBox";
            this.commentsListBox.Size = new System.Drawing.Size(379, 95);
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
            this.postsGroupBox.Location = new System.Drawing.Point(472, 13);
            this.postsGroupBox.Name = "postsGroupBox";
            this.postsGroupBox.Size = new System.Drawing.Size(405, 483);
            this.postsGroupBox.TabIndex = 2;
            this.postsGroupBox.TabStop = false;
            // 
            // darkModeButton
            // 
            this.darkModeButton.Location = new System.Drawing.Point(12, 172);
            this.darkModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.darkModeButton.Name = "darkModeButton";
            this.darkModeButton.Size = new System.Drawing.Size(70, 25);
            this.darkModeButton.TabIndex = 10;
            this.darkModeButton.Text = "Dark Mode";
            this.darkModeButton.UseVisualStyleBackColor = true;
            this.darkModeButton.Click += new System.EventHandler(this.darkModeButton_Click);
            // 
            // likesFilterComboBox
            // 
            this.likesFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.likesFilterComboBox.FormattingEnabled = true;
            this.likesFilterComboBox.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this.likesFilterComboBox.Location = new System.Drawing.Point(8, 20);
            this.likesFilterComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.likesFilterComboBox.Name = "likesFilterComboBox";
            this.likesFilterComboBox.Size = new System.Drawing.Size(62, 21);
            this.likesFilterComboBox.TabIndex = 11;
            this.likesFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.likesFilterComboBox_SelectedIndexChanged);
            // 
            // dateFilterComboBox
            // 
            this.dateFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateFilterComboBox.FormattingEnabled = true;
            this.dateFilterComboBox.Items.AddRange(new object[] {
            "<",
            ">",
            "="});
            this.dateFilterComboBox.Location = new System.Drawing.Point(5, 18);
            this.dateFilterComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateFilterComboBox.Name = "dateFilterComboBox";
            this.dateFilterComboBox.Size = new System.Drawing.Size(62, 21);
            this.dateFilterComboBox.TabIndex = 11;
            this.dateFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.dateFilterComboBox_SelectedIndexChanged);
            // 
            // filterByLikesGroupBox
            // 
            this.filterByLikesGroupBox.Controls.Add(this.likesFilterComboBox);
            this.filterByLikesGroupBox.Controls.Add(this.likesNumericUpDown);
            this.filterByLikesGroupBox.Controls.Add(this.likesFilterButton);
            this.filterByLikesGroupBox.Location = new System.Drawing.Point(233, 53);
            this.filterByLikesGroupBox.Name = "filterByLikesGroupBox";
            this.filterByLikesGroupBox.Size = new System.Drawing.Size(200, 78);
            this.filterByLikesGroupBox.TabIndex = 12;
            this.filterByLikesGroupBox.TabStop = false;
            this.filterByLikesGroupBox.Visible = false;
            // 
            // filterByDateGroupBox
            // 
            this.filterByDateGroupBox.Controls.Add(this.dateFilterComboBox);
            this.filterByDateGroupBox.Controls.Add(this.postsDateTimePicker);
            this.filterByDateGroupBox.Controls.Add(this.dateFilterButton);
            this.filterByDateGroupBox.Location = new System.Drawing.Point(233, 137);
            this.filterByDateGroupBox.Name = "filterByDateGroupBox";
            this.filterByDateGroupBox.Size = new System.Drawing.Size(200, 76);
            this.filterByDateGroupBox.TabIndex = 13;
            this.filterByDateGroupBox.TabStop = false;
            this.filterByDateGroupBox.Visible = false;
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DisplayMember = "Name";
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.FormattingEnabled = true;
            this.filterTypeComboBox.Location = new System.Drawing.Point(233, 21);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(207, 21);
            this.filterTypeComboBox.TabIndex = 14;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterTypeComboBox_SelectedIndexChanged);
            // 
            // MainFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(877, 500);
            this.Controls.Add(this.filterTypeComboBox);
            this.Controls.Add(this.filterByDateGroupBox);
            this.Controls.Add(this.filterByLikesGroupBox);
            this.Controls.Add(this.darkModeButton);
            this.Controls.Add(this.collectionsItemsTabControl);
            this.Controls.Add(this.myPostsButton);
            this.Controls.Add(this.postsGroupBox);
            this.Controls.Add(this.userCollectionsTabControl);
            this.Controls.Add(this.UserGroupBox);
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
            this.filterByLikesGroupBox.ResumeLayout(false);
            this.filterByDateGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox likesFilterComboBox;
        private System.Windows.Forms.ComboBox dateFilterComboBox;
        private System.Windows.Forms.GroupBox filterByLikesGroupBox;
        private System.Windows.Forms.GroupBox filterByDateGroupBox;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
    }
}

