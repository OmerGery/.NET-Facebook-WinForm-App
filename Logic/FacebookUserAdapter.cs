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
        private readonly User m_FacebookUser;
        private readonly Random r_Random = new Random();

        public FacebookUserAdapter(User adaptee)
        {
            m_FacebookUser = adaptee;
        }

        public string GetFirstName()
        {
            return m_FacebookUser.FirstName;
        }

        public string GetLastName()
        {
            return m_FacebookUser.LastName;
        }

        public string GetEmail()
        {
            return m_FacebookUser.Email;
        }
        public Image GetImageSmall()
        {
            return m_FacebookUser.ImageSmall;
        }
        public FacebookObjectCollection<User> GetFriends()
        {
            return m_FacebookUser.Friends;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return m_FacebookUser.LikedPages;
        }

        public FacebookObjectCollection<Event> GetEvents()
        {
            return m_FacebookUser.Events;
        }

        public string GetLocale()
        {
            return m_FacebookUser.Locale;
        }

        

        public string GetBirthday()
        {
            return m_FacebookUser.Birthday;
        }





    public void FetchTopPostByFriend(ref int io_CurrentMaxLikedPost, ref string io_FriendName, ref Post io_MostLikedPost)
        {
            foreach (User friend in m_FacebookUser.Friends)
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
            FacebookObjectCollection<Photo> taggedPictures = m_FacebookUser.PhotosTaggedIn;
            if (taggedPictures.Count< 1)
            {
                throw new Exception("No Tagged pictures");
            }

            int randomizedIndex = r_Random.Next(taggedPictures.Count);
            return taggedPictures[randomizedIndex].ImageAlbum;
        }

        public void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest)
        {
            foreach (User friend in m_FacebookUser.Friends)
            {
                int friendCommonLikedPages = 0;
                foreach (var friendLikedPage in friend.LikedPages)
                {
                    if (m_FacebookUser.LikedPages.Contains(friendLikedPage))
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
            return m_FacebookUser.PhotosTaggedIn.Count;
        }
    }
}
