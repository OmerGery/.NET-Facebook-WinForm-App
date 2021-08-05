using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class MainLogic
    {
        public User LoggedUser { get; }

        public string AccessToken { get; }

        public MainLogic(LoginResult i_LoginResult)
        {
            LoggedUser = i_LoginResult.LoggedInUser;
            AccessToken = i_LoginResult.AccessToken;
        }
        public void FetchTopPostByFriend(ref int io_CurrentMaxLikedPost, ref string io_FriendName, ref Post io_MostLikedPost)
        {

            foreach (User friend in LoggedUser.Friends)
            {
                foreach (var friendPost in friend.Posts)
                {
                    if (friendPost.LikedBy.Count() > io_CurrentMaxLikedPost)
                    {
                        io_CurrentMaxLikedPost = friendPost.LikedBy.Count();
                        io_FriendName = friend.Name;
                        io_MostLikedPost = friendPost;
                    }
                }
            }
        }
    }
}
