using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core;

public class Event
{
    public string ID { get; set; }
    public string UID { get; set; }
    public string Date { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public EventSeason Season { get; set; }
    public IEnumerable<EventCompetition> Competitions { get; set; }
    public Status Status { get; set; }
    public IEnumerable<Link> Links { get; set; }
}
