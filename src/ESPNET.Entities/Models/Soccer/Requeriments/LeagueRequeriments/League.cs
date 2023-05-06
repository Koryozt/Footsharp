using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueRequeriments;

public sealed class League
{
    public string ID { get; set; }
    public string UID { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string ShortName { get; set; }
    public string Slug { get; set; }
    public IEnumerable<Teams> Teams { get; set; }
}