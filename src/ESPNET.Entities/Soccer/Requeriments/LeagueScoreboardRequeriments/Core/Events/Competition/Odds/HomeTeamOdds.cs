using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Shared;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Odds;

public sealed class HomeTeamOdds
{
	public string Summary { get; set; }
	public float Value { get; set; }
	public float Handicap { get; set; }
	public OddTeam Team { get; set; }
	public Link Link { get; set; }
	public bool Favorite { get; set; }
	public bool Underdog { get; set; }
	public int MoneyLine { get; set; }
	public float SpreadOdds { get; set; }
}