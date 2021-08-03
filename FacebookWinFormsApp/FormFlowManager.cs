using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        public readonly StartForm m_StartForm = new StartForm();
        public FormMain m_FacebookForm;

        public void RunApp()
        {
            m_StartForm.ShowDialog();
            m_FacebookForm = new FormMain(m_StartForm.UserLoginResult, m_StartForm.m_AppSettings);
            m_FacebookForm.ShowDialog();
        }
    }
}
