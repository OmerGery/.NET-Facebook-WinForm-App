using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class FacebookUserAdapter : IFacebookUser
    {
        private readonly User r_FacebookUser;
        private readonly Random r_Random = new Random();

        public FacebookUserAdapter(User adaptee)
        {
            r_FacebookUser = adaptee;
        }

        public string GetFirstName()
        {
            return r_FacebookUser.FirstName;
        }

        public string GetLastName()
        {
            return r_FacebookUser.LastName;
        }

        public string GetEmail()
        {
            return r_FacebookUser.Email;
        }

        public Image GetImageSmall()
        {
            return r_FacebookUser.ImageSmall;
        }

        public FacebookObjectCollection<User> GetFriends()
        {
            return r_FacebookUser.Friends;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return r_FacebookUser.LikedPages;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return r_FacebookUser.Events;
        }

        public string GetLocale()
        {
            return r_FacebookUser.Locale;
        }

        public string GetBirthday()
        {
            return r_FacebookUser.Birthday;
        }

    public void FetchTopPostByFriend(ref int io_CurrentMaxLikedPost, ref string io_FriendName, ref Post io_MostLikedPost)
        {
            foreach (User friend in r_FacebookUser.Friends)
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
            FacebookObjectCollection<Photo> taggedPictures = r_FacebookUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        public void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in r_FacebookUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if (r_FacebookUser.LikedPages.Contains(friendLikedPage))
                    {
                        io_IsFriendWithCommonInterest = true;
                        friendCommonLikedPages++;
                    }
                }

                if (friendCommonLikedPages > 0)
                {
                    io_FriendsCommonPagesLikes.Add(friend.Name, friendCommonLikedPages);
                }
            }
        }

        public int GetPhotosTaggedInAmount()
        {
            return r_FacebookUser.PhotosTaggedIn.Count;
        }
    }
}
