﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class StartForm : Form
    {
        private const string k_AppId = "1450160541956417";
        private bool m_IsLoggedIn;
        private FormMain m_FormMain;
        public StartForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!m_IsLoggedIn)
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
                if (loginResult.FacebookOAuthResult.IsSuccess)
                {
                    User loggedUser = loginResult.LoggedInUser;
                    m_FormMain = new FormMain(loggedUser);
                    m_IsLoggedIn = true;
                    this.Close();
                    m_FormMain.Show();
                    
                }
                else
                {
                    // show message that login was failed... 
                }
            }
        }
    }
}
