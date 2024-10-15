using DemoCACQRS.Persistence.DemoCACQRSContext;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DemoCACQRS.Application.Songs.Queries
{

    public record GetAllMusicQuery : IRequest<List<DtoUpSong>>
    {
    }

    public class GetAllMusicQueryHandler : IRequestHandler<GetAllMusicQuery, List<DtoUpSong>>
    {
        private readonly DemoCACQRSDbContext _context;

        public GetAllMusicQueryHandler(DemoCACQRSDbContext context)
        {
            _context = context;
        }

        public async Task<List<DtoUpSong>> Handle(GetAllMusicQuery request, CancellationToken cancellationToken)
        {
            return await _context.Songs
                .Select((music) => new DtoUpSong { Id = music.Id, Name = music.Name, Lien = music.Lien })
                .ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
