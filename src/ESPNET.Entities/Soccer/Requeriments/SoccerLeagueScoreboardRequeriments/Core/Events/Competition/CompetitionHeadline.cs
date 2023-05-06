﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition.Video;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments.Core.Events.Competition;

public sealed class CompetitionHeadline
{
    public string Description { get; set; }
    public string Type { get; set; }
    public string ShortLinkText { get; set; }
    public IEnumerable<HeadlineVideo> Videos { get; set; }
}