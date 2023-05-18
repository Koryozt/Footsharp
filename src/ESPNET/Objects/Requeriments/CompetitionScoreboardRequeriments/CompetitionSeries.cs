using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitionSeries
{
	public IEnumerable<SeriesCompetitor> Competitors { get; set; }
	public bool Completed { get; set; }
	public string Title { get; set; }
	public int TotalCompetitions { get; set; }
}
