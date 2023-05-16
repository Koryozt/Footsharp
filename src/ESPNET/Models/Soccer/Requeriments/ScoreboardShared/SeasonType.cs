using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.ScoreboardShared;

public sealed class SeasonType
{
    public string ID { get; set; }
    public int Type { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
}