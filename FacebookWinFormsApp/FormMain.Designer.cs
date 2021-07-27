using System;

namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.m_LoggedInLabel = new System.Windows.Forms.Label();
            this.m_UserNameLabel = new System.Windows.Forms.Label();
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.m_TrendingPostLabel = new System.Windows.Forms.Label();
            this.m_UpcomingBirthdayLabel = new System.Windows.Forms.Label();
            this.m_TrendingPostListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingEventsLabel = new System.Windows.Forms.Label();
            this.m_UpcomingEventsListBox = new System.Windows.Forms.ListBox();
            this.m_RandomPhotoLabel = new System.Windows.Forms.Label();
            this.m_RandomPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(13, 18);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 42);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1151, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(99, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Visible = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(432, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(21, 8);
            this.chromiumWebBrowser1.TabIndex = 54;
            // 
            // m_LoggedInLabel
            // 
            this.m_LoggedInLabel.AutoSize = true;
            this.m_LoggedInLabel.Location = new System.Drawing.Point(21, 65);
            this.m_LoggedInLabel.Name = "m_LoggedInLabel";
            this.m_LoggedInLabel.Size = new System.Drawing.Size(104, 20);
            this.m_LoggedInLabel.TabIndex = 55;
            this.m_LoggedInLabel.Text = "Logged in as ";
            this.m_LoggedInLabel.Visible = false;
            this.m_LoggedInLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // m_UserNameLabel
            // 
            this.m_UserNameLabel.AutoSize = true;
            this.m_UserNameLabel.Location = new System.Drawing.Point(117, 65);
            this.m_UserNameLabel.Name = "m_UserNameLabel";
            this.m_UserNameLabel.Size = new System.Drawing.Size(89, 20);
            this.m_UserNameLabel.TabIndex = 56;
            this.m_UserNameLabel.Text = "user_name";
            this.m_UserNameLabel.Visible = false;
            this.m_UserNameLabel.Click += new System.EventHandler(this.m_UserName_Click);
            // 
            // m_ProfilePicture
            // 
            this.m_ProfilePicture.Location = new System.Drawing.Point(1057, 10);
            this.m_ProfilePicture.Name = "m_ProfilePicture";
            this.m_ProfilePicture.Size = new System.Drawing.Size(57, 50);
            this.m_ProfilePicture.TabIndex = 57;
            this.m_ProfilePicture.TabStop = false;
            this.m_ProfilePicture.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 74);
            this.button1.TabIndex = 58;
            this.button1.Text = "Upcoming Concerts";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(613, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 74);
            this.button2.TabIndex = 59;
            this.button2.Text = "Common Interest Friends";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // m_TrendingPostLabel
            // 
            this.m_TrendingPostLabel.AutoSize = true;
            this.m_TrendingPostLabel.Location = new System.Drawing.Point(203, 226);
            this.m_TrendingPostLabel.Name = "m_TrendingPostLabel";
            this.m_TrendingPostLabel.Size = new System.Drawing.Size(129, 20);
            this.m_TrendingPostLabel.TabIndex = 60;
            this.m_TrendingPostLabel.Text = "#1 Trending Post";
            this.m_TrendingPostLabel.Visible = false;
            this.m_TrendingPostLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // m_UpcomingBirthdayLabel
            // 
            this.m_UpcomingBirthdayLabel.AutoSize = true;
            this.m_UpcomingBirthdayLabel.Location = new System.Drawing.Point(819, 226);
            this.m_UpcomingBirthdayLabel.Name = "m_UpcomingBirthdayLabel";
            this.m_UpcomingBirthdayLabel.Size = new System.Drawing.Size(151, 20);
            this.m_UpcomingBirthdayLabel.TabIndex = 61;
            this.m_UpcomingBirthdayLabel.Text = "Upcoming Birthdays";
            this.m_UpcomingBirthdayLabel.Visible = false;
            // 
            // m_TrendingPostListBox
            // 
            this.m_TrendingPostListBox.FormattingEnabled = true;
            this.m_TrendingPostListBox.ItemHeight = 20;
            this.m_TrendingPostListBox.Location = new System.Drawing.Point(162, 268);
            this.m_TrendingPostListBox.Name = "m_TrendingPostListBox";
            this.m_TrendingPostListBox.Size = new System.Drawing.Size(257, 284);
            this.m_TrendingPostListBox.TabIndex = 62;
            this.m_TrendingPostListBox.Visible = false;
            // 
            // m_UpcomingBirthdaysListBox
            // 
            this.m_UpcomingBirthdaysListBox.FormattingEnabled = true;
            this.m_UpcomingBirthdaysListBox.ItemHeight = 20;
            this.m_UpcomingBirthdaysListBox.Location = new System.Drawing.Point(777, 268);
            this.m_UpcomingBirthdaysListBox.Name = "m_UpcomingBirthdaysListBox";
            this.m_UpcomingBirthdaysListBox.Size = new System.Drawing.Size(257, 284);
            this.m_UpcomingBirthdaysListBox.TabIndex = 63;
            this.m_UpcomingBirthdaysListBox.Visible = false;
            this.m_UpcomingBirthdaysListBox.SelectedIndexChanged += new System.EventHandler(this.m_UpcomingBirthdaysListBox_SelectedIndexChanged);
            // 
            // m_UpcomingEventsLabel
            // 
            this.m_UpcomingEventsLabel.AutoSize = true;
            this.m_UpcomingEventsLabel.Location = new System.Drawing.Point(203, 644);
            this.m_UpcomingEventsLabel.Name = "m_UpcomingEventsLabel";
            this.m_UpcomingEventsLabel.Size = new System.Drawing.Size(134, 20);
            this.m_UpcomingEventsLabel.TabIndex = 64;
            this.m_UpcomingEventsLabel.Text = "Upcoming Events";
            this.m_UpcomingEventsLabel.Visible = false;
            // 
            // m_UpcomingEventsListBox
            // 
            this.m_UpcomingEventsListBox.FormattingEnabled = true;
            this.m_UpcomingEventsListBox.ItemHeight = 20;
            this.m_UpcomingEventsListBox.Location = new System.Drawing.Point(162, 687);
            this.m_UpcomingEventsListBox.Name = "m_UpcomingEventsListBox";
            this.m_UpcomingEventsListBox.Size = new System.Drawing.Size(257, 284);
            this.m_UpcomingEventsListBox.TabIndex = 65;
            this.m_UpcomingEventsListBox.Visible = false;
            // 
            // m_RandomPhotoLabel
            // 
            this.m_RandomPhotoLabel.AutoSize = true;
            this.m_RandomPhotoLabel.Location = new System.Drawing.Point(795, 644);
            this.m_RandomPhotoLabel.Name = "m_RandomPhotoLabel";
            this.m_RandomPhotoLabel.Size = new System.Drawing.Size(200, 20);
            this.m_RandomPhotoLabel.TabIndex = 67;
            this.m_RandomPhotoLabel.Text = "Random Photo Of The Day";
            this.m_RandomPhotoLabel.Visible = false;
            this.m_RandomPhotoLabel.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // m_RandomPicture
            // 
            this.m_RandomPicture.Location = new System.Drawing.Point(777, 687);
            this.m_RandomPicture.Name = "m_RandomPicture";
            this.m_RandomPicture.Size = new System.Drawing.Size(248, 284);
            this.m_RandomPicture.TabIndex = 68;
            this.m_RandomPicture.TabStop = false;
            this.m_RandomPicture.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 1011);
            this.Controls.Add(this.m_RandomPicture);
            this.Controls.Add(this.m_RandomPhotoLabel);
            this.Controls.Add(this.m_UpcomingEventsListBox);
            this.Controls.Add(this.m_UpcomingEventsLabel);
            this.Controls.Add(this.m_UpcomingBirthdaysListBox);
            this.Controls.Add(this.m_TrendingPostListBox);
            this.Controls.Add(this.m_UpcomingBirthdayLabel);
            this.Controls.Add(this.m_TrendingPostLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_UserNameLabel);
            this.Controls.Add(this.m_LoggedInLabel);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Facebook App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private System.Windows.Forms.Label m_LoggedInLabel;
        private System.Windows.Forms.Label m_UserNameLabel;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label m_TrendingPostLabel;
        private System.Windows.Forms.Label m_UpcomingBirthdayLabel;
        private System.Windows.Forms.ListBox m_TrendingPostListBox;
        private System.Windows.Forms.ListBox m_UpcomingBirthdaysListBox;
        private System.Windows.Forms.Label m_UpcomingEventsLabel;
        private System.Windows.Forms.ListBox m_UpcomingEventsListBox;
        private System.Windows.Forms.Label m_RandomPhotoLabel;
        private System.Windows.Forms.PictureBox m_RandomPicture;
    }
}

