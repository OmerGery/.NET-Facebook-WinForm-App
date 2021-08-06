using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Logic;

namespace BasicFacebookFeatures
{
    public partial class StartForm : Form
    {
        private const string k_AppId = "327180762451294";

        public readonly AppSettings r_AppSettings;

        public LoginResult UserLoginResult { get; private set; }
        

        public StartForm()
        {
            InitializeComponent();
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
                }
                else
                {
                    UserLoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
                }
                Close();
            }

            catch (Exception)
            {
                MessageBox.Show(@"Please enter a valid login and password");
            }
        }
        
    }
}
