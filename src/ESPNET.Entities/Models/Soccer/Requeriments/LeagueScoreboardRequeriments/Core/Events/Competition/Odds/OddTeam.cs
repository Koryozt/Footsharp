using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Odds;

public sealed class OddTeam
{
    public string ID { get; set; }
    public string UID { get; set; }
    public string Abbreviation { get; set; }
    public string DisplayName { get; set; }
    public string Logo { get; set; }
}