using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class RecommendationsFacade
    {
        private readonly LastFmApi r_LastFmApi = new LastFmApi();
        private IArtistSortStrategy m_ArtistSortStrategy;

        public async Task<Dictionary<string, List<string>>> GetArtistRecommendations(
            IFacebookUser i_LoggedUser,
            bool i_IsMockState,
            int i_SimilarArtistsAmount,
            string i_SortBy)
        {
            setSortStrategy(i_SortBy);
            Dictionary<string, List<string>> artistsDictionary = new Dictionary<string, List<string>>();
            List<string> userFavoriteArtists = new List<string>();
            if(i_IsMockState)
            {
                userFavoriteArtists = MocksGenerator.GetFakeArtists();
            }
            else
            {
                foreach(Page artistPage in i_LoggedUser.GetLikedPages())
                {
                    if(artistPage.Category == "Artist")
                    {
                        userFavoriteArtists.Add(artistPage.Name);
                    }
                }
            }

            foreach(string favoriteArtist in userFavoriteArtists)
            {
                XDocument userSimilarArtists =
                    await r_LastFmApi.GetSimilarArtists(favoriteArtist, i_SimilarArtistsAmount);
                List<string> userSimilarArtistsList = r_LastFmApi.FilterSimilarArtists(userSimilarArtists);
                m_ArtistSortStrategy.sort(userSimilarArtistsList);
                artistsDictionary.Add(favoriteArtist, userSimilarArtistsList);
            }

            return artistsDictionary;
        }

        private void setSortStrategy(string i_SortBy)
        {
            switch(i_SortBy)
            {
                case "A-Z":
                    m_ArtistSortStrategy = new AscendingArtistSortStrategy();
                    break;
                case "Z-A":
                    m_ArtistSortStrategy = new DescendingArtistSortStrategy();
                    break;
                default:
                    m_ArtistSortStrategy = new RatingArtistSortStrategy();
                    break;
            }
        }
    }
}
