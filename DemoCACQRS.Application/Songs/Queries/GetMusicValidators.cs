using FluentValidation;

namespace DemoCACQRS.Application.Songs.Queries
{
    public class GetMusicValidators : AbstractValidator<GetMusicQuery>
    {
        public GetMusicValidators()
        {
            RuleFor(x => x.Research)
                .NotEmpty();

            RuleFor(x => x.ResearchType)
                .NotEmpty();
        }
    }
}
