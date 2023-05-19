using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class AthleteLink
{
	public IEnumerable<string> Rel { get; set; }
	public string Href { get; set; }
	public bool IsHidden { get; set; }
}
