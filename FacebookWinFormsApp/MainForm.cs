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
        private RecommendationsFacade m_RecommendationsFacade = new RecommendationsFacade();
        private IFacebookUser LoggedUser {get;}
        private readonly AppLogic r_AppLogic = AppLogic.Instance;
        private readonly AppSettings r_AppSettings;
        private Dictionary<string, List<string>> m_SimilarArtistsDictionary = new Dictionary<string, List<string>>();


        public MainForm(AppSettings i_AppSettings)
        {
            InitializeComponent();
            r_AppSettings = i_AppSettings;
            Size = r_AppSettings.LastWindowsSize;
            Location = r_AppSettings.LastWindowsLocation;
            m_RememberMeCheckBox.Checked = r_AppSettings.RememberUser;
            FacebookService.s_CollectionLimit = 100;
            LoggedUser = r_AppLogic.GetUser();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = $@"Hello {LoggedUser.GetFirstName()} {LoggedUser.GetLastName()}!";
            fetchAboutData();
        }

        private void fetchAboutData()
        {
            m_ProfilePicture.Image = LoggedUser.GetImageSmall();
            m_UserEmailLabel.Text = LoggedUser.GetEmail();
            m_BirthdayLabel.Text = LoggedUser.GetBirthday();
            m_PhotosAmountLabel.Text = LoggedUser.GetPhotosTaggedInAmount().ToString();
            m_LocaleLabel.Text = LoggedUser.GetLocale();
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
            FacebookObjectCollection<Event> userEvents = LoggedUser.GetEvents();
            updateAmountOfEvents(userEvents.Count);

            if (r_AppSettings.IsMockState)
            {
                List<string> fakeEvents = MocksGenerator.GetFakeEvents();
                updateAmountOfEvents(fakeEvents.Count);
                foreach (string fakeEvent in fakeEvents)
                {
                    m_UpcomingEventsListBox.Items.Add($"{fakeEvent} Attendees");
                }
            }
            else
            {
                this.m_UpcomingEventsListBox.DataSource = this.eventBindingSource;
                eventBindingSource.DataSource = LoggedUser.GetEvents();
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
                LoggedUser.GetFriendsCommonInterest(ref friendsCommonPagesLikes, ref isFriendWithCommonInterest);
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
            try
            {
                m_SimilarArtistsDictionary = await m_RecommendationsFacade.GetArtistRecommendations(
                                                 LoggedUser,
                                                 r_AppSettings.IsMockState,
                                                 int.Parse(m_ArtistsLimitNumericUpDown.Text));
            }
            catch (Exception facadeException)
            {
                MessageBox.Show($@"A Problem with the Recommendations API {facadeException.Message}");
            }


            foreach (string favoriteArtist in m_SimilarArtistsDictionary.Keys)
            {
                m_FavoriteArtistsListBox.Items.Add($"{favoriteArtist}");

            }

            if (m_SimilarArtistsDictionary.Keys.Count == 0)
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
                m_RandomPicture.Image = LoggedUser.GetRandomImage();
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

            LoggedUser.FetchTopPostByFriend(ref maxLikedPost, ref friendName, ref mostLikedPost);
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

            foreach (User friend in LoggedUser.GetFriends())
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

        private void similarArtistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(m_FavoriteArtistsListBox.SelectedItem != null)
            {
                string similarArtistsText = String.Empty;
                int similarArtistIndex = 1;
                string selectedArtist = m_FavoriteArtistsListBox.SelectedItem as string;
                
                foreach(string similarArtists in m_SimilarArtistsDictionary[selectedArtist])
                {
                    similarArtistsText += $"{similarArtistIndex.ToString()}.{similarArtists} {Environment.NewLine}";
                    m_SimilarArtistsTextBox.Text = similarArtistsText;
                    similarArtistIndex++;
                }
                
            }
        }

    }

}