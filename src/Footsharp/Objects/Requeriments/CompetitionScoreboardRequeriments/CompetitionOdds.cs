using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitionOdds
{
	public OddsProvider Provider { get; set; }
	public TeamOdds AwayTeamOdds { get; set; }
	public TeamOdds HomeTeamOdds { get; set; }
	public OddsDraw DrawOdds { get; set; }
	public float OverUnder { get; set; }
	public string Details { get; set; }
}
