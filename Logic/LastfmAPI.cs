using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic
{
    public static class LastFmApi
    {
        private const string k_LastFmToken = "e55a6c4ec6ffa24e98f249adc405865d";
        private const string k_Limit = "3";
        private static readonly string sr_getRequestBaseUri = "http://ws.audioscrobbler.com/2.0/?method=artist.getsimilar";
        private static readonly HttpClient sr_HttpClient = new HttpClient();
        private static XDocument s_XDocument = new XDocument();

        public static async Task GetSimilarArtists(string i_ArtistName)
        {
            string parametersUri = $"&api_key={k_LastFmToken}&artist={i_ArtistName}&format=xml&limit={k_Limit}";
            string response = await sr_HttpClient.GetStringAsync(sr_getRequestBaseUri + parametersUri);
            s_XDocument = XDocument.Parse(response);
        }

        public static List<string> FilterFavoriteArtists()
        {
            List<string> artistsNames = new List<string>();
            foreach (XElement element in s_XDocument.Descendants().Where(i_Xelement => i_Xelement.HasElements == false))
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
