using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.TeamRequeriments;

public sealed class Team
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Slug { get; set; }
	public string Location { get; set; }
	public string Name { get; set; }
	public string Nickname { get; set; }
	public string Abbreviation { get; set; }
	public string DisplayName { get; set; }
	public string ShortDisplayName { get; set; }
	public string Color { get; set; }
	public string AlternateColor { get; set; }
	public bool IsActive { get; set; }
	public Logo1[] logos { get; set; }
	public Record record { get; set; }
	public Athlete[] athletes { get; set; }
	public Groups groups { get; set; }
	public Link2[] links { get; set; }
	public Defaultleague defaultLeague { get; set; }
	public string leagueAbbrev { get; set; }
	public Nextevent[] nextEvent { get; set; }
	public string standingSummary { get; set; }
}
