using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitorLeader
{
	public string Name { get; set; }
	public string DisplayName { get; set; }
	public string ShortDisplayName { get; set; }
	public string Abbreviation { get; set; }
	public IEnumerable<LeadersLeader> Leaders { get; set; }
}
