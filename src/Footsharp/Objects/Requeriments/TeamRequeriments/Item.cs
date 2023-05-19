using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.TeamRequeriments;

public sealed class Item
{
	public string Description { get; set; }
	public string Type { get; set; }
	public string Summary { get; set; }
	public IEnumerable<Stat> Stats { get; set; }
}