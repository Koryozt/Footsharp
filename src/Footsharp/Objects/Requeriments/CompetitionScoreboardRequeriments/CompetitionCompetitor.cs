using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

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
	public float AggregateScore { get; set; }
	public Team Team { get; set; }
	public IEnumerable<object> Statistics { get; set; }
	public IEnumerable<CompetitorLeader> Leaders { get; set; }
}

