using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.Shared;
using ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core;

namespace ESPNET.Models.Soccer;

#pragma warning disable

public sealed class SoccerLeagueScoreboard
{
    public IEnumerable<League> Leagues { get; set; }
    public Season Season { get; set; }
    public Day Day { get; set; }
    public IEnumerable<Event> Events { get; set; }
}
