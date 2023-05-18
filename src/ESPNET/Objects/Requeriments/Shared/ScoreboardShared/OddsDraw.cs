namespace Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

public sealed class OddsDraw
{
	public string Summary { get; set; }
	public float value { get; set; }
	public float Handicap { get; set; }
	public OddsLink Link { get; set; }
	public int MoneyLine { get; set; }
}
