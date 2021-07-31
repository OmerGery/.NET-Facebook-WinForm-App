using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly Random r_Random = new Random();
        private readonly User r_LoggedUser;

        private readonly AppSettings m_AppSettings = new AppSettings(); //need to change to Singleton
        public FormMain(User i_LoggedUser) //need to send i_AppSettings
        {
            r_LoggedUser = i_LoggedUser;
            InitializeComponent();
            this.Size = m_AppSettings.m_LastWindowsSize;
            this.Location = m_AppSettings.m_LastWindowsLocation;
            m_RememberMeCheckBox.Checked = m_AppSettings.m_RememberUser;
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = r_LoggedUser.Name;
            m_ProfilePicture.Image = r_LoggedUser.ImageSmall;
            fetchEvents();
            fetchConcerts();
            fetchFriendsWithCommonInterest();
        }

        protected override void OnClosed(EventArgs e)
        {
            // need to save appsettings with singleton
            base.OnClosed(e);
        }

        private void fetchEvents()
        {
            FacebookObjectCollection<Event> userEvents = r_LoggedUser.Events;
            m_UpcomingEventsLabel.Text = $@" {userEvents.Count} {m_UpcomingEventsLabel.Text}";
            foreach(var userEvent in userEvents)
            {
                long? eventAttendingNumber = userEvent.AttendingCount;
                //userEventLocation = userEvent.Location;
               // userEventLocation = userEventLocation.Replace("Name", "").Replace(", URL:", " ");
               if(eventAttendingNumber != null)
               {
                   m_UpcomingEventsListBox.Items.Add($"{userEvent.Name} - {eventAttendingNumber.ToString()} Attendees");
               }
            }
        }

        private void fetchFriendsWithCommonInterest()
        {
            Dictionary<string, int> friendsCommonPagesLikes = new Dictionary<string, int>();
            
            foreach (User friend in r_LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if(r_LoggedUser.LikedPages.Contains(friendLikedPage))
                    {
                        friendCommonLikedPages++;
                    }
                }

                friendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
            }

            friendsCommonPagesLikes.OrderByDescending(pair => pair.Value);

            foreach(var friendInDictionary in friendsCommonPagesLikes)
            {
                m_CommonInterestListBox.Items.Add(
                    $"{friendInDictionary.Key} - {friendInDictionary.Value.ToString()} Pages");
            }

        }

        private void fetchConcerts()
        {
            int i = 0;
            List<string> userFavoriteArtists = new List<string>
                                                   {
                                                       "Metallica",
                                                       "Radiohead",
                                                       "The Strokes",
                                                       "Pink Floyd",
                                                       "Doja Cat",
                                                       "Lady Gaga",
                                                       "Nirvana"
                                                       
                                                   };
            var fakeConcerts = findFavoriteArtistsConcertsAPI(userFavoriteArtists);
            foreach (string favoriteArtist in userFavoriteArtists)
            {
                m_UpcomingConcertsListBox.Items.Add($"{favoriteArtist} - {fakeConcerts[favoriteArtist]}");
                i++;
            }
        }

        private Dictionary<string, string> findFavoriteArtistsConcertsAPI(List<string> i_UserFavoriteArtists)
        {
            
            return new Dictionary<string, string>()
                                  {
                                      {i_UserFavoriteArtists[0], "LOUISVILLE, KY, UNITED STATES / SEPTEMBER 24, 2021"},
                                      {i_UserFavoriteArtists[1], "Not on Tour"},
                                      {i_UserFavoriteArtists[2], "Not on Tour"},
                                      {i_UserFavoriteArtists[3], "New York, NY, United States / August 5, 2021" },
                                      {i_UserFavoriteArtists[4] , "Reading, England / August 26-29, 2021" },
                                      {i_UserFavoriteArtists[5], "Yuzawa, Japan / August 20-22, 2021"},
                                      {i_UserFavoriteArtists[6], "Not on Tour"}
                                  };
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void m_UpcomingBirthdaysListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void m_RandomPicture_Click(object sender, EventArgs e)
        {
           FacebookObjectCollection<Photo> taggedPictures  = r_LoggedUser.PhotosTaggedIn;
           if(taggedPictures.Count < 1)
           {
               throw new Exception("No Tagged pictures");
           }
           int randomizedIndex = r_Random.Next(taggedPictures.Count);
           m_RandomPicture.Image = taggedPictures[randomizedIndex].ImageAlbum;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            Close();
        }

        private void m_HomeTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.m_RememberUser = !m_AppSettings.m_RememberUser;
        }
    }
}
