using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class CompetitionOdd
{
	public OddsProvider Provider { get; set; }
	public TeamOdds AwayTeamOdds { get; set; }
	public TeamOdds HomeTeamOdds { get; set; }
	public OddsDraw DrawOdds { get; set; }
	public float OverUnder { get; set; }
	public string Details { get; set; }
}