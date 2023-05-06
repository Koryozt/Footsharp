using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.AhtleteRequeriments;

public sealed class Position
{
	public string ID { get; set; }
	public string Name { get; set; }
	public string DisplayName { get; set; }
	public string Abbreviation { get; set; }
	public bool Leaf { get; set; }
}