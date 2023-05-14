﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Leagues;

public sealed class LeagueCalendar
{
	public string Label { get; set; }
	public string StartDate { get; set; }
	public string EndDate { get; set; }
	public IEnumerable<CalendarEntry> Entries { get; set; }
}