using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.ScoreboardShared;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class League
{
    public string ID { get; set; }
    public string UID { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string MidsizeName { get; set; }
    public string Slug { get; set; }
    public LeagueSeason Season { get; set; }
    public IEnumerable<Logo> Logos { get; set; }
    public string CalendarType { get; set; }
    public bool CalendarIsWhitelist { get; set; }
    public string CalendarStartDate { get; set; }
    public string CalendarEndDate { get; set; }
    public IEnumerable<LeagueCalendar> Calendar { get; set; }
}
