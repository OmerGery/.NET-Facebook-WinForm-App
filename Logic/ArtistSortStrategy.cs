using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IArtistSortStrategy
    {
        void Sort(List<string> artistListToSort);
    }
    
    public class AscendingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Sort((a, b) => a.CompareTo(b)); 
        }
    }

    public class DescendingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Sort((a, b) => b.CompareTo(a));
        }
    }
    public class RatingArtistSortStrategy : IArtistSortStrategy
    {
        public void Sort(List<string> artistListToSort)
        {
            artistListToSort.Add("Sorted By Rating :-)");
        }
    }

}
