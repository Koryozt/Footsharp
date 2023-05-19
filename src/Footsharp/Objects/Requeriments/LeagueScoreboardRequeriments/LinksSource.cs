using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class LinksSource
{
	public string Href { get; set; }
	public Ref Flash { get; set; }
	public Ref Full { get; set; }
	public Ref HDS { get; set; }
	public Ref Mezzanine { get; set; }
	public Ref HD { get; set; }
	public SourceHLS HLS { get; set; }
}