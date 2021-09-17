using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public abstract class PhotoSelectionAlgorithmBase
    {

        public Image GetPhoto(User i_FacebookUser)
        {

            FacebookObjectCollection<Photo> taggedPictures = i_FacebookUser.PhotosTaggedIn;
            if (taggedPictures.Count < 1)
            {
                throw new Exception("No Tagged pictures");
            }

            return GetImageFromAlbum(taggedPictures);
        }

        public abstract Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album);
    }

    public class PhotoRandomizer : PhotoSelectionAlgorithmBase
    {

        private readonly Random r_Random = new Random();

        public override Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album)
        {
            return i_Album[r_Random.Next(i_Album.Count)].ImageAlbum;
        }
    }


}
