namespace BasicFacebookFeatures
{
    public class FormFlowManager
    {
        private readonly StartForm r_StartForm = new StartForm();
        private FormMain m_FacebookForm;

        public void RunApp()
        {
            r_StartForm.ShowDialog();
            m_FacebookForm = new FormMain(r_StartForm.UserLoginResult, r_StartForm.m_AppSettings);
            m_FacebookForm.ShowDialog();
        }
    }
}
