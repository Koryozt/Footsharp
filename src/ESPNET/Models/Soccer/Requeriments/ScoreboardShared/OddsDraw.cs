using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.ScoreboardShared;

public sealed class OddsDraw
{
    public string Summary { get; set; }
    public float value { get; set; }
    public float Handicap { get; set; }
    public OddsLink Link { get; set; }
    public int MoneyLine { get; set; }
}
