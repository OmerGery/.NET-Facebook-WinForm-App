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
        void sort(List<string> artistListToSort);
    }
    
    public class AscendingArtistSortStrategy : IArtistSortStrategy
    {
        public void sort(List<string> artistListToSort)
        {

            artistListToSort.Add("Ascend");
            artistListToSort.Sort((a, b) => a.CompareTo(b)); 
        }
    }

    public class DescendingArtistSortStrategy : IArtistSortStrategy
    {
        public void sort(List<string> artistListToSort)
        {
            artistListToSort.Add("Desending");
            artistListToSort.Sort((a, b) => b.CompareTo(a));
        }
    }

}
