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

        private readonly AppLogic r_AppLogic = AppLogic.Instance;

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
                bool loggedIn = false;
                r_AppLogic.Connect(AppSettings.LastAccessToken, k_AppId, ref loggedIn);
                IsLoggedIn = loggedIn;
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
