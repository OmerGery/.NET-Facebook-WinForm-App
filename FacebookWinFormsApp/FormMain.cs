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

        private readonly AppSettings m_AppSettings = AppSettings.Instance;
        public FormMain(User i_LoggedUser, AppSettings i_AppSettings) 
        {
            r_LoggedUser = i_LoggedUser;
            InitializeComponent();
            this.Size = i_AppSettings.m_LastWindowsSize;
            this.Location = i_AppSettings.m_LastWindowsLocation;
            m_RememberMeCheckBox.Checked = i_AppSettings.m_RememberUser;
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = r_LoggedUser.Name;
            m_ProfilePicture.Image = r_LoggedUser.ImageSmall;
            fetchEvents();
            fetchUpcomingBirthdays();
            fetchConcerts();
            fetchFriendsWithCommonInterest();
            fetchTopPostByFriend();
        }

        protected override void OnClosed(EventArgs e)
        {
             m_AppSettings.m_LastWindowsSize = this.Size ;
            m_AppSettings.m_LastWindowsLocation = this.Location;
            if(m_RememberMeCheckBox.Checked)
            {
               // m_AppSettings.m_LastAccessToken = 
            };
            m_AppSettings.SaveSettingsToFile();
            base.OnClosed(e);
        }

        private void fetchTopPostByFriend()
        {
            int currentMaxLikedPost = 0;
            string friendName = null;
            Post mostLikedPost = null;

            foreach (User friend in r_LoggedUser.Friends)
            {
                foreach(var friendPost in friend.Posts)
                {
                    if(friendPost.LikedBy.Count() > currentMaxLikedPost)
                    {
                        currentMaxLikedPost = friendPost.LikedBy.Count();
                        friendName = friend.Name;
                        mostLikedPost = friendPost;
                    }
                }
            }

            if(currentMaxLikedPost == 0)
            {
                m_TrendingPostListBox.Items.Add("No liked posts by friends");
            }
            else
            {
                m_CommonInterestListBox.Items.Add($" {mostLikedPost.Message} " + 
                                                  $"By {friendName} ({currentMaxLikedPost} likes");
            }
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

        private void fetchUpcomingBirthdays()
        {
            bool areFriendsBdaysThisMonth = false;

            foreach (User friend in r_LoggedUser.Friends)
            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday);
                if(friendBirthday.Month == DateTime.Now.Month)
                {
                    areFriendsBdaysThisMonth = true;
                    m_UpcomingBirthdaysListBox.Items.Add($"{friend.Name} - {friend.Birthday} ");
                }
            }

            if(!areFriendsBdaysThisMonth)
            {
                m_UpcomingBirthdaysListBox.Items.Add($"No friends birthdays on {DateTime.Now.ToString("MMMM")}");
            }
        }

        private void fetchFriendsWithCommonInterest()
        {
            bool isFriendWithCommonInterest = false;
            Dictionary<string, int> friendsCommonPagesLikes = new Dictionary<string, int>();
            
            foreach (User friend in r_LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if(r_LoggedUser.LikedPages.Contains(friendLikedPage))
                    {
                        isFriendWithCommonInterest = true;
                        friendCommonLikedPages++;
                    }
                }

                friendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
            }

            friendsCommonPagesLikes.OrderByDescending(pair => pair.Value);

            foreach(var friendInDictionary in friendsCommonPagesLikes)
            {
                m_CommonInterestListBox.Items.Add($"{friendInDictionary.Key} - {friendInDictionary.Value.ToString()} Pages");
            }

            if(!isFriendWithCommonInterest)
            {
                m_CommonInterestListBox.Items.Add("No Friends With Common Liked Pages");
            }

        }

        async private void fetchConcerts()
        {
            List<string> userFavoriteArtists = new List<string>
                                                   {
                                                       "Metallica",
                                                       "Radiohead",
                                                       "The_Strokes",
                                                       "Pink_Floyd",
                                                       "Doja_Cat",
                                                       "Lady_Gaga",
                                                       "Nirvana"
                                                   };

            foreach (string favoriteArtist in userFavoriteArtists)
            {
                string favoriteAndSimilarArtists = $"{favoriteArtist}  - " ;
                await LastfmAPI.GetSimilarArtists(favoriteArtist);
                List<string> userSimilarArtists = new List<string>();
                userSimilarArtists = LastfmAPI.filterFavoriteArtists();
                foreach(string similarArtist in userSimilarArtists)
                {
                    favoriteAndSimilarArtists += $"{similarArtist} ";
                }

                if(userSimilarArtists.Count > 0)
                {
                    m_UpcomingConcertsListBox.Items.Add(favoriteAndSimilarArtists);
                }
            }

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

        private void m_RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            m_AppSettings.m_RememberUser = !m_AppSettings.m_RememberUser;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
