namespace Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

public sealed class TeamOdds
{
	public string Summary { get; set; }
	public float Value { get; set; }
	public float Handicap { get; set; }
	public TeamOddsTeam Team { get; set; }
	public OddsLink Link { get; set; }
	public bool Favorite { get; set; }
	public bool Underdog { get; set; }
	public int MoneyLine { get; set; }
	public float SpreadOdds { get; set; }
}
