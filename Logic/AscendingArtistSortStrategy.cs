using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AscendingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Sort((a, b) => a.CompareTo(b));
        }
    }
}