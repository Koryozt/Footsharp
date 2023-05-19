using System;

namespace Footsharp.Objects.Requeriments.NewsRequeriments;

public class ArticleCategory
{
	public int ID { get; set; }
	public string Description { get; set; }
	public string Type { get; set; }
	public int SportID { get; set; }
	public int TeamID { get; set; }
	public CategoryTeam Team { get; set; }
	public string UID { get; set; }
	public DateTime CreateDate { get; set; }
	public int AthleteId { get; set; }
	public CategoryAthlete Athlete { get; set; }
	public int LeagueId { get; set; }
	public CategoryLeague League { get; set; }
	public string Guid { get; set; }
}
