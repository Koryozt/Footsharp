using System.Collections.Generic;
using Footsharp.Objects.Requeriments.TeamRequeriments;

namespace Footsharp.Objects.Requeriments.Shared;

public sealed class DefaultLeague
{
	public string ID { get; set; }
	public string AlternateID { get; set; }
	public string Name { get; set; }
	public string Abbreviation { get; set; }
	public string ShortName { get; set; }
	public string MidsizeName { get; set; }
	public string Slug { get; set; }
	public Season Season { get; set; }
	public IEnumerable<Link> Links { get; set; }
	public IEnumerable<Logo> Logos { get; set; }
}