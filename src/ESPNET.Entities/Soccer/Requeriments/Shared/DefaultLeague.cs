using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.TeamRequeriments;

namespace ESPNET.Entities.Soccer.Shared;

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