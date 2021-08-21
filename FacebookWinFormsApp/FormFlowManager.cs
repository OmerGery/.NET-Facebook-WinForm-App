using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        private readonly StartForm r_StartForm = new StartForm();

        private MainForm m_FacebookMainForm; 

        public void RunApp()
        {
            try
            {
                r_StartForm.ShowDialog();
                m_FacebookMainForm = new MainForm(r_StartForm.AppSettings);
                if(r_StartForm.IsLoggedIn)
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
