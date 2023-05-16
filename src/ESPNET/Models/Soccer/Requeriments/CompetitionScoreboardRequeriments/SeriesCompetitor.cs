using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public class SeriesCompetitor
{
    public string ID { get; set; }
    public string UID { get; set; }
    public bool Winner { get; set; }
    public float AggregateScore { get; set; }
}