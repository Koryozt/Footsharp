using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.Shared;

public sealed class Link
{
	public IEnumerable<string> Rel { get; set; }
	public string Href { get; set; }
	public string Text { get; set; }
	public bool IsExternal { get; set; }
	public bool IsPremium { get; set; }
	public string Language { get; set; }
	public string ShortText { get; set; }
}