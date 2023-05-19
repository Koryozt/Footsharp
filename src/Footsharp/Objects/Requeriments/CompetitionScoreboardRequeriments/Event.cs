using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class Event
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Date { get; set; }
	public string Name { get; set; }
	public string ShortName { get; set; }
	public EventSeason Season { get; set; }
	public IEnumerable<EventCompetition> Competitions { get; set; }
	public Status Status { get; set; }
	public IEnumerable<Link> Links { get; set; }
}