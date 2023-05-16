using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments;

public sealed class LinksMobile
{
    public string Href { get; set; }
    public Ref Alert { get; set; }
    public Ref ProgressiveDownload { get; set; }
    public Ref Source { get; set; }
    public Ref Streaming { get; set; }
}