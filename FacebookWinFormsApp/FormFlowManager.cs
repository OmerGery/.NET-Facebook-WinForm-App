using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        private StartForm m_StartForm = new StartForm();
        private MainForm m_FacebookMainForm; 
        public void RunApp()
        {
            try
            {
                m_StartForm.ShowDialog();
                m_FacebookMainForm = new MainForm(m_StartForm.AppSettings);
                if(m_StartForm.IsLoggedIn)
                {
                    m_FacebookMainForm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message} {Environment.NewLine} The App will close now.");
            }
        }
    }
}
