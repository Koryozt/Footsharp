using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitorLeader
{
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public string ShortDisplayName { get; set; }
    public string Abbreviation { get; set; }
    public IEnumerable<LeadersLeader> Leaders { get; set; }
}
