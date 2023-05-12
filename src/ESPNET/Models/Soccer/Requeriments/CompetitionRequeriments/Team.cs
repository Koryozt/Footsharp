using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionRequeriments;

public sealed class Team
{
    public string ID { get; set; }
    public string Location { get; set; }
    public string Nickname { get; set; }
    public string Abbreviation { get; set; }
    public string DisplayName { get; set; }
    public string ShortDisplayName { get; set; }
    public IEnumerable<Logo> Logos { get; set; }
    public IEnumerable<Link> Links { get; set; }
}