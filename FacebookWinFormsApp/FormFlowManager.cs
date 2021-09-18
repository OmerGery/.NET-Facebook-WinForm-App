using System;
using System.Windows.Forms;
using Logic;

namespace BasicFacebookFeatures
{
    public class FormFlowManager : IExitObserver
    {
        private readonly StartForm r_StartForm = new StartForm();

        private MainForm m_FacebookMainForm;

        public void ExitUpdate()
        {
            MessageBox.Show("Bye Bye :---) ");
        }

        public void RunApp()
        {
            try
            {
                r_StartForm.ShowDialog();
                m_FacebookMainForm = new MainForm(r_StartForm.AppSettings);
                m_FacebookMainForm.Attach(ExitUpdate);
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
