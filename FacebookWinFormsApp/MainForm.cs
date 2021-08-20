using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        private readonly AppSettings r_AppSettings;
        private readonly Dictionary<string, List<string>> r_SimilarArtistsDictionary = new Dictionary<string, List<string>>();


        public MainForm(AppSettings i_AppSettings)
        {
            InitializeComponent();
            r_AppSettings = i_AppSettings;
            Size = r_AppSettings.LastWindowsSize;
            Location = r_AppSettings.LastWindowsLocation;
            m_RememberMeCheckBox.Checked = r_AppSettings.RememberUser;
            FacebookService.s_CollectionLimit = 100;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = $@"Hello {r_AppLogic.LoggedUser.FirstName} {r_AppLogic.LoggedUser.LastName}!";
            fetchAboutData();
        }

        private void fetchAboutData()
        {
            m_ProfilePicture.Image = r_AppLogic.LoggedUser.ImageSmall;
            m_UserEmailLabel.Text = r_AppLogic.LoggedUser.Email;
            m_BirthdayLabel.Text = r_AppLogic.LoggedUser.Birthday;
            m_PhotosAmountLabel.Text = r_AppLogic.LoggedUser.PhotosTaggedIn.Count.ToString();
            m_LocaleLabel.Text = r_AppLogic.LoggedUser.Locale;
        }

        protected override void OnClosed(EventArgs e)
        {
            r_AppSettings.LastWindowsSize = Size;
            r_AppSettings.LastWindowsLocation = Location;
            r_AppSettings.LastAccessToken = m_RememberMeCheckBox.Checked ? r_AppLogic.AccessToken : null;
            r_AppSettings.SaveSettingsToFile();
            base.OnClosed(e);
        }

        private void fetchEvents()
        {
            FacebookObjectCollection<Event> userEvents = r_AppLogic.LoggedUser.Events;
            updateAmountOfEvents(userEvents.Count);
            foreach (Event userEvent in userEvents)
            {
                long? eventAttendingNumber = userEvent.AttendingCount;

                if (eventAttendingNumber != null)
                {
                    m_UpcomingEventsListBox.Items.Add(
                        $"{userEvent.Name} - {eventAttendingNumber.ToString()} Attendees");
                }
            }

            if (!r_AppSettings.IsMockState && userEvents.Count == 0)
            {
                m_UpcomingEventsListBox.Items.Add("No upcoming events");
            }
            else
            {
                List<string> fakeEvents = MocksGenerator.GetFakeEvents();
                updateAmountOfEvents(fakeEvents.Count);
                foreach (string fakeEvent in fakeEvents)
                {
                    m_UpcomingEventsListBox.Items.Add($"{fakeEvent} Attendees");
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

        private void fetchFriendsWithCommonInterest()
        {
            bool isFriendWithCommonInterest = false;
            Dictionary<string, int> friendsCommonPagesLikes = new Dictionary<string, int>();

            if (r_AppSettings.IsMockState)
            {
                friendsCommonPagesLikes = MocksGenerator.GetFakeFriends();
            }
            else
            {
                r_AppLogic.GetFriendsCommonInterest(ref friendsCommonPagesLikes, ref isFriendWithCommonInterest);
            }

            foreach (KeyValuePair<string, int> friendInDictionary in friendsCommonPagesLikes)
            {
                m_CommonInterestListBox.Items.Add($"{friendInDictionary.Key} - {friendInDictionary.Value.ToString()} Pages");
            }

            if (!isFriendWithCommonInterest && !r_AppSettings.IsMockState)
            {
                m_CommonInterestListBox.Items.Add("No Friends With Common Liked Pages");
            }
        }

        private async void fetchRecommendations()
        {
            List<string> userFavoriteArtists = new List<string>();
            if (r_AppSettings.IsMockState)
            {
                userFavoriteArtists = MocksGenerator.GetFakeArtists();
            }
            else
            {
                foreach (Page artistPage in r_AppLogic.LoggedUser.LikedPages)
                {
                    if (artistPage.Category == "Artist")
                    {
                        userFavoriteArtists.Add(artistPage.Name);
                    }
                }
            }

            foreach (string favoriteArtist in userFavoriteArtists)
            {
                m_FavoriteArtistsListBox.Items.Add($"{favoriteArtist}");

                try
                {
                    XDocument userSimilarArtists = await LastFmApi.GetSimilarArtists(favoriteArtist, m_ArtistsLimitNumericUpDown.Text);
                    List<string> userSimilarArtistsList = LastFmApi.FilterSimilarArtists(userSimilarArtists);
                    r_SimilarArtistsDictionary.Add(favoriteArtist, userSimilarArtistsList);
                }
                catch (Exception lastFmException)
                {
                    MessageBox.Show($@"A Problem with the lastFM API {lastFmException.Message}");
                }
            }

            if (userFavoriteArtists.Count == 0)
            {
                m_FavoriteArtistsListBox.Items.Add("No liked Artists");
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            Close();
        }
        
        private void pictureRandomButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_RandomPicture.Image = r_AppLogic.GetRandomImage();
            }
            catch (Exception pictureException)
            {
                MessageBox.Show($@"An error occurred with the facebook API: {Environment.NewLine} {pictureException.Message}");
            }
        }

        private void recommendationButton_Click(object sender, EventArgs e)
        {
            m_RecommendationButton.Enabled = false;
            m_ArtistsLimitNumericUpDown.Enabled = false;
            fetchRecommendations();
        }

        private void topPostButton_Click(object sender, EventArgs e)
        {
            m_TopPostButton.Enabled = false;
            int maxLikedPost = 0;
            string friendName = null;
            Post mostLikedPost = null;

            r_AppLogic.FetchTopPostByFriend(ref maxLikedPost, ref friendName, ref mostLikedPost);
            if (maxLikedPost == 0)
            {
                m_TrendingPostTextBox.Text = "No liked posts by friends";
            }
            else
            {
                if (mostLikedPost != null)
                {
                    m_TrendingPostTextBox.Text = $" {mostLikedPost.Message} {Environment.NewLine}By {friendName} ({maxLikedPost} likes)";
                }
            }

            if (r_AppSettings.IsMockState)
            {
                string post = MocksGenerator.GetFakePost(out maxLikedPost, out friendName);
                m_TrendingPostTextBox.Text = $"{post} {Environment.NewLine}{Environment.NewLine}By {friendName} ({maxLikedPost} likes)";
            }
        }

        private void birthdaysButton_Click(object sender, EventArgs e)
        {
            m_BirthdaysButton.Enabled = false;
            bool areFriendsBDaysThisMonth = false;

            foreach (User friend in r_AppLogic.LoggedUser.Friends)
            {
                DateTime friendBirthday = DateTime.Parse(friend.Birthday);
                if (friendBirthday.Month == DateTime.Now.Month)
                {
                    areFriendsBDaysThisMonth = true;
                    m_UpcomingBirthdaysListBox.Items.Add($"{friend.Name} - {friend.Birthday} ");
                }
            }

            if (!areFriendsBDaysThisMonth && !r_AppSettings.IsMockState)
            {
                m_UpcomingBirthdaysListBox.Items.Add($"No friends birthdays on {DateTime.Now.ToString("M")}");
            }

            if (r_AppSettings.IsMockState)
            {
                List<string> fakeBirthdays = MocksGenerator.GetFakeBirthdays();
                foreach (string fakeBirthday in fakeBirthdays)
                {
                    m_UpcomingBirthdaysListBox.Items.Add($"{fakeBirthday}");
                }
            }
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            m_EventsButton.Enabled = false;
            fetchEvents();
        }

        private void friendsInterestsButton_Click(object sender, EventArgs e)
        {
            m_FriendsIntrestsButton.Enabled = false;
            fetchFriendsWithCommonInterest();
        }

        private void m_SimilarArtistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_FavoriteArtistsListBox.SelectedItem != null)
            {
                string similarArtistsText = String.Empty;
                int similarArtistIndex = 1;
                string selectedArtist = m_FavoriteArtistsListBox.SelectedItem as string;
                
                foreach(string similarArtists in r_SimilarArtistsDictionary[selectedArtist])
                {
                    similarArtistsText += $"{similarArtistIndex.ToString()}.{similarArtists} {Environment.NewLine}";
                    m_SimilarArtistsTextBox.Text = similarArtistsText;
                    similarArtistIndex++;
                }
                
            }
        }
    }
}