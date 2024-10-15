using System.Text.Json.Serialization;

namespace DemoCACQRS.External.Spotify.Response
{
    public class Item
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Album? Album { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlbumType { get; set; } // Utile lors de la recherche d'album
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Artist>? Artists { get; set; } // Utile lors de la recherche d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? AvailableMarkets { get; set; } // Utile lors de la recherche d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DiscNumber { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? DurationMs { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? Explicit { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ExternalIds? ExternalIds { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ExternalUrls? ExternalUrls { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Followers? Followers { get; set; } // Utile lors de la recherche d'artiste
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<string>? Genres { get; set; } // Utile lors de la recherche d'artiste
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Href { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Id { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<Image>? Images { get; set; } // Utile lors de la recherche d'artiste et d'album
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public bool? IsLocal { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReleaseDate { get; set; } // Utile lors de la recherche d'album
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReleaseDatePrecision { get; set; } // Utile lors de la recherche d'album
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TotalTracks { get; set; } // Utile lors de la recherche d'album
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Popularity { get; set; } // Utile lors de la recherche d'artiste et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PreviewUrl { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? TrackNumber { get; set; } // Utile lors de la recherche de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Uri { get; set; } // Utile lors de la recherche d'artiste et d'album et de tracks
    }
}
