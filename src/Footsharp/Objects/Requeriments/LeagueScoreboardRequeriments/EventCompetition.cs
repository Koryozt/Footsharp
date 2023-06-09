﻿using System.Collections.Generic;
using Footsharp.Objects.Requeriments.CompetitionRequeriments;
using Footsharp.Objects.Requeriments.Shared;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public sealed class EventCompetition
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Date { get; set; }
	public string StartDate { get; set; }
	public int Attendance { get; set; }
	public bool TimeValid { get; set; }
	public bool Recent { get; set; }
	public Status Status { get; set; }
	public Venue Venue { get; set; }
	public CompetitionFormat Format { get; set; }
	public IEnumerable<object> Notes { get; set; }
	public IEnumerable<object> GeoBroadcasts { get; set; }
	public IEnumerable<object> Broadcasts { get; set; }
	public IEnumerable<CompetitionCompetitor> Competitors { get; set; }
	public IEnumerable<CompetitionDetail> Details { get; set; }
	public IEnumerable<CompetitionHeadline> Headlines { get; set; }
	public bool PlayByPlayAvailable { get; set; }
	public IEnumerable<Odd> Odds { get; set; }
}