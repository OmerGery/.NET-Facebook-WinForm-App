using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class PhotoRandomizer : PhotoSelectionAlgorithmBase
    {

        private readonly Random r_Random = new Random();

        protected override Image GetImageFromAlbum(FacebookObjectCollection<Photo> i_Album)
        {
            return i_Album[r_Random.Next(i_Album.Count)].ImageAlbum;
        }
    }
}
