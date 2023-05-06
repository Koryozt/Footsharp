using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.CompetitionRequeriments;

public sealed class Venue
{
	public string fullName { get; set; }
	public Address address { get; set; }
}