using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Footsharp.Exceptions;

public class LeagueOrCompetitionNotFoundException : Exception
{
	public LeagueOrCompetitionNotFoundException()
		: base("Footsharp.Error: League or competition are not valid or they were not found")
	{ 
	}
}
