using DemoCACQRS.External.Spotify.Interfaces;
using MediatR;

namespace DemoCACQRS.Application.Songs.Queries
{
    public record GetMusicQuery : IRequest<DtoUpSpotifySong>
    {
        public string? Research { get; set; }
        public string? ResearchType { get; set; }
    }

    public class GetMusicQueryHandler : IRequestHandler<GetMusicQuery,DtoUpSpotifySong> 
    {
        private readonly ISpotifyService _spotifyService;

        public GetMusicQueryHandler(ISpotifyService spotifyService)
        {
            _spotifyService = spotifyService;
        }

        public async Task<DtoUpSpotifySong> Handle(GetMusicQuery request, CancellationToken cancellationToken)
        {
            DtoUpSpotifySong dtoUpSong = new();

            switch (request.ResearchType)
            {
                case "album":

                    dtoUpSong.ResponseAlbum = await _spotifyService.GetAlbums(request.Research, request.ResearchType);

                    break;

                case "artist":

                    dtoUpSong.ResponseArtist = await _spotifyService.GetArtists(request.Research, request.ResearchType);

                    break;

                case "track":

                    dtoUpSong.ResponseTrack = await _spotifyService.GetTracks(request.Research, request.ResearchType);

                    break;

                default:
                    break;
            }

            return dtoUpSong;
        }
    }
}
