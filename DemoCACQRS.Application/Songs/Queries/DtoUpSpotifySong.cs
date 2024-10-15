using DemoCACQRS.External.Spotify.Response;
using System.Text.Json.Serialization;

namespace DemoCACQRS.Application.Songs.Queries
{
    public class DtoUpSpotifySong
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ResponseTrack? ResponseTrack { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ResponseAlbum? ResponseAlbum { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ResponseArtist? ResponseArtist { get; set; }
    }
}
