using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.ScoreboardShared;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments;

public sealed class CompetitionOdd
{
    public OddsProvider Provider { get; set; }
    public TeamOdds AwayTeamOdds { get; set; }
    public TeamOdds HomeTeamOdds { get; set; }
    public OddsDraw DrawOdds { get; set; }
    public float OverUnder { get; set; }
    public string Details { get; set; }
}