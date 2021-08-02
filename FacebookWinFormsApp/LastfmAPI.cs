using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BasicFacebookFeatures
{
    static class LastfmAPI
    {
        private static readonly string sr_LastfmToken = "e55a6c4ec6ffa24e98f249adc405865d";
        private static readonly string sr_Limit = "3";
        private static readonly string sr_getRequestBaseUri = "http://ws.audioscrobbler.com/2.0/?method=artist.getsimilar";
        private static readonly HttpClient m_HttpClient = new HttpClient();
        private static XDocument m_XDocument = new XDocument();

        public static async Task<List<string>> GetSimilarArtists(string i_ArtistName)
        {
            string parametersUri = $"&api_key={sr_LastfmToken}&artist={i_ArtistName}&format=xml&limit={sr_Limit}";
            string response = await m_HttpClient.GetStringAsync(sr_getRequestBaseUri + parametersUri);
            Console.WriteLine(response);
            m_XDocument = XDocument.Parse(response);
            List<string> artistsNames = new List<string>();
            artistsNames = filterFavoriteArtists();

            return artistsNames;
        }

        private static List<string> filterFavoriteArtists()
        {

            List<string> artistsNames = new List<string>();
            foreach (XElement element in m_XDocument.Descendants().Where(p => p.HasElements == false))
            {
                string keyName = element.Name.LocalName;
                if (keyName == "name")
                {
                    artistsNames.Add(element.Value);
                }
            }

            return artistsNames;
        }
    }
}
