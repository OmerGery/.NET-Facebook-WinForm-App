using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly Random r_Random = new Random();
        private readonly User r_LoggedUser;
        public FormMain(User i_LoggedUser)
        {
            r_LoggedUser = i_LoggedUser;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = r_LoggedUser.Name;
            m_ProfilePicture.Image = r_LoggedUser.ImageSmall;
            fetchEvents();  
        }

        private void fetchEvents()
        {
            FacebookObjectCollection<Event> userEvents = r_LoggedUser.Events;
            m_UpcomingEventsLabel.Text = $@" {userEvents.Count} {m_UpcomingEventsLabel.Text}";
            foreach(var userEvent in userEvents)
            {
                string userEventLocation = String.Empty;
                if (!string.IsNullOrEmpty(userEvent.Location))
                {
                    userEventLocation = userEvent.Location;
                    userEventLocation = userEventLocation.Replace("Name", "").Replace(", URL:", " ");
                }
                m_UpcomingEventsListBox.Items.Add($"{userEvent.Name} {userEventLocation}");
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void m_UserName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
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
    }
}
