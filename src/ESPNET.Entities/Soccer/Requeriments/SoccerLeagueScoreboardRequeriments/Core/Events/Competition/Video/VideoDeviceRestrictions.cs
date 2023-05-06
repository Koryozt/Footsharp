using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Video;

public class VideoDeviceRestrictions
{
    public string Type { get; set; }
    public IEnumerable<string> Devices { get; set; }
}