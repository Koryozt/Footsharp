using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class LeagueCalendar
{
	public string Label { get; set; }
	public string StartDate { get; set; }
	public string EndDate { get; set; }
	public IEnumerable<Entry> Entries { get; set; }
}
