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
            this.pommentTextBox = new System.Windows.Forms.TextBox();
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
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.picturesListBox = new System.Windows.Forms.ListBox();
            this.postsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateFilterButton = new System.Windows.Forms.Button();
            this.likesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.likesFilterButton = new System.Windows.Forms.Button();
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
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.connectionButton);
            this.UserGroupBox.Controls.Add(this.userLabel);
            this.UserGroupBox.Controls.Add(this.profilePictureBox);
            this.UserGroupBox.Location = new System.Drawing.Point(12, 12);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(212, 126);
            this.UserGroupBox.TabIndex = 0;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Member Information Group";
            // 
            // connectionButton
            // 
            this.connectionButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.connectionButton.Location = new System.Drawing.Point(142, 89);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(64, 23);
            this.connectionButton.TabIndex = 2;
            this.connectionButton.Text = "Log in";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userLabel.Location = new System.Drawing.Point(7, 95);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(96, 13);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Selected Memeber";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(140, 88);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
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
            this.userCollectionsTabControl.Size = new System.Drawing.Size(212, 264);
            this.userCollectionsTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.friendsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(204, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // friendsListBox
            // 
            this.friendsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.friendsListBox.DisplayMember = "Name";
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(0, 0);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(208, 238);
            this.friendsListBox.TabIndex = 0;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.albumsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(204, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // albumsListBox
            // 
            this.albumsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.albumsListBox.DisplayMember = "Name";
            this.albumsListBox.FormattingEnabled = true;
            this.albumsListBox.Location = new System.Drawing.Point(0, 0);
            this.albumsListBox.Name = "albumsListBox";
            this.albumsListBox.Size = new System.Drawing.Size(208, 238);
            this.albumsListBox.TabIndex = 1;
            this.albumsListBox.SelectedIndexChanged += new System.EventHandler(this.albumsListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(204, 238);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupsListBox
            // 
            this.groupsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.groupsListBox.DisplayMember = "Name";
            this.groupsListBox.FormattingEnabled = true;
            this.groupsListBox.Location = new System.Drawing.Point(0, 0);
            this.groupsListBox.Name = "groupsListBox";
            this.groupsListBox.Size = new System.Drawing.Size(208, 238);
            this.groupsListBox.TabIndex = 2;
            this.groupsListBox.SelectedIndexChanged += new System.EventHandler(this.groupsListBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.eventsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(204, 238);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // eventsListBox
            // 
            this.eventsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.eventsListBox.DisplayMember = "Name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(0, 0);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(208, 238);
            this.eventsListBox.TabIndex = 2;
            this.eventsListBox.SelectedIndexChanged += new System.EventHandler(this.eventsListBox_SelectedIndexChanged);
            // 
            // postsGroupBox
            // 
            this.postsGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.postsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.postsGroupBox.Controls.Add(this.pommentTextBox);
            this.postsGroupBox.Controls.Add(this.commentsLabel);
            this.postsGroupBox.Controls.Add(this.likesLabel);
            this.postsGroupBox.Controls.Add(this.commentButton);
            this.postsGroupBox.Controls.Add(this.likeButton);
            this.postsGroupBox.Controls.Add(this.postTextBox);
            this.postsGroupBox.Controls.Add(this.postCommentsListBox);
            this.postsGroupBox.Controls.Add(this.postPictureBox);
            this.postsGroupBox.Location = new System.Drawing.Point(472, 13);
            this.postsGroupBox.Name = "postsGroupBox";
            this.postsGroupBox.Size = new System.Drawing.Size(365, 474);
            this.postsGroupBox.TabIndex = 2;
            this.postsGroupBox.TabStop = false;
            this.postsGroupBox.Text = "PostGroup";
            // 
            // pommentTextBox
            // 
            this.pommentTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.pommentTextBox.Location = new System.Drawing.Point(6, 421);
            this.pommentTextBox.Multiline = true;
            this.pommentTextBox.Name = "pommentTextBox";
            this.pommentTextBox.Size = new System.Drawing.Size(276, 41);
            this.pommentTextBox.TabIndex = 12;
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
            // commentButton
            // 
            this.commentButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.commentButton.Location = new System.Drawing.Point(284, 421);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(75, 41);
            this.commentButton.TabIndex = 8;
            this.commentButton.Text = "Comment";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
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
            // postTextBox
            // 
            this.postTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.postTextBox.Location = new System.Drawing.Point(7, 197);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(352, 117);
            this.postTextBox.TabIndex = 5;
            // 
            // postCommentsListBox
            // 
            this.postCommentsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.postCommentsListBox.DisplayMember = "Message";
            this.postCommentsListBox.FormattingEnabled = true;
            this.postCommentsListBox.Location = new System.Drawing.Point(6, 320);
            this.postCommentsListBox.Name = "postCommentsListBox";
            this.postCommentsListBox.Size = new System.Drawing.Size(353, 95);
            this.postCommentsListBox.TabIndex = 4;
            // 
            // postPictureBox
            // 
            this.postPictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.postPictureBox.Location = new System.Drawing.Point(89, 19);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(193, 165);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.postPictureBox.TabIndex = 0;
            this.postPictureBox.TabStop = false;
            // 
            // postsListBox
            // 
            this.postsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.postsListBox.DisplayMember = "Message";
            this.postsListBox.FormattingEnabled = true;
            this.postsListBox.Location = new System.Drawing.Point(0, 0);
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
            this.collectionsItemsTabControl.Controls.Add(this.tabPage6);
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
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.picturesListBox);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(192, 216);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Pictures";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // picturesListBox
            // 
            this.picturesListBox.BackColor = System.Drawing.Color.SlateGray;
            this.picturesListBox.DisplayMember = "Name";
            this.picturesListBox.FormattingEnabled = true;
            this.picturesListBox.Location = new System.Drawing.Point(0, 0);
            this.picturesListBox.Name = "picturesListBox";
            this.picturesListBox.Size = new System.Drawing.Size(192, 225);
            this.picturesListBox.TabIndex = 6;
            this.picturesListBox.SelectedIndexChanged += new System.EventHandler(this.picturesListBox_SelectedIndexChanged);
            // 
            // postsDateTimePicker
            // 
            this.postsDateTimePicker.Location = new System.Drawing.Point(240, 95);
            this.postsDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.postsDateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.postsDateTimePicker.Name = "postsDateTimePicker";
            this.postsDateTimePicker.Size = new System.Drawing.Size(185, 20);
            this.postsDateTimePicker.TabIndex = 6;
            // 
            // dateFilterButton
            // 
            this.dateFilterButton.Location = new System.Drawing.Point(240, 119);
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
            this.likesNumericUpDown.Location = new System.Drawing.Point(240, 23);
            this.likesNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.likesNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.likesNumericUpDown.Name = "likesNumericUpDown";
            this.likesNumericUpDown.Size = new System.Drawing.Size(184, 20);
            this.likesNumericUpDown.TabIndex = 8;
            // 
            // likesFilterButton
            // 
            this.likesFilterButton.Location = new System.Drawing.Point(240, 47);
            this.likesFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.likesFilterButton.Name = "likesFilterButton";
            this.likesFilterButton.Size = new System.Drawing.Size(184, 22);
            this.likesFilterButton.TabIndex = 9;
            this.likesFilterButton.Text = "Filter posts by likes";
            this.likesFilterButton.UseVisualStyleBackColor = true;
            this.likesFilterButton.Click += new System.EventHandler(this.likesFilterButton_Click);
            // 
            // MainFacebookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1291, 507);
            this.Controls.Add(this.likesFilterButton);
            this.Controls.Add(this.likesNumericUpDown);
            this.Controls.Add(this.dateFilterButton);
            this.Controls.Add(this.postsDateTimePicker);
            this.Controls.Add(this.collectionsItemsTabControl);
            this.Controls.Add(this.myPostsButton);
            this.Controls.Add(this.postsGroupBox);
            this.Controls.Add(this.userCollectionsTabControl);
            this.Controls.Add(this.UserGroupBox);
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
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.likesNumericUpDown)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox pommentTextBox;
        private System.Windows.Forms.TabControl collectionsItemsTabControl;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ListBox picturesListBox;
        private System.Windows.Forms.DateTimePicker postsDateTimePicker;
        private System.Windows.Forms.Button dateFilterButton;
        private System.Windows.Forms.NumericUpDown likesNumericUpDown;
        private System.Windows.Forms.Button likesFilterButton;
    }
}

