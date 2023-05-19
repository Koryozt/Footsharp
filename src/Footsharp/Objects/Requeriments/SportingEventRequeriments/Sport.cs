using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.SportingEventRequeriments;

public sealed class Sport
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Name { get; set; }
	public string Slug { get; set; }
	public IEnumerable<League> Leagues { get; set; }
}