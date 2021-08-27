using FacebookWrapper;
using Logic;

public class FacebookConnector
{
    public static IFacebookUser Connect(string i_Token, string i_AppId, ref bool io_IsLoggedIn)
    {
        LoginResult loginResult;
        if (string.IsNullOrEmpty(i_Token))
        {
            loginResult = FacebookService.Login(
                i_AppId,
                "email",
                "public_profile",
                "user_photos",
                "user_events",
                "user_birthday",
                "user_friends");
            if (loginResult.FacebookOAuthResult.IsSuccess)
            {
                AppLogic.Instance.AccessToken = loginResult.AccessToken;
                io_IsLoggedIn = true;
            }
        }
        else
        {
            loginResult = FacebookService.Connect(i_Token);
            io_IsLoggedIn = true;
        }

        return new FacebookUserProxy(loginResult.LoggedInUser);
    }
}