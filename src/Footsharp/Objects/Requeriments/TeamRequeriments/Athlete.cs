using System.Collections.Generic;
using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects.Requeriments.TeamRequeriments;

public sealed class Athlete
{
	public string ID { get; set; }
	public string UID { get; set; }
	public string Type { get; set; }
	public string GUID { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string FullName { get; set; }
	public string DisplayName { get; set; }
	public string ShortName { get; set; }
	public float Weight { get; set; }
	public string DisplayWeight { get; set; }
	public float Height { get; set; }
	public string DisplayHeight { get; set; }
	public int Age { get; set; }
	public string DateOfBirth { get; set; }
	public string Gender { get; set; }
	public IEnumerable<Link> Links { get; set; }
	public AthleteBirthPlace BirthPlace { get; set; }
	public string Citizenship { get; set; }
	public AthleteCitizenshipCountry CitizenshipCountry { get; set; }
	public string Slug { get; set; }
	public string Jersey { get; set; }
	public AthleteFlag Flag { get; set; }
	public AthletePosition Position { get; set; }
	public object[] Injuries { get; set; }
	public bool Linked { get; set; }
	public bool Active { get; set; }
	public AthleteEventLog EventLog { get; set; }
	public AthleteStatus Status { get; set; }
	public AthleteSeason Seasons { get; set; }
	public AthleteLeagues Leagues { get; set; }
	public AthleteTransactions Transactions { get; set; }
	public AthleteEvents Events { get; set; }
	public DefaultLeague DefaultLeague { get; set; }
	public bool Profiled { get; set; }
	public AthleteDefaultTeam DefaultTeam { get; set; }
	public string MiddleName { get; set; }
	public AthleteBirthCountry BirthCountry { get; set; }
	public AthleteHeadshot Headshot { get; set; }
}