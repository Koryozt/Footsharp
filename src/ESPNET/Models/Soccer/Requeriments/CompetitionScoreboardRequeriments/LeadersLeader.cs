using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class LeadersLeader
{
    public string DisplayValue { get; set; }
    public string ShortDisplayValue { get; set; }
    public float Value { get; set; }
    public LeaderAthlete Athlete { get; set; }
    public LeaderTeam Team { get; set; }
}
