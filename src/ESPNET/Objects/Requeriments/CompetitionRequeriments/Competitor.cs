namespace Footsharp.Objects.Requeriments.CompetitionRequeriments;

public sealed class Competitor
{
	public string ID { get; set; }
	public string Type { get; set; }
	public int Order { get; set; }
	public string HomeAway { get; set; }
	public bool Winner { get; set; }
	public CompetitorTeam Team { get; set; }
}