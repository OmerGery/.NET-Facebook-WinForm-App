using System;
using System.Drawing;

namespace BasicFacebookFeatures
{
    public partial class MainForm
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
            System.Windows.Forms.Label attendingCountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageSmallLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogout = new System.Windows.Forms.Button();
            this.m_UserNameLabel = new System.Windows.Forms.Label();
            this.m_ProfilePicture = new System.Windows.Forms.PictureBox();
            this.m_UpcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.m_UpcomingEventsListBox = new System.Windows.Forms.ListBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_RandomPicture = new System.Windows.Forms.PictureBox();
            this.m_tabControl = new System.Windows.Forms.TabControl();
            this.m_HomeTabPage = new System.Windows.Forms.TabPage();
            this.m_FetchAllDataButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attendingCountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageSmallPictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_TrendingPostTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.m_EventsAmountLabel = new System.Windows.Forms.Label();
            this.m_TopPostButton = new System.Windows.Forms.Button();
            this.m_BirthdaysButton = new System.Windows.Forms.Button();
            this.m_EventsButton = new System.Windows.Forms.Button();
            this.m_PictureRandomizerButton = new System.Windows.Forms.Button();
            this.m_UpcomingConcertsTabPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.m_SortingComboBox = new System.Windows.Forms.ComboBox();
            this.m_ArtistsLimitNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_SimilarArtistsTextBox = new System.Windows.Forms.TextBox();
            this.m_RecommendationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.m_SimilarArtistsLabel = new System.Windows.Forms.Label();
            this.m_FavoriteArtistsListBox = new System.Windows.Forms.ListBox();
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            attendingCountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageSmallLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).BeginInit();
            this.m_tabControl.SuspendLayout();
            this.m_HomeTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.m_UpcomingConcertsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ArtistsLimitNumericUpDown)).BeginInit();
            this.m_CommonInterestTabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendingCountLabel
            // 
            attendingCountLabel.AutoSize = true;
            attendingCountLabel.Location = new System.Drawing.Point(16, 25);
            attendingCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            attendingCountLabel.Name = "attendingCountLabel";
            attendingCountLabel.Size = new System.Drawing.Size(129, 20);
            attendingCountLabel.TabIndex = 0;
            attendingCountLabel.Text = "Attending Count:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(16, 65);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(93, 20);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // imageSmallLabel
            // 
            imageSmallLabel.AutoSize = true;
            imageSmallLabel.Location = new System.Drawing.Point(16, 100);
            imageSmallLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            imageSmallLabel.Name = "imageSmallLabel";
            imageSmallLabel.Size = new System.Drawing.Size(101, 20);
            imageSmallLabel.TabIndex = 4;
            imageSmallLabel.Text = "Image Small:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(16, 192);
            locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(74, 20);
            locationLabel.TabIndex = 8;
            locationLabel.Text = "Location:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(16, 248);
            startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(86, 20);
            startTimeLabel.TabIndex = 10;
            startTimeLabel.Text = "Start Time:";
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
            this.m_UserNameLabel.Location = new System.Drawing.Point(838, 22);
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
            // m_UpcomingBirthdaysListBox
            // 
            this.m_UpcomingBirthdaysListBox.FormattingEnabled = true;
            this.m_UpcomingBirthdaysListBox.ItemHeight = 20;
            this.m_UpcomingBirthdaysListBox.Location = new System.Drawing.Point(879, 77);
            this.m_UpcomingBirthdaysListBox.Name = "m_UpcomingBirthdaysListBox";
            this.m_UpcomingBirthdaysListBox.Size = new System.Drawing.Size(258, 284);
            this.m_UpcomingBirthdaysListBox.TabIndex = 63;
            // 
            // m_UpcomingEventsListBox
            // 
            this.m_UpcomingEventsListBox.DataSource = this.eventBindingSource;
            this.m_UpcomingEventsListBox.FormattingEnabled = true;
            this.m_UpcomingEventsListBox.ItemHeight = 20;
            this.m_UpcomingEventsListBox.Location = new System.Drawing.Point(138, 449);
            this.m_UpcomingEventsListBox.Name = "m_UpcomingEventsListBox";
            this.m_UpcomingEventsListBox.Size = new System.Drawing.Size(258, 284);
            this.m_UpcomingEventsListBox.TabIndex = 65;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // m_RandomPicture
            // 
            this.m_RandomPicture.Location = new System.Drawing.Point(956, 509);
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
            this.m_HomeTabPage.AutoScroll = true;
            this.m_HomeTabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_HomeTabPage.Controls.Add(this.m_FetchAllDataButton);
            this.m_HomeTabPage.Controls.Add(this.panel1);
            this.m_HomeTabPage.Controls.Add(this.m_TrendingPostTextBox);
            this.m_HomeTabPage.Controls.Add(this.pictureBox1);
            this.m_HomeTabPage.Controls.Add(this.m_EventsAmountLabel);
            this.m_HomeTabPage.Controls.Add(this.m_TopPostButton);
            this.m_HomeTabPage.Controls.Add(this.m_BirthdaysButton);
            this.m_HomeTabPage.Controls.Add(this.m_EventsButton);
            this.m_HomeTabPage.Controls.Add(this.m_PictureRandomizerButton);
            this.m_HomeTabPage.Controls.Add(this.m_UpcomingEventsListBox);
            this.m_HomeTabPage.Controls.Add(this.m_RandomPicture);
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
            // m_FetchAllDataButton
            // 
            this.m_FetchAllDataButton.BackColor = System.Drawing.Color.BurlyWood;
            this.m_FetchAllDataButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.m_FetchAllDataButton.Location = new System.Drawing.Point(488, 12);
            this.m_FetchAllDataButton.Name = "m_FetchAllDataButton";
            this.m_FetchAllDataButton.Size = new System.Drawing.Size(224, 58);
            this.m_FetchAllDataButton.TabIndex = 78;
            this.m_FetchAllDataButton.Text = "Click here to Fetch All Data in One Click";
            this.m_FetchAllDataButton.UseVisualStyleBackColor = false;
            this.m_FetchAllDataButton.Click += new System.EventHandler(this.m_FetchAllDataButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(attendingCountLabel);
            this.panel1.Controls.Add(this.attendingCountTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(imageSmallLabel);
            this.panel1.Controls.Add(this.imageSmallPictureBox);
            this.panel1.Controls.Add(locationLabel);
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Controls.Add(startTimeLabel);
            this.panel1.Controls.Add(this.startTimeDateTimePicker);
            this.panel1.Location = new System.Drawing.Point(420, 449);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 286);
            this.panel1.TabIndex = 77;
            // 
            // attendingCountTextBox
            // 
            this.attendingCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "AttendingCount", true));
            this.attendingCountTextBox.Location = new System.Drawing.Point(171, 20);
            this.attendingCountTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attendingCountTextBox.Name = "attendingCountTextBox";
            this.attendingCountTextBox.Size = new System.Drawing.Size(132, 26);
            this.attendingCountTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(171, 60);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(228, 26);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // imageSmallPictureBox
            // 
            this.imageSmallPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageSmall", true));
            this.imageSmallPictureBox.Location = new System.Drawing.Point(171, 100);
            this.imageSmallPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageSmallPictureBox.Name = "imageSmallPictureBox";
            this.imageSmallPictureBox.Size = new System.Drawing.Size(84, 77);
            this.imageSmallPictureBox.TabIndex = 5;
            this.imageSmallPictureBox.TabStop = false;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(168, 192);
            this.locationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(202, 26);
            this.locationTextBox.TabIndex = 9;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(112, 248);
            this.startTimeDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(268, 26);
            this.startTimeDateTimePicker.TabIndex = 11;
            // 
            // m_TrendingPostTextBox
            // 
            this.m_TrendingPostTextBox.Location = new System.Drawing.Point(138, 66);
            this.m_TrendingPostTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_TrendingPostTextBox.Multiline = true;
            this.m_TrendingPostTextBox.Name = "m_TrendingPostTextBox";
            this.m_TrendingPostTextBox.Size = new System.Drawing.Size(258, 284);
            this.m_TrendingPostTextBox.TabIndex = 76;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 269);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // m_EventsAmountLabel
            // 
            this.m_EventsAmountLabel.AutoSize = true;
            this.m_EventsAmountLabel.Location = new System.Drawing.Point(436, 398);
            this.m_EventsAmountLabel.Name = "m_EventsAmountLabel";
            this.m_EventsAmountLabel.Size = new System.Drawing.Size(126, 20);
            this.m_EventsAmountLabel.TabIndex = 73;
            this.m_EventsAmountLabel.Text = "Events Amount: ";
            // 
            // m_TopPostButton
            // 
            this.m_TopPostButton.Location = new System.Drawing.Point(138, 12);
            this.m_TopPostButton.Name = "m_TopPostButton";
            this.m_TopPostButton.Size = new System.Drawing.Size(276, 38);
            this.m_TopPostButton.TabIndex = 72;
            this.m_TopPostButton.Text = "Click here to get #1 Trending Post";
            this.m_TopPostButton.UseVisualStyleBackColor = true;
            this.m_TopPostButton.Click += new System.EventHandler(this.topPostButton_Click);
            // 
            // m_BirthdaysButton
            // 
            this.m_BirthdaysButton.Location = new System.Drawing.Point(862, 12);
            this.m_BirthdaysButton.Name = "m_BirthdaysButton";
            this.m_BirthdaysButton.Size = new System.Drawing.Size(276, 58);
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
            this.m_PictureRandomizerButton.Location = new System.Drawing.Point(862, 388);
            this.m_PictureRandomizerButton.Name = "m_PictureRandomizerButton";
            this.m_PictureRandomizerButton.Size = new System.Drawing.Size(276, 55);
            this.m_PictureRandomizerButton.TabIndex = 69;
            this.m_PictureRandomizerButton.Text = "Click To Get A Random Photo From Your Profile";
            this.m_PictureRandomizerButton.UseVisualStyleBackColor = true;
            this.m_PictureRandomizerButton.Click += new System.EventHandler(this.pictureRandomButton_Click);
            // 
            // m_UpcomingConcertsTabPage
            // 
            this.m_UpcomingConcertsTabPage.AllowDrop = true;
            this.m_UpcomingConcertsTabPage.BackColor = System.Drawing.Color.CornflowerBlue;
            this.m_UpcomingConcertsTabPage.Controls.Add(this.label7);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.label4);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SortingComboBox);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_ArtistsLimitNumericUpDown);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SimilarArtistsTextBox);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_RecommendationButton);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.label1);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_SimilarArtistsLabel);
            this.m_UpcomingConcertsTabPage.Controls.Add(this.m_FavoriteArtistsListBox);
            this.m_UpcomingConcertsTabPage.Location = new System.Drawing.Point(4, 29);
            this.m_UpcomingConcertsTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_UpcomingConcertsTabPage.Name = "m_UpcomingConcertsTabPage";
            this.m_UpcomingConcertsTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_UpcomingConcertsTabPage.Size = new System.Drawing.Size(1202, 750);
            this.m_UpcomingConcertsTabPage.TabIndex = 1;
            this.m_UpcomingConcertsTabPage.Text = "Artists Recommendations";
            this.m_UpcomingConcertsTabPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sort By:";
            // 
            // m_SortingComboBox
            // 
            this.m_SortingComboBox.FormattingEnabled = true;
            this.m_SortingComboBox.Items.AddRange(new object[] {
            "By Match Rating",
            "A-Z",
            "Z-A"});
            this.m_SortingComboBox.Location = new System.Drawing.Point(528, 155);
            this.m_SortingComboBox.Name = "m_SortingComboBox";
            this.m_SortingComboBox.Size = new System.Drawing.Size(210, 28);
            this.m_SortingComboBox.TabIndex = 6;
            // 
            // m_ArtistsLimitNumericUpDown
            // 
            this.m_ArtistsLimitNumericUpDown.Location = new System.Drawing.Point(820, 155);
            this.m_ArtistsLimitNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_ArtistsLimitNumericUpDown.Name = "m_ArtistsLimitNumericUpDown";
            this.m_ArtistsLimitNumericUpDown.Size = new System.Drawing.Size(54, 26);
            this.m_ArtistsLimitNumericUpDown.TabIndex = 5;
            // 
            // m_SimilarArtistsTextBox
            // 
            this.m_SimilarArtistsTextBox.Location = new System.Drawing.Point(627, 226);
            this.m_SimilarArtistsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_SimilarArtistsTextBox.Multiline = true;
            this.m_SimilarArtistsTextBox.Name = "m_SimilarArtistsTextBox";
            this.m_SimilarArtistsTextBox.Size = new System.Drawing.Size(278, 264);
            this.m_SimilarArtistsTextBox.TabIndex = 4;
            // 
            // m_RecommendationButton
            // 
            this.m_RecommendationButton.Location = new System.Drawing.Point(461, 189);
            this.m_RecommendationButton.Name = "m_RecommendationButton";
            this.m_RecommendationButton.Size = new System.Drawing.Size(280, 29);
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
            // m_FavoriteArtistsListBox
            // 
            this.m_FavoriteArtistsListBox.FormattingEnabled = true;
            this.m_FavoriteArtistsListBox.ItemHeight = 20;
            this.m_FavoriteArtistsListBox.Location = new System.Drawing.Point(277, 226);
            this.m_FavoriteArtistsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_FavoriteArtistsListBox.Name = "m_FavoriteArtistsListBox";
            this.m_FavoriteArtistsListBox.Size = new System.Drawing.Size(294, 264);
            this.m_FavoriteArtistsListBox.TabIndex = 0;
            this.m_FavoriteArtistsListBox.SelectedIndexChanged += new System.EventHandler(this.similarArtistsListBox_SelectedIndexChanged);
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
            this.m_FriendsIntrestsButton.Location = new System.Drawing.Point(424, 72);
            this.m_FriendsIntrestsButton.Name = "m_FriendsIntrestsButton";
            this.m_FriendsIntrestsButton.Size = new System.Drawing.Size(260, 38);
            this.m_FriendsIntrestsButton.TabIndex = 4;
            this.m_FriendsIntrestsButton.Text = "Click here to see them!";
            this.m_FriendsIntrestsButton.UseVisualStyleBackColor = true;
            this.m_FriendsIntrestsButton.Click += new System.EventHandler(this.friendsInterestsButton_Click);
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
            this.label2.Location = new System.Drawing.Point(308, 32);
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
            this.label8.Location = new System.Drawing.Point(292, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Amount of photos tagged in:";
            // 
            // m_LocaleLabel
            // 
            this.m_LocaleLabel.AutoSize = true;
            this.m_LocaleLabel.Location = new System.Drawing.Point(436, 122);
            this.m_LocaleLabel.Name = "m_LocaleLabel";
            this.m_LocaleLabel.Size = new System.Drawing.Size(117, 20);
            this.m_LocaleLabel.TabIndex = 7;
            this.m_LocaleLabel.Text = "m_LocaleLabel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Locale:";
            // 
            // m_BirthdayLabel
            // 
            this.m_BirthdayLabel.AutoSize = true;
            this.m_BirthdayLabel.Location = new System.Drawing.Point(434, 78);
            this.m_BirthdayLabel.Name = "m_BirthdayLabel";
            this.m_BirthdayLabel.Size = new System.Drawing.Size(128, 20);
            this.m_BirthdayLabel.TabIndex = 5;
            this.m_BirthdayLabel.Text = "m_BirthdayLabel";
            // 
            // m_UserEmailLabel
            // 
            this.m_UserEmailLabel.AutoSize = true;
            this.m_UserEmailLabel.Location = new System.Drawing.Point(380, 38);
            this.m_UserEmailLabel.Name = "m_UserEmailLabel";
            this.m_UserEmailLabel.Size = new System.Drawing.Size(143, 20);
            this.m_UserEmailLabel.TabIndex = 3;
            this.m_UserEmailLabel.Text = "m_UserEmailLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Birthday:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 38);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1256, 932);
            this.Controls.Add(this.m_RememberMeCheckBox);
            this.Controls.Add(this.m_tabControl);
            this.Controls.Add(this.m_ProfilePicture);
            this.Controls.Add(this.m_UserNameLabel);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun Facebook App";
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_RandomPicture)).EndInit();
            this.m_tabControl.ResumeLayout(false);
            this.m_HomeTabPage.ResumeLayout(false);
            this.m_HomeTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSmallPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.m_UpcomingConcertsTabPage.ResumeLayout(false);
            this.m_UpcomingConcertsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ArtistsLimitNumericUpDown)).EndInit();
            this.m_CommonInterestTabPage.ResumeLayout(false);
            this.m_CommonInterestTabPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label m_UserNameLabel;
        private System.Windows.Forms.PictureBox m_ProfilePicture;
        private System.Windows.Forms.ListBox m_UpcomingBirthdaysListBox;
        private System.Windows.Forms.ListBox m_UpcomingEventsListBox;
        private System.Windows.Forms.PictureBox m_RandomPicture;
        private System.Windows.Forms.TabControl m_tabControl;
        private System.Windows.Forms.TabPage m_HomeTabPage;
        private System.Windows.Forms.TabPage m_UpcomingConcertsTabPage;
        private System.Windows.Forms.TabPage m_CommonInterestTabPage;
        private System.Windows.Forms.Label m_SimilarArtistsLabel;
        private System.Windows.Forms.ListBox m_FavoriteArtistsListBox;
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
        private System.Windows.Forms.TextBox m_SimilarArtistsTextBox;
        private System.Windows.Forms.TextBox m_TrendingPostTextBox;
        private System.Windows.Forms.NumericUpDown m_ArtistsLimitNumericUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox attendingCountTextBox;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageSmallPictureBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startTimeDateTimePicker;
        private System.Windows.Forms.Button m_FetchAllDataButton;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox m_SortingComboBox;
    }
}
