﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Odds;

public sealed class OddProvider
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Priority { get; set; }
}