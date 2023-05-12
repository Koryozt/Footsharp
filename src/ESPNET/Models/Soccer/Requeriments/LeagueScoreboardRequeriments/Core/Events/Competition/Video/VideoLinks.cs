using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Video.Link;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Video;

public class VideoLinks
{
    public LinksApi Api { get; set; }
    public LinksMobile Mobile { get; set; }
    public LinksSource Source { get; set; }
    public LinksWeb Web { get; set; }
}
