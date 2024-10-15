using DemoCACQRS.Application.Songs.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlayListService.Application.Songs.Commands.CreateSong;

namespace DemoCACQRS.Presentation.Controllers
{
    public class MusicController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<DtoUpSpotifySong>> GetMusic([FromQuery] GetMusicQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpGet("api/Music/all")]
        public async Task<ActionResult<List<DtoUpSong>>> GetAllMusic([FromQuery] GetAllMusicQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateSongCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
