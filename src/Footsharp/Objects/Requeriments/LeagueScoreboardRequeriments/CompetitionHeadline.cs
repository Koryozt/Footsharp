using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class CompetitionHeadline
{
	public string Description { get; set; }
	public string Type { get; set; }
	public string ShortLinkText { get; set; }
	public IEnumerable<HeadlineVideo> Videos { get; set; }
}