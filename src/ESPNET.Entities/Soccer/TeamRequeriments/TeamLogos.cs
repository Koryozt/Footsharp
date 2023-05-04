using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.TeamRequeriments;

public sealed class TeamLogo
{
	public string Href { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public string Alt { get; set; }
	public IEnumerable<string> Rel { get; set; }
	public string LastUpdated { get; set; }
}