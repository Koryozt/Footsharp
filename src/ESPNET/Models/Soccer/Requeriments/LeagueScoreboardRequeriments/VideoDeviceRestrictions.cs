using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments;

public class VideoDeviceRestrictions
{
    public string Type { get; set; }
    public IEnumerable<string> Devices { get; set; }
}