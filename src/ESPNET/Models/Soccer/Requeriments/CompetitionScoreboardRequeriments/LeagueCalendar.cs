using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPNET.Models.Soccer.SoccerCompetitionScoreboard;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class LeagueCalendar
{
    public string Label { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public IEnumerable<Entry> Entries { get; set; }
}
