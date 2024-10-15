using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCACQRS.Application.Songs.Queries
{
    public class DtoUpSong
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public TimeOnly Duration { get; set; }
        public string? Lien { get; set; }
    }
}
