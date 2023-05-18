using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class CompetitionCompetitor
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Type { get; set; }
	public int Order { get; set; }
	public string HomeAway { get; set; }
	public bool Winner { get; set; }
	public string Form { get; set; }
	public string Score { get; set; }
	public IEnumerable<CompetitorRecord> Records { get; set; }
	public Team Team { get; set; }
	public IEnumerable<CompetitorStatistic> Statistics { get; set; }
}
