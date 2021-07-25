using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private LoginResult m_loginResult;
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

                m_loginResult = FacebookService.Login(
                    /// (This is Desig Patter's App ID. replace it with your own)
                    k_AppId,
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "groups_acces_member_info",
                    "user_photos",
                    "user_birthday",
                    "user_friends"
                    /// add any relevant permissions
                    
                );
                if(m_loginResult.FacebookOAuthResult.IsSuccess)
                {
                    m_IsLoggedIn = true;
                    buttonLogin.Text = "You Are Logged in!";
                    buttonLogin.BackColor = Color.Green;
                    label1.Text = $"Hello {m_loginResult.LoggedInUser.Name} !";
                }
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
    }
}
