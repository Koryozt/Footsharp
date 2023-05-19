using System.Collections.Generic;
using Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects;

#pragma warning disable

public sealed class LeagueScoreboard
{
	public IEnumerable<League> Leagues { get; set; }
	public Season Season { get; set; }
	public Day Day { get; set; }
	public IEnumerable<Event> Events { get; set; }
}
