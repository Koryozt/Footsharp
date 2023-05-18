using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared;
using Footsharp.Objects.Requeriments.Shared.ScoreboardShared;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class League
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Name { get; set; }
	public string Abbreviation { get; set; }
	public string MidsizeName { get; set; }
	public string Slug { get; set; }
	public LeagueSeason Season { get; set; }
	public IEnumerable<Logo> Logos { get; set; }
	public string CalendarType { get; set; }
	public bool CalendarIsWhitelist { get; set; }
	public string CalendarStartDate { get; set; }
	public string CalendarEndDate { get; set; }
	public IEnumerable<LeagueCalendar> Calendar { get; set; }
}
