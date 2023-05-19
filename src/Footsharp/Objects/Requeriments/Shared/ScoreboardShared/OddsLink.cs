using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

public sealed class OddsLink
{
	public string Language { get; set; }
	public IEnumerable<string> Rel { get; set; }
	public string Href { get; set; }
	public string Text { get; set; }
	public string ShortText { get; set; }
	public bool IsExternal { get; set; }
	public bool IsPremium { get; set; }
	public bool IsHidden { get; set; }
}
