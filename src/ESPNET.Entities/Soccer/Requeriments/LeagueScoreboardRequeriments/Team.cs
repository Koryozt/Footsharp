using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Shared;

namespace ESPNET.Entities.Soccer.Requeriments.SoccerLeagueScoreboardRequeriments;

public class Team
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Abbreviation { get; set; }
	public string DisplayName { get; set; }
	public string ShortDisplayName { get; set; }
	public string Name { get; set; }
	public string Location { get; set; }
	public string Color { get; set; }
	public string AlternateColor { get; set; }
	public bool IsActive { get; set; }
	public string Logo { get; set; }
	public IEnumerable<Link> Links { get; set; }
	public TeamVenue Venue { get; set; }
}
