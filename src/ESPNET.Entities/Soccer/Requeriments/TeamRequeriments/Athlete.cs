using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.AhtleteRequeriments;
using ESPNET.Entities.Soccer.Shared;

namespace ESPNET.Entities.Soccer.TeamRequeriments;

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
	public BirthPlace BirthPlace { get; set; }
	public string Citizenship { get; set; }
	public CitizenshipCountry CitizenshipCountry { get; set; }
	public string Slug { get; set; }
	public string Jersey { get; set; }
	public Flag Flag { get; set; }
	public Position Position { get; set; }
	public object[] Injuries { get; set; }
	public bool Linked { get; set; }
	public bool Active { get; set; }
	public EventLog EventLog { get; set; }
	public Status Status { get; set; }
	public IEnumerable<Seasons> Seasons { get; set; }
	public IEnumerable<Leagues> Leagues { get; set; }
	public Transactions Transactions { get; set; }
	public Events Events { get; set; }
	public DefaultLeague DefaultLeague { get; set; }
	public bool Profiled { get; set; }
	public DefaultTeam DefaultTeam { get; set; }
	public string MiddleName { get; set; }
	public BirthCountry BirthCountry { get; set; }
	public Headshot Headshot { get; set; }
}