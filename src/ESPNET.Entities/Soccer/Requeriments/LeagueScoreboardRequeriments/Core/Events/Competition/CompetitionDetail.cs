using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Details;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition;

public sealed class CompetitionDetail
{
    public DetailType Type { get; set; }
    public DetailClock Clock { get; set; }
    public DetailTeam Team { get; set; }
    public int ScoreValue { get; set; }
    public bool ScoringPlay { get; set; }
    public bool RedCard { get; set; }
    public bool YellowCard { get; set; }
    public bool PenaltyKick { get; set; }
    public bool OwnGoal { get; set; }
    public bool Shootout { get; set; }
    public IEnumerable<DetailAthletesInvolved> AthletesInvolved { get; set; }
}