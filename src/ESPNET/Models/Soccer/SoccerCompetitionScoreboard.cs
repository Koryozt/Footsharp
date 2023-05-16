using System.Collections.Generic;
using ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;
using ESPNET.Models.Soccer.Requeriments.ScoreboardShared;

namespace ESPNET.Models.Soccer;

public sealed class SoccerCompetitionScoreboard
{
	public IEnumerable<League> Leagues { get; set; }
	public Season Season { get; set; }
	public Day Day { get; set; }
	public IEnumerable<Event> Events { get; set; }
}