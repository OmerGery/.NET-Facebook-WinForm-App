using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly Random r_Random = new Random();
        private User m_LoggedUser;
        public FormMain(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            m_UserNameLabel.Text = m_LoggedUser.Name;
            m_ProfilePicture.Image = m_LoggedUser.ImageSmall;
            fetchEvents();
        }

        private void fetchEvents()
        {
            foreach(var userEvent in m_LoggedUser.Events)
            {
                string userEventLocation = userEvent.Location;
                userEventLocation = userEventLocation.Replace("Name", "").Replace(", URL:", " ");
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
           FacebookObjectCollection<Photo> taggedPictures  = m_LoggedUser.PhotosTaggedIn;
           if(taggedPictures.Count < 1)
           {
               throw new Exception("No Tagged pictures");
           }
           int randomizedIndex = r_Random.Next(taggedPictures.Count);
           m_RandomPicture.Image = taggedPictures[randomizedIndex].ImageAlbum;
        }
    }
}
