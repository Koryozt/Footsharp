﻿using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects.Requeriments.SportingEventRequeriments;

public sealed class Team
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Slug { get; set; }
	public string Abbreviation { get; set; }
	public string DisplayName { get; set; }
	public string ShortDisplayName { get; set; }
	public string Name { get; set; }
	public string Nickname { get; set; }
	public string Location { get; set; }
	public string Color { get; set; }
	public string AlternateColor { get; set; }
	public bool IsActive { get; set; }
	public bool IsAllStar { get; set; }
	public IEnumerable<Logo> Logos { get; set; }
	public IEnumerable<Link> Links { get; set; }
}