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
        private const string k_GetRequestBaseUri = "http://ws.audioscrobbler.com/2.0/?method=artist.getsimilar";
        private static readonly HttpClient sr_HttpClient = new HttpClient();

        public static async Task<XDocument> GetSimilarArtists(string i_ArtistName)
        {
            string parametersUri = $"&api_key={k_LastFmToken}&artist={i_ArtistName}&format=xml&limit={k_Limit}";
            string response = await sr_HttpClient.GetStringAsync(k_GetRequestBaseUri + parametersUri);
            return XDocument.Parse(response);
        }

        public static List<string> FilterSimilarArtists(XDocument i_XDocument)
        {
            List<string> artistsNames = new List<string>();
            foreach (XElement element in i_XDocument.Descendants().Where(io_XElement => io_XElement.HasElements == false))
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
