using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Details;

public sealed class DetailAthletesInvolved
{
    public string ID { get; set; }
    public string DisplayName { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string Jersey { get; set; }
    public AthletesInvolvedTeam Team { get; set; }
    public IEnumerable<Link> Links { get; set; }
    public string Position { get; set; }
    public string Headshot { get; set; }
}