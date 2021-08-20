using System;
using System.Windows.Forms;
using FacebookWrapper;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class StartForm : Form
    {
        private const string k_AppId = "327180762451294";

        public AppSettings AppSettings { get; }

        public LoginResult UserLoginResult { get; private set; }

        public bool IsLoggedIn { get; private set; }

        public StartForm()
        {
            InitializeComponent();
            m_MockModeCheckBox.Checked = true;
            AppSettings = AppSettings.LoadSettingsFromFile();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(AppSettings.LastAccessToken))
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
                        IsLoggedIn = true;
                    }
                }
                else
                {
                    UserLoginResult = FacebookService.Connect(AppSettings.LastAccessToken);
                    IsLoggedIn = true;
                }
                AppLogic.Instance.LoggedUser = UserLoginResult.LoggedInUser;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Please enter a valid login and password");
            }
        }

         protected override void OnClosed(EventArgs e)
         {
             AppSettings.IsMockState = m_MockModeCheckBox.Checked;
             base.OnClosed(e);
         }
    }
}
