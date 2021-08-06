using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class StartForm : Form
    {
        private const string k_AppId = "327180762451294";

        public readonly AppSettings r_AppSettings = AppSettings.Instance;

        public LoginResult UserLoginResult { get; private set; }

        public bool LoggedIn { get; set; }


        public StartForm()
        {
            InitializeComponent();
            m_MockModeCheckBox.Checked = true;
            r_AppSettings = AppSettings.LoadSettingsFromFile();
        }

         void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(r_AppSettings.LastAccessToken))
                {
                    UserLoginResult = FacebookService.Login(
                        k_AppId,
                        "email",
                        "public_profile",
                        "user_photos",
                        "user_events",
                        "user_birthday",
                        "user_friends");
                    if(UserLoginResult.FacebookOAuthResult.IsSuccess)
                    {
                        LoggedIn = true;
                    }
                }
                else
                {
                    UserLoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                    LoggedIn = true;
                }
                Close();
            }

            catch (Exception)
            {
                MessageBox.Show(@"Please enter a valid login and password");
            }
            
        }
         protected override void OnClosed(EventArgs e)
         {
             r_AppSettings.IsMockState = m_MockModeCheckBox.Checked;
             base.OnClosed(e);
         }

    }
}
