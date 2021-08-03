using System;

namespace BasicFacebookFeatures
{
    public partial class FormMain
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.m_LoggedInLabel = new System.Windows.Forms.Label();
            this.m_UserNameLabel = new System.Windows.Forms.Label();
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_TrendingPostLabel = new System.Windows.Forms.Label();
            this.m_UpcomingBirthdayLabel = new System.Windows.Forms.Label();
            this.m_TrendingPostListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingEventsLabel = new System.Windows.Forms.Label();
            this.m_UpcomingEventsListBox = new System.Windows.Forms.ListBox();
            this.m_RandomPhotoLabel = new System.Windows.Forms.Label();
            this.m_RandomPicture = new System.Windows.Forms.PictureBox();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_HomeTabPage = new System.Windows.Forms.TabPage();
            this.m_UpcomingConcertsTabPage = new System.Windows.Forms.TabPage();
            this.m_SimilarArtistsLabel = new System.Windows.Forms.Label();
            this.m_UpcomingConcertsListBox = new System.Windows.Forms.ListBox();
            this.m_CommonInterestTabPage = new System.Windows.Forms.TabPage();
            this.m_CommonInterestListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).BeginInit();
            this.m_tabControl.SuspendLayout();
            this.m_HomeTabPage.SuspendLayout();
            this.m_UpcomingConcertsTabPage.SuspendLayout();
            this.m_CommonInterestTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(767, 9);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(66, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_LoggedInLabel
            // 
            this.m_LoggedInLabel.AutoSize = true;
            this.m_LoggedInLabel.Location = new System.Drawing.Point(11, 16);
            this.m_LoggedInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_LoggedInLabel.Name = "m_LoggedInLabel";
            this.m_LoggedInLabel.Size = new System.Drawing.Size(71, 13);
            this.m_LoggedInLabel.TabIndex = 55;
            this.m_LoggedInLabel.Text = "Logged in as ";
            // 
            // m_UserNameLabel
            // 
            this.m_UserNameLabel.AutoSize = true;
            this.m_UserNameLabel.Location = new System.Drawing.Point(75, 16);
            this.m_UserNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_UserNameLabel.Name = "m_UserNameLabel";
            this.m_UserNameLabel.Size = new System.Drawing.Size(59, 13);
            this.m_UserNameLabel.TabIndex = 56;
            this.m_UserNameLabel.Text = "user_name";
            // 
            // m_ProfilePicture
            // 
            this.m_ProfilePicture.Location = new System.Drawing.Point(687, 6);
            this.m_ProfilePicture.Margin = new System.Windows.Forms.Padding(2);
            this.m_ProfilePicture.Name = "m_ProfilePicture";
            this.m_ProfilePicture.Size = new System.Drawing.Size(56, 47);
            this.m_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ProfilePicture.TabIndex = 57;
            this.m_ProfilePicture.TabStop = false;
            // 
            // m_TrendingPostLabel
            // 
            this.m_TrendingPostLabel.AutoSize = true;
            this.m_TrendingPostLabel.Location = new System.Drawing.Point(119, 14);
            this.m_TrendingPostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_TrendingPostLabel.Name = "m_TrendingPostLabel";
            this.m_TrendingPostLabel.Size = new System.Drawing.Size(89, 13);
            this.m_TrendingPostLabel.TabIndex = 60;
            this.m_TrendingPostLabel.Text = "#1 Trending Post";
            // 
            // m_UpcomingBirthdayLabel
            // 
            this.m_UpcomingBirthdayLabel.AutoSize = true;
            this.m_UpcomingBirthdayLabel.Location = new System.Drawing.Point(525, 14);
            this.m_UpcomingBirthdayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_UpcomingBirthdayLabel.Name = "m_UpcomingBirthdayLabel";
            this.m_UpcomingBirthdayLabel.Size = new System.Drawing.Size(101, 13);
            this.m_UpcomingBirthdayLabel.TabIndex = 61;
            this.m_UpcomingBirthdayLabel.Text = "Upcoming Birthdays";
            // 
            // m_TrendingPostListBox
            // 
            this.m_TrendingPostListBox.FormattingEnabled = true;
            this.m_TrendingPostListBox.Location = new System.Drawing.Point(92, 43);
            this.m_TrendingPostListBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_TrendingPostListBox.Name = "m_TrendingPostListBox";
            this.m_TrendingPostListBox.Size = new System.Drawing.Size(173, 186);
            this.m_TrendingPostListBox.TabIndex = 62;
            // 
            // m_UpcomingBirthdaysListBox
            // 
            this.m_UpcomingBirthdaysListBox.FormattingEnabled = true;
            this.m_UpcomingBirthdaysListBox.Location = new System.Drawing.Point(494, 43);
            this.m_UpcomingBirthdaysListBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_UpcomingBirthdaysListBox.Name = "m_UpcomingBirthdaysListBox";
            this.m_UpcomingBirthdaysListBox.Size = new System.Drawing.Size(173, 186);
            this.m_UpcomingBirthdaysListBox.TabIndex = 63;
            // 
            // m_UpcomingEventsLabel
            // 
            this.m_UpcomingEventsLabel.AutoSize = true;
            this.m_UpcomingEventsLabel.Location = new System.Drawing.Point(119, 260);
            this.m_UpcomingEventsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_UpcomingEventsLabel.Name = "m_UpcomingEventsLabel";
            this.m_UpcomingEventsLabel.Size = new System.Drawing.Size(91, 13);
            this.m_UpcomingEventsLabel.TabIndex = 64;
            this.m_UpcomingEventsLabel.Text = "Upcoming Events";
            // 
            // m_UpcomingEventsListBox
            // 
            this.m_UpcomingEventsListBox.FormattingEnabled = true;
            this.m_UpcomingEventsListBox.Location = new System.Drawing.Point(92, 292);
            this.m_UpcomingEventsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_UpcomingEventsListBox.Name = "m_UpcomingEventsListBox";
            this.m_UpcomingEventsListBox.Size = new System.Drawing.Size(173, 186);
            this.m_UpcomingEventsListBox.TabIndex = 65;
            // 
            // m_RandomPhotoLabel
            // 
            this.m_RandomPhotoLabel.AutoSize = true;
            this.m_RandomPhotoLabel.Location = new System.Drawing.Point(499, 260);
            this.m_RandomPhotoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_RandomPhotoLabel.Name = "m_RandomPhotoLabel";
            this.m_RandomPhotoLabel.Size = new System.Drawing.Size(136, 13);
            this.m_RandomPhotoLabel.TabIndex = 67;
            this.m_RandomPhotoLabel.Text = "Random Photo Of The Day";
            // 
            // m_RandomPicture
            // 
            this.m_RandomPicture.Location = new System.Drawing.Point(502, 292);
            this.m_RandomPicture.Margin = new System.Windows.Forms.Padding(2);
            this.m_RandomPicture.Name = "m_RandomPicture";
            this.m_RandomPicture.Size = new System.Drawing.Size(90, 88);
            this.m_RandomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_RandomPicture.TabIndex = 68;
            this.m_RandomPicture.TabStop = false;
            this.m_RandomPicture.Click += new System.EventHandler(this.m_RandomPicture_Click);
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_HomeTabPage);
            this.m_tabControl.Controls.Add(this.m_UpcomingConcertsTabPage);
            this.m_tabControl.Controls.Add(this.m_CommonInterestTabPage);
            this.m_tabControl.Location = new System.Drawing.Point(12, 69);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(807, 509);
            this.m_tabControl.TabIndex = 69;
            // 
            // m_HomeTabPage
            // 
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingEventsListBox);
            this.m_HomeTabPage.Controls.Add(this.m_RandomPicture);
            this.m_HomeTabPage.Controls.Add(this.m_TrendingPostLabel);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingBirthdayLabel);
            this.m_HomeTabPage.Controls.Add(this.m_RandomPhotoLabel);
            this.m_HomeTabPage.Controls.Add(this.m_TrendingPostListBox);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingBirthdaysListBox);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingEventsLabel);
            this.m_HomeTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_HomeTabPage.Name = "m_HomeTabPage";
            this.m_HomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_HomeTabPage.Size = new System.Drawing.Size(799, 483);
            this.m_HomeTabPage.TabIndex = 0;
            this.m_HomeTabPage.Text = "Home";
            this.m_HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // m_UpcomingConcertsTabPage
            // 
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SimilarArtistsLabel);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_UpcomingConcertsListBox);
            this.m_UpcomingConcertsTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_UpcomingConcertsTabPage.Name = "m_UpcomingConcertsTabPage";
            this.m_UpcomingConcertsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_UpcomingConcertsTabPage.Size = new System.Drawing.Size(799, 483);
            this.m_UpcomingConcertsTabPage.TabIndex = 1;
            this.m_UpcomingConcertsTabPage.Text = "Upcoming Concerts";
            this.m_UpcomingConcertsTabPage.UseVisualStyleBackColor = true;
            // 
            // m_SimilarArtistsLabel
            // 
            this.m_SimilarArtistsLabel.AutoSize = true;
            this.m_SimilarArtistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_SimilarArtistsLabel.Location = new System.Drawing.Point(188, 22);
            this.m_SimilarArtistsLabel.Name = "m_SimilarArtistsLabel";
            this.m_SimilarArtistsLabel.Size = new System.Drawing.Size(345, 25);
            this.m_SimilarArtistsLabel.TabIndex = 1;
            this.m_SimilarArtistsLabel.Text = "Your Favorite Artists Similar Artists";
            // 
            // m_UpcomingConcertsListBox
            // 
            this.m_UpcomingConcertsListBox.FormattingEnabled = true;
            this.m_UpcomingConcertsListBox.Location = new System.Drawing.Point(193, 72);
            this.m_UpcomingConcertsListBox.Name = "m_UpcomingConcertsListBox";
            this.m_UpcomingConcertsListBox.Size = new System.Drawing.Size(407, 212);
            this.m_UpcomingConcertsListBox.TabIndex = 0;
            // 
            // m_CommonInterestTabPage
            // 
            this.m_CommonInterestTabPage.Controls.Add(this.m_CommonInterestListBox);
            this.m_CommonInterestTabPage.Controls.Add(this.label2);
            this.m_CommonInterestTabPage.Location = new System.Drawing.Point(4, 22);
            this.m_CommonInterestTabPage.Name = "m_CommonInterestTabPage";
            this.m_CommonInterestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.m_CommonInterestTabPage.Size = new System.Drawing.Size(799, 483);
            this.m_CommonInterestTabPage.TabIndex = 2;
            this.m_CommonInterestTabPage.Text = "Friends With Common Interest";
            this.m_CommonInterestTabPage.UseVisualStyleBackColor = true;
            // 
            // m_CommonInterestListBox
            // 
            this.m_CommonInterestListBox.FormattingEnabled = true;
            this.m_CommonInterestListBox.Location = new System.Drawing.Point(186, 78);
            this.m_CommonInterestListBox.Name = "m_CommonInterestListBox";
            this.m_CommonInterestListBox.Size = new System.Drawing.Size(407, 212);
            this.m_CommonInterestListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(203, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Best Friends With Best Interest";
            // 
            // m_RememberMeCheckBox
            // 
            this.m_RememberMeCheckBox.AutoSize = true;
            this.m_RememberMeCheckBox.Location = new System.Drawing.Point(14, 36);
            this.m_RememberMeCheckBox.Name = "m_RememberMeCheckBox";
            this.m_RememberMeCheckBox.Size = new System.Drawing.Size(95, 17);
            this.m_RememberMeCheckBox.TabIndex = 70;
            this.m_RememberMeCheckBox.Text = "Remember Me";
            this.m_RememberMeCheckBox.UseVisualStyleBackColor = true;
            this.m_RememberMeCheckBox.CheckedChanged += new System.EventHandler(this.m_RememberMeCheckBox_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 611);
            this.Controls.Add(this.m_RememberMeCheckBox);
            this.Controls.Add(this.m_tabControl);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_UserNameLabel);
            this.Controls.Add(this.m_LoggedInLabel);
            this.Controls.Add(this.buttonLogout);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).EndInit();
            this.m_tabControl.ResumeLayout(false);
            this.m_HomeTabPage.ResumeLayout(false);
            this.m_HomeTabPage.PerformLayout();
            this.m_UpcomingConcertsTabPage.ResumeLayout(false);
            this.m_UpcomingConcertsTabPage.PerformLayout();
            this.m_CommonInterestTabPage.ResumeLayout(false);
            this.m_CommonInterestTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label m_LoggedInLabel;
        private System.Windows.Forms.Label m_UserNameLabel;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.Label m_TrendingPostLabel;
        private System.Windows.Forms.Label m_UpcomingBirthdayLabel;
        private System.Windows.Forms.ListBox m_TrendingPostListBox;
        private System.Windows.Forms.ListBox m_UpcomingBirthdaysListBox;
        private System.Windows.Forms.Label m_UpcomingEventsLabel;
        private System.Windows.Forms.ListBox m_UpcomingEventsListBox;
        private System.Windows.Forms.Label m_RandomPhotoLabel;
        private System.Windows.Forms.PictureBox m_RandomPicture;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_HomeTabPage;
        private System.Windows.Forms.TabPage m_UpcomingConcertsTabPage;
        private System.Windows.Forms.TabPage m_CommonInterestTabPage;
        private System.Windows.Forms.Label m_SimilarArtistsLabel;
        private System.Windows.Forms.ListBox m_UpcomingConcertsListBox;
        private System.Windows.Forms.CheckBox m_RememberMeCheckBox;
        private System.Windows.Forms.ListBox m_CommonInterestListBox;
        private System.Windows.Forms.Label label2;
    }
}
