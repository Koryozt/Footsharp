using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Odds;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition;

public sealed class CompetitionOdd
{
	public OddProvider Provider { get; set; }
	public AwayTeamOdds AwayTeamOdds { get; set; }
	public HomeTeamOdds HomeTeamOdds { get; set; }
	public DrawOdds DrawOdds { get; set; }
	public float OverUnder { get; set; }
	public string Details { get; set; }
}