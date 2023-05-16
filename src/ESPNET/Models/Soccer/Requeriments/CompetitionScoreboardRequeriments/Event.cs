using System;
using System.Collections.Generic;
using ESPNET.Models.Soccer.Requeriments.ScoreboardShared;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class Event
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