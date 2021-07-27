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
        private const string k_AppId = "1450160541956417";
        private bool m_IsLoggedIn;
        private User m_LoggedUser;
        public FormMain()
        {
            
            m_IsLoggedIn = false;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(!m_IsLoggedIn)
            {
                Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

                LoginResult loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    k_AppId,
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_photos",
                    "user_birthday",
                    "user_friends"
                    /// add any relevant permissions
                    
                );
                if(loginResult.FacebookOAuthResult.IsSuccess)
                {
                    m_LoggedUser = loginResult.LoggedInUser;
                    m_IsLoggedIn = true;
                    buttonLogin.Visible = false;
                    m_UserNameLabel.Text = m_LoggedUser.Name;
                    displayFormObjects();
                }
            }
        }

        private void displayFormObjects()
        {
            m_UserNameLabel.Visible = true;
            m_LoggedInLabel.Visible = true;
            m_ProfilePicture.Visible = true;
            m_RandomPhotoLabel.Visible = true;



            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
               // property.SetValue();
            }
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
