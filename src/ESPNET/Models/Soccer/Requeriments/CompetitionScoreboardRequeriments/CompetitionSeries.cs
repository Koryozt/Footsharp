using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitionSeries
{
    public IEnumerable<SeriesCompetitor> Competitors { get; set; }
    public bool Completed { get; set; }
    public string Title { get; set; }
    public int TotalCompetitions { get; set; }
}
