using DemoCACQRS.External.Common;
using DemoCACQRS.External.Spotify.Response;

namespace DemoCACQRS.External.Spotify.Interfaces
{
    public interface ISpotifyService
    {
        Task<ResponseAlbum> GetAlbums(string recherche, string typeRecherche);
        Task<ResponseTrack> GetTracks(string recherche, string typeRecherche);
        Task<ResponseArtist> GetArtists(string recherche, string typeRecherche);
        Task<TokenSpotify> GetToken();
    }
}
