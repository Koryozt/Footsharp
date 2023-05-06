using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.CompetitionRequeriments;

public class Status
{
	public float Clock { get; set; }
	public float AddedClock { get; set; }
	public string DisplayClock { get; set; }
	public int Period { get; set; }
	public Type Type { get; set; }
}
