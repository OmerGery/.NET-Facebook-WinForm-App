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
        private User m_LoggedUser;
        public FormMain(User i_LoggedUser)
        {
            m_LoggedUser = i_LoggedUser;
            InitializeComponent();
            m_UserNameLabel.Text = i_LoggedUser.Name;
            m_ProfilePicture.Image = i_LoggedUser.ImageSmall;
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
			FacebookService.LogoutWithUI();
			buttonLogin.Text = "Login";
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
    }
}
