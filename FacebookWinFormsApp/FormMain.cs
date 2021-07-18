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
                    "1450160541956417",
                    /// requested permissions:
                    "email",
                    "public_profile"
                    /// add any relevant permissions
                    
                );
                if(m_loginResult.FacebookOAuthResult.IsSuccess)
                {
                    m_IsLoggedIn = true;
                    buttonLogin.Text = $"Logged in as {m_loginResult.LoggedInUser.Name}";
                }
            }
            else
            {
                buttonLogin.Text = m_loginResult.LoggedInUser.Birthday;
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
