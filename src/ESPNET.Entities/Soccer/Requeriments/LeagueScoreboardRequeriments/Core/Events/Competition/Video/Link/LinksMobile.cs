using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.Shared;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Video.Link;

public sealed class LinksMobile
{
	public string Href { get; set; }
	public Ref Alert { get; set; }
	public Ref ProgressiveDownload { get; set; }
	public Ref Source { get; set; }
	public Ref Streaming { get; set; }
}