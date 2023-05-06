using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Video;

public sealed class VideoTracking
{
    public string SportName { get; set; }
    public string LeagueName { get; set; }
    public string CoverageType { get; set; }
    public string TrackingName { get; set; }
    public string TrackingID { get; set; }
}