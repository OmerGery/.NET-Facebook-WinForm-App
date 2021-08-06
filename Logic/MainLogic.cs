using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class MainLogic
    {

        private readonly Random r_Random = new Random();
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
        public Image GetRandomImage()
        {
            FacebookObjectCollection<Photo> taggedPictures = LoggedUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }
        public void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in LoggedUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if (LoggedUser.LikedPages.Contains(friendLikedPage))
                    {
                        io_IsFriendWithCommonInterest = true;
                        friendCommonLikedPages++;
                    }
                }

                io_FriendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
            }

            io_FriendsCommonPagesLikes.OrderByDescending(pair => pair.Value);
        }
    }
}
