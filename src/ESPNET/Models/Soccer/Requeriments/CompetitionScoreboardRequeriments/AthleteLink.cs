using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class AthleteLink
{
	public IEnumerable<string> Rel { get; set; }
	public string Href { get; set; }
	public bool IsHidden { get; set; }
}
