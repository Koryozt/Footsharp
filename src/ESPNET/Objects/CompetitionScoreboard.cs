using System.Collections.Generic;
using Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects;

public sealed class CompetitionScoreboard
{
	public IEnumerable<League> Leagues { get; set; }
	public Season Season { get; set; }
	public Day Day { get; set; }
	public IEnumerable<Event> Events { get; set; }
}