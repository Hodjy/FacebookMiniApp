namespace A21_Ex01_Hod_204479745_Matan_312539539
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.UserLabel1 = new System.Windows.Forms.Label();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.FriendsListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AlbumsListBox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.GroupsListBox = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.PostsGroupBox = new System.Windows.Forms.GroupBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.LikesLabel = new System.Windows.Forms.Label();
            this.CommentButton = new System.Windows.Forms.Button();
            this.LikeButton = new System.Windows.Forms.Button();
            this.PostTextBox = new System.Windows.Forms.TextBox();
            this.PostCommentsListBox = new System.Windows.Forms.ListBox();
            this.PostPictureBox = new System.Windows.Forms.PictureBox();
            this.PostsListBox = new System.Windows.Forms.ListBox();
            this.MyPostsButton = new System.Windows.Forms.Button();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.PostsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectionButton);
            this.groupBox1.Controls.Add(this.UserLabel1);
            this.groupBox1.Controls.Add(this.profilePictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information Group";
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(142, 89);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(64, 23);
            this.connectionButton.TabIndex = 2;
            this.connectionButton.Text = "Log in";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // UserLabel1
            // 
            this.UserLabel1.AutoSize = true;
            this.UserLabel1.Location = new System.Drawing.Point(7, 95);
            this.UserLabel1.Name = "UserLabel1";
            this.UserLabel1.Size = new System.Drawing.Size(96, 13);
            this.UserLabel1.TabIndex = 1;
            this.UserLabel1.Text = "Selected Memeber";
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(0, 0);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(140, 88);
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 218);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(212, 264);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FriendsListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(204, 238);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FriendsListBox
            // 
            this.FriendsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.FriendsListBox.DisplayMember = "Name";
            this.FriendsListBox.FormattingEnabled = true;
            this.FriendsListBox.Location = new System.Drawing.Point(0, 0);
            this.FriendsListBox.Name = "FriendsListBox";
            this.FriendsListBox.Size = new System.Drawing.Size(208, 238);
            this.FriendsListBox.TabIndex = 0;
            this.FriendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.AlbumsListBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(204, 238);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Albums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AlbumsListBox
            // 
            this.AlbumsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.AlbumsListBox.DisplayMember = "Name";
            this.AlbumsListBox.FormattingEnabled = true;
            this.AlbumsListBox.Location = new System.Drawing.Point(0, 0);
            this.AlbumsListBox.Name = "AlbumsListBox";
            this.AlbumsListBox.Size = new System.Drawing.Size(208, 238);
            this.AlbumsListBox.TabIndex = 1;
            this.AlbumsListBox.SelectedIndexChanged += new System.EventHandler(this.AlbumsListBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.GroupsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(204, 238);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Groups";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // GroupsListBox
            // 
            this.GroupsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.GroupsListBox.DisplayMember = "Name";
            this.GroupsListBox.FormattingEnabled = true;
            this.GroupsListBox.Location = new System.Drawing.Point(0, 0);
            this.GroupsListBox.Name = "GroupsListBox";
            this.GroupsListBox.Size = new System.Drawing.Size(208, 238);
            this.GroupsListBox.TabIndex = 2;
            this.GroupsListBox.SelectedIndexChanged += new System.EventHandler(this.GroupsListBox_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EventsListBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(204, 238);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Events";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // EventsListBox
            // 
            this.EventsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.EventsListBox.DisplayMember = "Name";
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(0, 0);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(208, 238);
            this.EventsListBox.TabIndex = 2;
            this.EventsListBox.SelectedIndexChanged += new System.EventHandler(this.EventsListBox_SelectedIndexChanged);
            // 
            // PostsGroupBox
            // 
            this.PostsGroupBox.BackColor = System.Drawing.Color.SteelBlue;
            this.PostsGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PostsGroupBox.Controls.Add(this.CommentTextBox);
            this.PostsGroupBox.Controls.Add(this.CommentsLabel);
            this.PostsGroupBox.Controls.Add(this.LikesLabel);
            this.PostsGroupBox.Controls.Add(this.CommentButton);
            this.PostsGroupBox.Controls.Add(this.LikeButton);
            this.PostsGroupBox.Controls.Add(this.PostTextBox);
            this.PostsGroupBox.Controls.Add(this.PostCommentsListBox);
            this.PostsGroupBox.Controls.Add(this.PostPictureBox);
            this.PostsGroupBox.Location = new System.Drawing.Point(472, 13);
            this.PostsGroupBox.Name = "PostsGroupBox";
            this.PostsGroupBox.Size = new System.Drawing.Size(365, 474);
            this.PostsGroupBox.TabIndex = 2;
            this.PostsGroupBox.TabStop = false;
            this.PostsGroupBox.Text = "PostGroup";
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(288, 104);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(59, 13);
            this.CommentsLabel.TabIndex = 11;
            this.CommentsLabel.Text = "Comments:";
            // 
            // LikesLabel
            // 
            this.LikesLabel.AutoSize = true;
            this.LikesLabel.Location = new System.Drawing.Point(288, 74);
            this.LikesLabel.Name = "LikesLabel";
            this.LikesLabel.Size = new System.Drawing.Size(35, 13);
            this.LikesLabel.TabIndex = 9;
            this.LikesLabel.Text = "Likes:";
            // 
            // CommentButton
            // 
            this.CommentButton.Location = new System.Drawing.Point(284, 421);
            this.CommentButton.Name = "CommentButton";
            this.CommentButton.Size = new System.Drawing.Size(75, 41);
            this.CommentButton.TabIndex = 8;
            this.CommentButton.Text = "Comment";
            this.CommentButton.UseVisualStyleBackColor = true;
            this.CommentButton.Click += new System.EventHandler(this.CommentButton_Click);
            // 
            // LikeButton
            // 
            this.LikeButton.Location = new System.Drawing.Point(8, 88);
            this.LikeButton.Name = "LikeButton";
            this.LikeButton.Size = new System.Drawing.Size(75, 34);
            this.LikeButton.TabIndex = 6;
            this.LikeButton.Text = "Like";
            this.LikeButton.UseVisualStyleBackColor = true;
            this.LikeButton.Click += new System.EventHandler(this.LikeButton_Click);
            // 
            // PostTextBox
            // 
            this.PostTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.PostTextBox.Location = new System.Drawing.Point(7, 197);
            this.PostTextBox.Multiline = true;
            this.PostTextBox.Name = "PostTextBox";
            this.PostTextBox.Size = new System.Drawing.Size(352, 117);
            this.PostTextBox.TabIndex = 5;
            // 
            // PostCommentsListBox
            // 
            this.PostCommentsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.PostCommentsListBox.DisplayMember = "Message";
            this.PostCommentsListBox.FormattingEnabled = true;
            this.PostCommentsListBox.Location = new System.Drawing.Point(6, 320);
            this.PostCommentsListBox.Name = "PostCommentsListBox";
            this.PostCommentsListBox.Size = new System.Drawing.Size(353, 95);
            this.PostCommentsListBox.TabIndex = 4;
            // 
            // PostPictureBox
            // 
            this.PostPictureBox.Location = new System.Drawing.Point(89, 19);
            this.PostPictureBox.Name = "PostPictureBox";
            this.PostPictureBox.Size = new System.Drawing.Size(193, 165);
            this.PostPictureBox.TabIndex = 0;
            this.PostPictureBox.TabStop = false;
            // 
            // PostsListBox
            // 
            this.PostsListBox.BackColor = System.Drawing.Color.SlateGray;
            this.PostsListBox.FormattingEnabled = true;
            this.PostsListBox.Location = new System.Drawing.Point(240, 242);
            this.PostsListBox.Name = "PostsListBox";
            this.PostsListBox.Size = new System.Drawing.Size(168, 238);
            this.PostsListBox.TabIndex = 3;
            this.PostsListBox.SelectedIndexChanged += new System.EventHandler(this.PostsListBox_SelectedIndexChanged);
            // 
            // MyPostsButton
            // 
            this.MyPostsButton.Location = new System.Drawing.Point(240, 208);
            this.MyPostsButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyPostsButton.Name = "MyPostsButton";
            this.MyPostsButton.Size = new System.Drawing.Size(74, 27);
            this.MyPostsButton.TabIndex = 4;
            this.MyPostsButton.Text = "My Posts";
            this.MyPostsButton.UseMnemonic = false;
            this.MyPostsButton.UseVisualStyleBackColor = true;
            this.MyPostsButton.Click += new System.EventHandler(this.MyPostsButton_Click);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.BackColor = System.Drawing.Color.SlateGray;
            this.CommentTextBox.Location = new System.Drawing.Point(6, 421);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(276, 41);
            this.CommentTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(847, 497);
            this.Controls.Add(this.MyPostsButton);
            this.Controls.Add(this.PostsListBox);
            this.Controls.Add(this.PostsGroupBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Mini Facebook - User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.PostsGroupBox.ResumeLayout(false);
            this.PostsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PostPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label UserLabel1;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox FriendsListBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox AlbumsListBox;
        private System.Windows.Forms.ListBox GroupsListBox;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.GroupBox PostsGroupBox;
        private System.Windows.Forms.ListBox PostsListBox;
        private System.Windows.Forms.ListBox PostCommentsListBox;
        private System.Windows.Forms.PictureBox PostPictureBox;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.Label LikesLabel;
        private System.Windows.Forms.Button CommentButton;
        private System.Windows.Forms.Button LikeButton;
        private System.Windows.Forms.TextBox PostTextBox;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Button MyPostsButton;
        private System.Windows.Forms.TextBox CommentTextBox;
    }
}

