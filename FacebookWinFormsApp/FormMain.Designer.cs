﻿using System;
using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.m_UserNameLabel = new System.Windows.Forms.Label();
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_TrendingPostListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingEventsListBox = new System.Windows.Forms.ListBox();
            this.m_RandomPicture = new System.Windows.Forms.PictureBox();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_HomeTabPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_EventsAmountLabel = new System.Windows.Forms.Label();
            this.m_TopPostButton = new System.Windows.Forms.Button();
            this.m_BirthdaysButton = new System.Windows.Forms.Button();
            this.m_EventsButton = new System.Windows.Forms.Button();
            this.m_PictureRandomizerButton = new System.Windows.Forms.Button();
            this.m_UpcomingConcertsTabPage = new System.Windows.Forms.TabPage();
            this.m_RecommendationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_SimilarArtistsLabel = new System.Windows.Forms.Label();
            this.m_SimilarArtistsListBox = new System.Windows.Forms.ListBox();
            this.m_CommonInterestTabPage = new System.Windows.Forms.TabPage();
            this.m_FriendsIntrestsButton = new System.Windows.Forms.Button();
            this.m_CommonInterestListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.m_PhotosAmountLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.m_LocaleLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_BirthdayLabel = new System.Windows.Forms.Label();
            this.m_UserEmailLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_RememberMeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).BeginInit();
            this.m_tabControl.SuspendLayout();
            this.m_HomeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_UpcomingConcertsTabPage.SuspendLayout();
            this.m_CommonInterestTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1150, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(99, 35);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_UserNameLabel
            // 
            this.m_UserNameLabel.AutoSize = true;
            this.m_UserNameLabel.Location = new System.Drawing.Point(839, 21);
            this.m_UserNameLabel.Name = "m_UserNameLabel";
            this.m_UserNameLabel.Size = new System.Drawing.Size(89, 20);
            this.m_UserNameLabel.TabIndex = 56;
            this.m_UserNameLabel.Text = "user_name";
            // 
            // m_ProfilePicture
            // 
            this.m_ProfilePicture.Location = new System.Drawing.Point(1030, 9);
            this.m_ProfilePicture.Name = "m_ProfilePicture";
            this.m_ProfilePicture.Size = new System.Drawing.Size(84, 72);
            this.m_ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ProfilePicture.TabIndex = 57;
            this.m_ProfilePicture.TabStop = false;
            // 
            // m_TrendingPostListBox
            // 
            this.m_TrendingPostListBox.FormattingEnabled = true;
            this.m_TrendingPostListBox.ItemHeight = 20;
            this.m_TrendingPostListBox.Location = new System.Drawing.Point(138, 66);
            this.m_TrendingPostListBox.Name = "m_TrendingPostListBox";
            this.m_TrendingPostListBox.Size = new System.Drawing.Size(258, 284);
            this.m_TrendingPostListBox.TabIndex = 62;
            // 
            // m_UpcomingBirthdaysListBox
            // 
            this.m_UpcomingBirthdaysListBox.FormattingEnabled = true;
            this.m_UpcomingBirthdaysListBox.ItemHeight = 20;
            this.m_UpcomingBirthdaysListBox.Location = new System.Drawing.Point(741, 66);
            this.m_UpcomingBirthdaysListBox.Name = "m_UpcomingBirthdaysListBox";
            this.m_UpcomingBirthdaysListBox.Size = new System.Drawing.Size(258, 284);
            this.m_UpcomingBirthdaysListBox.TabIndex = 63;
            // 
            // m_UpcomingEventsListBox
            // 
            this.m_UpcomingEventsListBox.FormattingEnabled = true;
            this.m_UpcomingEventsListBox.ItemHeight = 20;
            this.m_UpcomingEventsListBox.Location = new System.Drawing.Point(138, 449);
            this.m_UpcomingEventsListBox.Name = "m_UpcomingEventsListBox";
            this.m_UpcomingEventsListBox.Size = new System.Drawing.Size(258, 284);
            this.m_UpcomingEventsListBox.TabIndex = 65;
            // 
            // m_RandomPicture
            // 
            this.m_RandomPicture.Location = new System.Drawing.Point(753, 449);
            this.m_RandomPicture.Name = "m_RandomPicture";
            this.m_RandomPicture.Size = new System.Drawing.Size(90, 88);
            this.m_RandomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.m_RandomPicture.TabIndex = 68;
            this.m_RandomPicture.TabStop = false;
            // 
            // m_tabControl
            // 
            this.m_tabControl.Controls.Add(this.m_HomeTabPage);
            this.m_tabControl.Controls.Add(this.m_UpcomingConcertsTabPage);
            this.m_tabControl.Controls.Add(this.m_CommonInterestTabPage);
            this.m_tabControl.Controls.Add(this.tabPage1);
            this.m_tabControl.ForeColor = System.Drawing.Color.Black;
            this.m_tabControl.Location = new System.Drawing.Point(18, 106);
            this.m_tabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_tabControl.Name = "m_tabControl";
            this.m_tabControl.SelectedIndex = 0;
            this.m_tabControl.Size = new System.Drawing.Size(1210, 783);
            this.m_tabControl.TabIndex = 69;
            // 
            // m_HomeTabPage
            // 
            this.m_HomeTabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_HomeTabPage.Controls.Add(this.pictureBox2);
            this.m_HomeTabPage.Controls.Add(this.pictureBox1);
            this.m_HomeTabPage.Controls.Add(this.m_EventsAmountLabel);
            this.m_HomeTabPage.Controls.Add(this.m_TopPostButton);
            this.m_HomeTabPage.Controls.Add(this.m_BirthdaysButton);
            this.m_HomeTabPage.Controls.Add(this.m_EventsButton);
            this.m_HomeTabPage.Controls.Add(this.m_PictureRandomizerButton);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingEventsListBox);
            this.m_HomeTabPage.Controls.Add(this.m_RandomPicture);
            this.m_HomeTabPage.Controls.Add(this.m_TrendingPostListBox);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingBirthdaysListBox);
            this.m_HomeTabPage.ForeColor = System.Drawing.Color.Black;
            this.m_HomeTabPage.Location = new System.Drawing.Point(4, 29);
            this.m_HomeTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_HomeTabPage.Name = "m_HomeTabPage";
            this.m_HomeTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_HomeTabPage.Size = new System.Drawing.Size(1202, 750);
            this.m_HomeTabPage.TabIndex = 0;
            this.m_HomeTabPage.Text = "Home";
            this.m_HomeTabPage.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(590, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(8, 10);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 270);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // m_EventsAmountLabel
            // 
            this.m_EventsAmountLabel.AutoSize = true;
            this.m_EventsAmountLabel.Location = new System.Drawing.Point(437, 399);
            this.m_EventsAmountLabel.Name = "m_EventsAmountLabel";
            this.m_EventsAmountLabel.Size = new System.Drawing.Size(126, 20);
            this.m_EventsAmountLabel.TabIndex = 73;
            this.m_EventsAmountLabel.Text = "Events Amount: ";
            // 
            // m_TopPostButton
            // 
            this.m_TopPostButton.Location = new System.Drawing.Point(138, 13);
            this.m_TopPostButton.Name = "m_TopPostButton";
            this.m_TopPostButton.Size = new System.Drawing.Size(276, 39);
            this.m_TopPostButton.TabIndex = 72;
            this.m_TopPostButton.Text = "Click here to get #1 Trending Post";
            this.m_TopPostButton.UseVisualStyleBackColor = true;
            this.m_TopPostButton.Click += new System.EventHandler(this.topPostButton_Click);
            // 
            // m_BirthdaysButton
            // 
            this.m_BirthdaysButton.Location = new System.Drawing.Point(741, 9);
            this.m_BirthdaysButton.Name = "m_BirthdaysButton";
            this.m_BirthdaysButton.Size = new System.Drawing.Size(276, 59);
            this.m_BirthdaysButton.TabIndex = 71;
            this.m_BirthdaysButton.Text = "Click here to get Upcoming Birthdays";
            this.m_BirthdaysButton.UseVisualStyleBackColor = true;
            this.m_BirthdaysButton.Click += new System.EventHandler(this.birthdaysButton_Click);
            // 
            // m_EventsButton
            // 
            this.m_EventsButton.Location = new System.Drawing.Point(138, 382);
            this.m_EventsButton.Name = "m_EventsButton";
            this.m_EventsButton.Size = new System.Drawing.Size(276, 55);
            this.m_EventsButton.TabIndex = 70;
            this.m_EventsButton.Text = "Click here to get Upcoming Events";
            this.m_EventsButton.UseVisualStyleBackColor = true;
            this.m_EventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // m_PictureRandomizerButton
            // 
            this.m_PictureRandomizerButton.Location = new System.Drawing.Point(741, 382);
            this.m_PictureRandomizerButton.Name = "m_PictureRandomizerButton";
            this.m_PictureRandomizerButton.Size = new System.Drawing.Size(276, 55);
            this.m_PictureRandomizerButton.TabIndex = 69;
            this.m_PictureRandomizerButton.Text = "Click To Get A Random Photo From Your Profile";
            this.m_PictureRandomizerButton.UseVisualStyleBackColor = true;
            this.m_PictureRandomizerButton.Click += new System.EventHandler(this.m_PictureRandomizerButton_Click);
            // 
            // m_UpcomingConcertsTabPage
            // 
            this.m_UpcomingConcertsTabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_RecommendationButton);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.label1);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SimilarArtistsLabel);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SimilarArtistsListBox);
            this.m_UpcomingConcertsTabPage.Location = new System.Drawing.Point(4, 29);
            this.m_UpcomingConcertsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_UpcomingConcertsTabPage.Name = "m_UpcomingConcertsTabPage";
            this.m_UpcomingConcertsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_UpcomingConcertsTabPage.Size = new System.Drawing.Size(1202, 750);
            this.m_UpcomingConcertsTabPage.TabIndex = 1;
            this.m_UpcomingConcertsTabPage.Text = "Artists Recommendations";
            this.m_UpcomingConcertsTabPage.UseVisualStyleBackColor = true;
            // 
            // m_RecommendationButton
            // 
            this.m_RecommendationButton.Location = new System.Drawing.Point(290, 114);
            this.m_RecommendationButton.Name = "m_RecommendationButton";
            this.m_RecommendationButton.Size = new System.Drawing.Size(295, 29);
            this.m_RecommendationButton.TabIndex = 3;
            this.m_RecommendationButton.Text = "Click To Get Recommendations!";
            this.m_RecommendationButton.UseVisualStyleBackColor = true;
            this.m_RecommendationButton.Click += new System.EventHandler(this.recommendationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = " Based on your favorite Artists, using last.fm api";
            // 
            // m_SimilarArtistsLabel
            // 
            this.m_SimilarArtistsLabel.AutoSize = true;
            this.m_SimilarArtistsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_SimilarArtistsLabel.Location = new System.Drawing.Point(282, 34);
            this.m_SimilarArtistsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_SimilarArtistsLabel.Name = "m_SimilarArtistsLabel";
            this.m_SimilarArtistsLabel.Size = new System.Drawing.Size(489, 37);
            this.m_SimilarArtistsLabel.TabIndex = 1;
            this.m_SimilarArtistsLabel.Text = "Similar Artists Recommendations";
            // 
            // m_SimilarArtistsListBox
            // 
            this.m_SimilarArtistsListBox.FormattingEnabled = true;
            this.m_SimilarArtistsListBox.ItemHeight = 20;
            this.m_SimilarArtistsListBox.Location = new System.Drawing.Point(290, 151);
            this.m_SimilarArtistsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_SimilarArtistsListBox.Name = "m_SimilarArtistsListBox";
            this.m_SimilarArtistsListBox.Size = new System.Drawing.Size(608, 324);
            this.m_SimilarArtistsListBox.TabIndex = 0;
            // 
            // m_CommonInterestTabPage
            // 
            this.m_CommonInterestTabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_CommonInterestTabPage.Controls.Add(this.m_FriendsIntrestsButton);
            this.m_CommonInterestTabPage.Controls.Add(this.m_CommonInterestListBox);
            this.m_CommonInterestTabPage.Controls.Add(this.label2);
            this.m_CommonInterestTabPage.Location = new System.Drawing.Point(4, 29);
            this.m_CommonInterestTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_CommonInterestTabPage.Name = "m_CommonInterestTabPage";
            this.m_CommonInterestTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_CommonInterestTabPage.Size = new System.Drawing.Size(1202, 750);
            this.m_CommonInterestTabPage.TabIndex = 2;
            this.m_CommonInterestTabPage.Text = "Friends With Common Interest";
            this.m_CommonInterestTabPage.UseVisualStyleBackColor = true;
            // 
            // m_FriendsIntrestsButton
            // 
            this.m_FriendsIntrestsButton.Location = new System.Drawing.Point(424, 73);
            this.m_FriendsIntrestsButton.Name = "m_FriendsIntrestsButton";
            this.m_FriendsIntrestsButton.Size = new System.Drawing.Size(259, 39);
            this.m_FriendsIntrestsButton.TabIndex = 4;
            this.m_FriendsIntrestsButton.Text = "Click here to see them!";
            this.m_FriendsIntrestsButton.UseVisualStyleBackColor = true;
            this.m_FriendsIntrestsButton.Click += new System.EventHandler(this.m_FriendsIntrestsButton_Click);
            // 
            // m_CommonInterestListBox
            // 
            this.m_CommonInterestListBox.FormattingEnabled = true;
            this.m_CommonInterestListBox.ItemHeight = 20;
            this.m_CommonInterestListBox.Location = new System.Drawing.Point(279, 120);
            this.m_CommonInterestListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_CommonInterestListBox.Name = "m_CommonInterestListBox";
            this.m_CommonInterestListBox.Size = new System.Drawing.Size(608, 324);
            this.m_CommonInterestListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(307, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Get list of cool friends that liked similar pages :)";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage1.Controls.Add(this.m_PhotosAmountLabel);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.m_LocaleLabel);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.m_BirthdayLabel);
            this.tabPage1.Controls.Add(this.m_UserEmailLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1202, 750);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // m_PhotosAmountLabel
            // 
            this.m_PhotosAmountLabel.AutoSize = true;
            this.m_PhotosAmountLabel.Location = new System.Drawing.Point(520, 166);
            this.m_PhotosAmountLabel.Name = "m_PhotosAmountLabel";
            this.m_PhotosAmountLabel.Size = new System.Drawing.Size(176, 20);
            this.m_PhotosAmountLabel.TabIndex = 9;
            this.m_PhotosAmountLabel.Text = "m_PhotosAmountLabel";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount of photos tagged in:";
            // 
            // m_LocaleLabel
            // 
            this.m_LocaleLabel.AutoSize = true;
            this.m_LocaleLabel.Location = new System.Drawing.Point(436, 121);
            this.m_LocaleLabel.Name = "m_LocaleLabel";
            this.m_LocaleLabel.Size = new System.Drawing.Size(117, 20);
            this.m_LocaleLabel.TabIndex = 7;
            this.m_LocaleLabel.Text = "m_LocaleLabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Locale:";
            // 
            // m_BirthdayLabel
            // 
            this.m_BirthdayLabel.AutoSize = true;
            this.m_BirthdayLabel.Location = new System.Drawing.Point(434, 79);
            this.m_BirthdayLabel.Name = "m_BirthdayLabel";
            this.m_BirthdayLabel.Size = new System.Drawing.Size(128, 20);
            this.m_BirthdayLabel.TabIndex = 5;
            this.m_BirthdayLabel.Text = "m_BirthdayLabel";
            // 
            // m_UserEmailLabel
            // 
            this.m_UserEmailLabel.AutoSize = true;
            this.m_UserEmailLabel.Location = new System.Drawing.Point(379, 39);
            this.m_UserEmailLabel.Name = "m_UserEmailLabel";
            this.m_UserEmailLabel.Size = new System.Drawing.Size(143, 20);
            this.m_UserEmailLabel.TabIndex = 3;
            this.m_UserEmailLabel.Text = "m_UserEmailLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // m_RememberMeCheckBox
            // 
            this.m_RememberMeCheckBox.AutoSize = true;
            this.m_RememberMeCheckBox.Location = new System.Drawing.Point(21, 55);
            this.m_RememberMeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_RememberMeCheckBox.Name = "m_RememberMeCheckBox";
            this.m_RememberMeCheckBox.Size = new System.Drawing.Size(140, 24);
            this.m_RememberMeCheckBox.TabIndex = 70;
            this.m_RememberMeCheckBox.Text = "Remember Me";
            this.m_RememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.m_RememberMeCheckBox);
            this.Controls.Add(this.m_tabControl);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_UserNameLabel);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).EndInit();
            this.m_tabControl.ResumeLayout(false);
            this.m_HomeTabPage.ResumeLayout(false);
            this.m_HomeTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_UpcomingConcertsTabPage.ResumeLayout(false);
            this.m_UpcomingConcertsTabPage.PerformLayout();
            this.m_CommonInterestTabPage.ResumeLayout(false);
            this.m_CommonInterestTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label m_UserNameLabel;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.ListBox m_TrendingPostListBox;
        private System.Windows.Forms.ListBox m_UpcomingBirthdaysListBox;
        private System.Windows.Forms.ListBox m_UpcomingEventsListBox;
        private System.Windows.Forms.PictureBox m_RandomPicture;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_HomeTabPage;
        private System.Windows.Forms.TabPage m_UpcomingConcertsTabPage;
        private System.Windows.Forms.TabPage m_CommonInterestTabPage;
        private System.Windows.Forms.Label m_SimilarArtistsLabel;
        private System.Windows.Forms.ListBox m_SimilarArtistsListBox;
        private System.Windows.Forms.CheckBox m_RememberMeCheckBox;
        private System.Windows.Forms.ListBox m_CommonInterestListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_PictureRandomizerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button m_RecommendationButton;
        private System.Windows.Forms.Button m_EventsButton;
        private System.Windows.Forms.Button m_TopPostButton;
        private System.Windows.Forms.Button m_BirthdaysButton;
        private System.Windows.Forms.Label m_EventsAmountLabel;
        private System.Windows.Forms.Button m_FriendsIntrestsButton;
        private System.Windows.Forms.Label m_BirthdayLabel;
        private System.Windows.Forms.Label m_UserEmailLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label m_PhotosAmountLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label m_LocaleLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
