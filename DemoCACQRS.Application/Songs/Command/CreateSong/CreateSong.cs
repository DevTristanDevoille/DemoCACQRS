using DemoCACQRS.Domain.Entities;
using DemoCACQRS.Persistence.DemoCACQRSContext;
using MediatR;

namespace PlayListService.Application.Songs.Commands.CreateSong
{
    public record CreateSongCommand : IRequest<int>
    {
        public string? Name { get; set; }
        public string? Lien { get; set; }
    }

    public class CreateSongCommandHandler : IRequestHandler<CreateSongCommand, int>
    {
        private readonly DemoCACQRSDbContext _context;

        public CreateSongCommandHandler(DemoCACQRSDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateSongCommand request, CancellationToken cancellationToken)
        {
            var entity = new Song()
            {
                Lien = request.Lien,
                Name = request.Name
            };

            _context.Songs.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            var result = _context.Songs.FirstOrDefault(s => s.Name == request.Name && s.Lien == request.Lien);

            return (int)result.Id;
        }
    }
}
