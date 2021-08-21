using System.Collections.Generic;
using System.Drawing;
using FacebookWrapper.ObjectModel;

public interface IFacebookUser
{
    string GetFirstName();

    string GetLastName();

    string GetEmail();

    Image GetImageSmall();

    string GetBirthday();

    string GetLocale();

    FacebookObjectCollection<Event> GetEvents();

    FacebookObjectCollection<Page> GetLikedPages();

    FacebookObjectCollection<User> GetFriends();

    void FetchTopPostByFriend(ref int io_CurrentMaxLikedPost, ref string io_FriendName, ref Post io_MostLikedPost);

    Image GetRandomImage();

    void GetFriendsCommonInterest(ref Dictionary<string, int> io_FriendsCommonPagesLikes, ref bool io_IsFriendWithCommonInterest);

    int GetPhotosTaggedInAmount();
}