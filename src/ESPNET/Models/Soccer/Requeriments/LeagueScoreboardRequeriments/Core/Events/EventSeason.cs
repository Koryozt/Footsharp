using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events;

public sealed class EventSeason
{
    public int Year { get; set; }
    public int Type { get; set; }
    public string Slug { get; set; }
}
