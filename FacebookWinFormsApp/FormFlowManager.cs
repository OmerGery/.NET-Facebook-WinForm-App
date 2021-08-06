﻿using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        private readonly StartForm r_StartForm = new StartForm();
        private FormMain m_FacebookForm;

        public void RunApp()
        {
            try
            {
                r_StartForm.ShowDialog();
                m_FacebookForm = new FormMain(r_StartForm.UserLoginResult, r_StartForm.AppSettings);
                if(r_StartForm.LoggedIn)
                {
                    m_FacebookForm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($@"An error occurred: {ex.Message} {Environment.NewLine} The App will close now.");
            }
        }
    }
}
