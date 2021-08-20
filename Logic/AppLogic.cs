using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
   

    public sealed class AppLogic
    {

        private AppLogic()
        { 
        }
            private static AppLogic instance = null;
            public static AppLogic Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new AppLogic();
                    }
                    return instance;
                }
            }
            
        public string AccessToken { get; }
        

        private IFacebookUser m_FacebookUser;
        public IFacebookUser GetUser()
        {
            return m_FacebookUser;
        }


       
        public void Connect(string i_AppSettingsLastAccessToken, string i_AppId,ref bool io_IsLoggedIn)
        {
            m_FacebookUser = FacebookConnector.Connect(i_AppSettingsLastAccessToken, i_AppId, ref io_IsLoggedIn);
        }
    }
}
