﻿namespace DemoCACQRS.External.Spotify.Response
{
    public class Artists
    {
        public string? Href { get; set; }
        public List<Item>? Items { get; set; }
        public int? Limit { get; set; }
        public object? Next { get; set; }
        public int? Offset { get; set; }
        public object? Previous { get; set; }
        public int? Total { get; set; }
    }
}
