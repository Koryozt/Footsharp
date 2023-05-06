using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments;

public sealed class LeagueSeason
{
	public int Year { get; set; }
	public string StartDate { get; set; }
	public string EndDate { get; set; }
	public string DisplayName { get; set; }
}