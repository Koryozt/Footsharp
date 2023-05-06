﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.CompetitionRequeriments;

namespace ESPNET.Entities.Soccer.TeamRequeriments;

public class Competition
{
	public string ID { get; set; }
	public string Date { get; set; }
	public int Attendance { get; set; }
	public bool TimeValid { get; set; }
	public bool NeutralSite { get; set; }
	public bool BoxscoreAvailable { get; set; }
	public bool TicketsAvailable { get; set; }
	public Venue Venue { get; set; }
	public IEnumerable<Competitor> Competitors { get; set; }
	public IEnumerable<object> Notes { get; set; }
	public IEnumerable<Odd> Odds { get; set; }
	public IEnumerable<object> Broadcasts { get; set; }
	public CompetitionRequeriments.Status Status { get; set; }
}