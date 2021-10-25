using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class RatingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Add("Sorted By Rating :-)");
        }
    }
}