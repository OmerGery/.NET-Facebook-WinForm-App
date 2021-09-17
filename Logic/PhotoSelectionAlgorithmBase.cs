using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            int photoIndex = GetIndexOfPhoto(taggedPictures);
            return taggedPictures[photoIndex].ImageAlbum;
        }

        public abstract int GetIndexOfPhoto(FacebookObjectCollection<Photo> i_Album);
    }

    public class PhotoRandomizer : PhotoSelectionAlgorithmBase
    {

        private readonly Random r_Random = new Random();

        public override int GetIndexOfPhoto(FacebookObjectCollection<Photo> i_Album)
        {
            return r_Random.Next(i_Album.Count);
        }
    }
    

}
