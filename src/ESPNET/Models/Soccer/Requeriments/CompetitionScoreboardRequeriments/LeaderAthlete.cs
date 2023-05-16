using System.Collections.Generic;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class LeaderAthlete
{
	public string ID { get; set; }
	public string DisplayName { get; set; }
	public string ShortName { get; set; }
	public string FullName { get; set; }
	public string Jersey { get; set; }
	public bool Active { get; set; }
	public LeaderTeam Team { get; set; }
	public IEnumerable<AthleteLink> Links { get; set; }
	public AthletePosition Position { get; set; }
}
