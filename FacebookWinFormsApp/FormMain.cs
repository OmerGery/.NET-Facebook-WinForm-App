using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly Random r_Random = new Random();
        private MainLogic m_Logic;
        private readonly AppSettings r_AppSettings;
        
        public FormMain(LoginResult i_LoginResult, AppSettings i_AppSettings) 
        {
            InitializeComponent();
            r_AppSettings = i_AppSettings;
            Size = r_AppSettings.LastWindowsSize;
            Location = r_AppSettings.LastWindowsLocation;
            m_RememberMeCheckBox.Checked = r_AppSettings.RememberUser;
            m_Logic = new MainLogic(i_LoginResult);
            FacebookService.s_CollectionLimit = 100;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = m_Logic.LoggedUser.UserName;
            m_ProfilePicture.Image = m_Logic.LoggedUser.ImageSmall;
        }

        protected override void OnClosed(EventArgs e)
        {
            r_AppSettings.LastWindowsSize = Size;
            r_AppSettings.LastWindowsLocation = Location;

            r_AppSettings.LastAccessToken = m_RememberMeCheckBox.Checked ? m_Logic.AccessToken: null;

            r_AppSettings.SaveSettingsToFile();
            base.OnClosed(e);
        }


        private void fetchEvents()
        {
            FacebookObjectCollection<Event> userEvents = m_Logic.LoggedUser.Events;
            updateAmountOfEvents(userEvents.Count);
            foreach(var userEvent in userEvents)
            { 
                long? eventAttendingNumber = userEvent.AttendingCount;

                if(eventAttendingNumber != null)
                {
                    m_UpcomingEventsListBox.Items.Add($"{userEvent.Name} - {eventAttendingNumber.ToString()} Attendees");
                }
            }
            
        }

        private void updateAmountOfEvents(int i_UserEventsCount)
        {
            string newLabelText = m_EventsAmountLabel.Text;
            newLabelText = newLabelText.Remove(newLabelText.Length - 1, 1);
            newLabelText = newLabelText.Insert(newLabelText.Length, i_UserEventsCount.ToString());
            m_EventsAmountLabel.Text = newLabelText;
        }

        private void fetchUpcomingBirthdays()
        {
            bool areFriendsBdaysThisMonth = false;

            foreach (User friend in m_Logic.LoggedUser.Friends)
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
            getFriendsCommonInterstest(ref friendsCommonPagesLikes, ref isFriendWithCommonInterest);
            foreach(var friendInDictionary in friendsCommonPagesLikes)
            {
                m_CommonInterestListBox.Items.Add($"{friendInDictionary.Key} - {friendInDictionary.Value.ToString()} Pages");
            }

            if(!isFriendWithCommonInterest)
            {
                m_CommonInterestListBox.Items.Add("No Friends With Common Liked Pages");
            }
        }

        private void getFriendsCommonInterstest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in m_Logic.LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if (m_Logic.LoggedUser.LikedPages.Contains(friendLikedPage))
                    {
                        io_IsFriendWithCommonInterest = true;
                        friendCommonLikedPages++;
                    }
                }

                io_FriendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
            }

            io_FriendsCommonPagesLikes.OrderByDescending(pair => pair.Value);
        }

        private async void fetchRecommendations()
        {

            List<string> fabricatedUserFavoriteArtists = new List<string>
                                                             {
                                                                 "Cat Stevens",
                                                                 "Cheetah Girls",
                                                                 "Cat Power",
                                                                 "One Day As A Lion",
                                                                 "Def Leopard",
                                                                 "Stray Cats",
                                                                 "Lady Gaga",
                                                                 "Nirvana",
                                                                 "Radiohead",
                                                                 "Pink Floyd",

                                                             };

            foreach (string favoriteArtist in fabricatedUserFavoriteArtists)
            {
                List<string> userSimilarArtistsList = new List<string>();
                string favoriteAndSimilarArtists = $"{favoriteArtist}  - / ";
                XDocument userSimilarArtists = await LastFmApi.GetSimilarArtists(favoriteArtist);
                userSimilarArtistsList = LastFmApi.FilterSimilarArtists(userSimilarArtists);
                foreach(string similarArtist in userSimilarArtistsList)
                {
                    favoriteAndSimilarArtists += $"{similarArtist} / ";
                }

                if(userSimilarArtistsList.Count > 0)
                {
                    m_SimilarArtistsListBox.Items.Add(favoriteAndSimilarArtists);
                }
            }
        }
        
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            Close();
        }

        private void m_RememberMeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeUserRemembrance();
        }

        private void ChangeUserRemembrance()
        {
            r_AppSettings.RememberUser = !r_AppSettings.RememberUser;
        }

        private void m_PictureRandomizerButton_Click(object sender, EventArgs e)
        {
            m_RandomPicture.Image = GetRandomImage();
        }

        private Image GetRandomImage()
        {
            FacebookObjectCollection<Photo> taggedPictures = m_Logic.LoggedUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        private void recommendationButton_Click(object sender, EventArgs e)
        {
            fetchRecommendations();
        }

        private void topPostButton_Click(object sender, EventArgs e)
        {

            int currentMaxLikedPost = 0;
            string friendName = null;
            Post mostLikedPost = null;
            
            m_Logic.FetchTopPostByFriend(ref currentMaxLikedPost,ref friendName,ref mostLikedPost);
            if (currentMaxLikedPost == 0)
            {
                m_TrendingPostListBox.Items.Add("No liked posts by friends");
            }
            else
            {
                if (mostLikedPost != null)
                {
                    m_CommonInterestListBox.Items.Add(
                        $" {mostLikedPost.Message} By {friendName} ({currentMaxLikedPost} likes");
                }
            }
        }

        private void birthdaysButton_Click(object sender, EventArgs e)
        {
            fetchUpcomingBirthdays();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }
    }
}
