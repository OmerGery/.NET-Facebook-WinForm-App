﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using FacebookWrapper.ObjectModel;

namespace Logic
{
    public class RecommendationsFacade
    {
        private LastFmApi m_LastFmApi = new LastFmApi();

        public async Task<Dictionary<string, List<string>>> GetArtistRecommendations(
            IFacebookUser i_LoggedUser,
            AppSettings i_AppSettings,
            int i_SimilarArtistsAmount)
        {
            Dictionary<string, List<string>> artistsDictionary = new Dictionary<string, List<string>>();
            List<string> userFavoriteArtists = new List<string>();
            if(i_AppSettings.IsMockState)
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
                    await m_LastFmApi.GetSimilarArtists(favoriteArtist, i_SimilarArtistsAmount);
                List<string> userSimilarArtistsList = m_LastFmApi.FilterSimilarArtists(userSimilarArtists);
                artistsDictionary.Add(favoriteArtist, userSimilarArtistsList);
            }

            return artistsDictionary;
        }
    }
}