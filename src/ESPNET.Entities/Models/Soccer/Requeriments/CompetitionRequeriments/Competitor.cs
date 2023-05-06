﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPNET.Models.Soccer.SoccerTeam;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionRequeriments;

public sealed class Competitor
{
    public string ID { get; set; }
    public string Type { get; set; }
    public int Order { get; set; }
    public string HomeAway { get; set; }
    public bool Winner { get; set; }
    public Team Team { get; set; }
}