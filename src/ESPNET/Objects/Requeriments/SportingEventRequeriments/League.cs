using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.SportingEventRequeriments;

public sealed class League
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Name { get; set; }
	public string Abbreviation { get; set; }
	public string ShortName { get; set; }
	public string Slug { get; set; }
	public IEnumerable<Teams> Teams { get; set; }
}