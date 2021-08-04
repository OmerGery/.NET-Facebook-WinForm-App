using System.Drawing;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class MainLogic
    {
        public User LoggedUser { get; };

        public string AccessToken { get; }

        public MainLogic(LoginResult i_LoginResult)
        {
            LoggedUser = i_LoginResult.LoggedInUser;
            AccessToken = i_LoginResult.AccessToken;
        }

        public string GetUserName()
        {
            return LoggedUser.UserName;
        }

        public Image GetProfilePicture()
        {
            return LoggedUser.ImageSmall;
        }
    }
}
