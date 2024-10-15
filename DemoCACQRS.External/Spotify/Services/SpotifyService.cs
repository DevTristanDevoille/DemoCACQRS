using DemoCACQRS.External.Common;
using DemoCACQRS.External.Common.Interfaces;
using DemoCACQRS.External.Spotify.Interfaces;
using DemoCACQRS.External.Spotify.Response;
using Newtonsoft.Json;

namespace CatalogService.External.Spotify.Services
{

    public class SpotifyService : ISpotifyService
    {
        #region Privates
        private readonly IHttpService _httpService;
        #endregion

        #region CTOR
        public SpotifyService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        #endregion

        #region GetToken
        public async Task<TokenSpotify> GetToken()
        {


            var url = "https://accounts.spotify.com/api/token";

            var body = new List<KeyValuePair<string, string>>
            {
                new("grant_type","client_credentials"),
                new("client_id", "bb6984d892c140e3a2e042c548bf6242"),
                new("client_secret", "e17160e96673433db1c4957cab6d1abe")
            };

            var client = new HttpClient();
            var req = new HttpRequestMessage(HttpMethod.Post, url) { Content = new FormUrlEncodedContent(body) };
            var res = await client.SendAsync(req);

            var result = JsonConvert.DeserializeObject<TokenSpotify>(await res.Content.ReadAsStringAsync());

            return result;

        }
        #endregion

        #region GetAlbums
        public async Task<ResponseAlbum> GetAlbums(string recherche,string typeRecherche)
        {
            var token = await GetToken();

            var url = Constant.UrlSpotify + "?q=" + recherche + "&type=" + typeRecherche;

            var result = await _httpService.SendHttpRequest<ResponseAlbum>(url, HttpMethod.Get, null, token.Access_token);

            return result;
        }
        #endregion

        #region GetTracks
        public async Task<ResponseTrack> GetTracks(string recherche, string typeRecherche)
        {
            var token = await GetToken();

            var url = Constant.UrlSpotify + "?q=" + recherche + "&type=" + typeRecherche;

            var result = await _httpService.SendHttpRequest<ResponseTrack>(url, HttpMethod.Get, null, token.Access_token);

            return result;
        }
        #endregion

        #region GetArtists
        public async Task<ResponseArtist> GetArtists(string recherche, string typeRecherche)
        {
            try
            {
                var token = await GetToken();

                var url = Constant.UrlSpotify + "?q=" + recherche + "&type=" + typeRecherche;

                var result = await _httpService.SendHttpRequest<ResponseArtist>(url, HttpMethod.Get, null, token.Access_token);

                return result;
            }
            catch (AggregateException e)
            {

                throw e;
            }
        }
        #endregion
    }
}
