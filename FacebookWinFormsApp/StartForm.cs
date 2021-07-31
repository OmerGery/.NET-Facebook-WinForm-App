using System;
using System.Linq.Expressions;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class StartForm : Form
    {
        private const string k_AppId = "327180762451294";
        private bool m_IsLoggedIn;
        //public AppSettings m_AppSettings;

        public User m_LoggedUser { get; set; }

        public StartForm()
        {
            InitializeComponent();
            //m_AppSettings = AppSettings.LoadSettingsFromFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                
                LoginResult loginResult = FacebookService.Connect("EAAUm6cZC4eUEBAJypJGsyXHIZB9uxv4PPaQhZBzSHDpoy1z9YVBa4dZBnhPb2lsQiAY4eKBZAHXvZAjB6kMnJooZBo57pphzTnv5d8qUkZBC1fZBSQyZBZAQVQkpUx0tYfus2ZB6KunmZBeeMzasSLwaTiVGvGJBzr1EbYXdXnmVHbbsQUAZDZD");
                if(!m_IsLoggedIn)
                {
                //    Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter
                //LoginResult loginResult = FacebookService.Login(
                    //    k_AppId,
                    //    /// requested permissions:
                    //    "email",
                    //    "public_profile",
                    //    "user_photos",
                    //    "user_events",
                    //    "user_birthday",
                    //    "user_friends");
                    //if(loginResult.FacebookOAuthResult.IsSuccess)
                    //{
                        m_LoggedUser = loginResult.LoggedInUser;
                        m_IsLoggedIn = true;
                        Close();
                //    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter a valid login and password");
            }

        }
        

    }
}
