using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.CompetitionRequeriments;


public sealed class TeamOdds
{
	public bool Favorite { get; set; }
	public bool Underdog { get; set; }
	public int MoneyLine { get; set; }
	public int SpreadOdds { get; set; }
	public IEnumerable<OddsTeam> Teams { get; set; }

}

public sealed class OddsTeam
{
	public int ID { get; set; }
	public string Name { get; set; }
	public string Abbreviation { get; set; }
}

