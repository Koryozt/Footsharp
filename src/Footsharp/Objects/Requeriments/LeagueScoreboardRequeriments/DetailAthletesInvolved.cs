using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class DetailAthletesInvolved
{
	public string ID { get; set; }
	public string DisplayName { get; set; }
	public string ShortName { get; set; }
	public string FullName { get; set; }
	public string Jersey { get; set; }
	public AthletesInvolvedTeam Team { get; set; }
	public IEnumerable<Link> Links { get; set; }
	public string Position { get; set; }
	public string Headshot { get; set; }
}