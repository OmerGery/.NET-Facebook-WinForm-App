using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public sealed class AppLogic
    {
        private AppLogic() { }
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
        
    
        private readonly Random r_Random = new Random();

        public User LoggedUser { get; set; }

        public string AccessToken { get; }
        

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

                if(friendCommonLikedPages > 0)
                {
                    io_FriendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
                }
            }
        }
    }
}
