using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core;

public sealed class League
{
    public string ID { get; set; }
    public string UID { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string MidsizeName { get; set; }
    public string Slug { get; set; }
    public IEnumerable<Logo> Logos { get; set; }
    public string CalendarType { get; set; }
    public bool CalendarIsWhitelist { get; set; }
    public string CalendarStartDate { get; set; }
    public string CalendarEndDate { get; set; }
    public IEnumerable<string> Calendar { get; set; }

}