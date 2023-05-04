using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer;

public sealed class SoccerTeam
{
	public Team Team { get; set; }	


	public class Record
	{
		public Item[] items { get; set; }
	}

	public class Item
	{
		public string description { get; set; }
		public string type { get; set; }
		public string summary { get; set; }
		public Stat[] stats { get; set; }
	}

	public class Stat
	{
		public string name { get; set; }
		public float value { get; set; }
	}

	public class Groups
	{
		public string id { get; set; }
	}

	public class Defaultleague
	{
		public string id { get; set; }
		public string alternateId { get; set; }
		public string name { get; set; }
		public string abbreviation { get; set; }
		public string shortName { get; set; }
		public string midsizeName { get; set; }
		public string slug { get; set; }
		public Season season { get; set; }
		public Link[] links { get; set; }
		public Logo[] logos { get; set; }
	}

	public class Season
	{
		public Type type { get; set; }
	}

	public class Type
	{
		public bool hasStandings { get; set; }
	}

	public class Link
	{
		public string language { get; set; }
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
		public string shortText { get; set; }
		public bool isExternal { get; set; }
		public bool isPremium { get; set; }
	}

	public class Logo
	{
		public string href { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public string alt { get; set; }
		public string[] rel { get; set; }
		public string lastUpdated { get; set; }
	}



	public class Athlete
	{
		public string id { get; set; }
		public string uid { get; set; }
		public string type { get; set; }
		public string guid { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public string fullName { get; set; }
		public string displayName { get; set; }
		public string shortName { get; set; }
		public float weight { get; set; }
		public string displayWeight { get; set; }
		public float height { get; set; }
		public string displayHeight { get; set; }
		public int age { get; set; }
		public string dateOfBirth { get; set; }
		public string gender { get; set; }
		public Link1[] links { get; set; }
		public Birthplace birthPlace { get; set; }
		public string citizenship { get; set; }
		public Citizenshipcountry citizenshipCountry { get; set; }
		public string slug { get; set; }
		public string jersey { get; set; }
		public Flag flag { get; set; }
		public Position position { get; set; }
		public object[] injuries { get; set; }
		public bool linked { get; set; }
		public bool active { get; set; }
		public Eventlog eventLog { get; set; }
		public Status status { get; set; }
		public Seasons seasons { get; set; }
		public Leagues leagues { get; set; }
		public Transactions transactions { get; set; }
		public Events events { get; set; }
		public Defaultleague1 defaultLeague { get; set; }
		public bool profiled { get; set; }
		public Defaultteam defaultTeam { get; set; }
		public string middleName { get; set; }
		public Birthcountry birthCountry { get; set; }
		public Headshot headshot { get; set; }
	}

	public class Birthplace
	{
		public string country { get; set; }
		public string city { get; set; }
	}

	public class Citizenshipcountry
	{
		public string alternateId { get; set; }
		public string abbreviation { get; set; }
	}

	public class Flag
	{
		public string href { get; set; }
		public string alt { get; set; }
		public string[] rel { get; set; }
	}

	public class Position
	{
		public string id { get; set; }
		public string name { get; set; }
		public string displayName { get; set; }
		public string abbreviation { get; set; }
		public bool leaf { get; set; }
	}

	public class Eventlog
	{
	}

	public class Status
	{
		public string id { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		public string abbreviation { get; set; }
	}

	public class Seasons
	{
	}

	public class Leagues
	{
	}

	public class Transactions
	{
	}

	public class Events
	{
	}

	public class Defaultleague1
	{
	}

	public class Defaultteam
	{
	}

	public class Birthcountry
	{
		public string alternateId { get; set; }
		public string abbreviation { get; set; }
	}

	public class Headshot
	{
		public string href { get; set; }
		public string alt { get; set; }
	}

	public class Link1
	{
		public string language { get; set; }
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
		public string shortText { get; set; }
		public bool isExternal { get; set; }
		public bool isPremium { get; set; }
	}

	public class Link2
	{
		public string language { get; set; }
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
		public string shortText { get; set; }
		public bool isExternal { get; set; }
		public bool isPremium { get; set; }
	}

	public class Nextevent
	{
		public string id { get; set; }
		public string date { get; set; }
		public string name { get; set; }
		public string shortName { get; set; }
		public Season1 season { get; set; }
		public Seasontype seasonType { get; set; }
		public bool timeValid { get; set; }
		public Competition[] competitions { get; set; }
		public Link5[] links { get; set; }
		public League league { get; set; }
	}

	public class Season1
	{
		public int year { get; set; }
		public string displayName { get; set; }
	}

	public class Seasontype
	{
		public string id { get; set; }
		public int type { get; set; }
		public string name { get; set; }
		public string abbreviation { get; set; }
	}

	public class League
	{
		public string id { get; set; }
		public string alternateId { get; set; }
		public string name { get; set; }
		public string abbreviation { get; set; }
		public string shortName { get; set; }
		public string midsizeName { get; set; }
		public string slug { get; set; }
		public bool isTournament { get; set; }
	}

	public class Competition
	{
		public string id { get; set; }
		public string date { get; set; }
		public int attendance { get; set; }
		public bool timeValid { get; set; }
		public bool neutralSite { get; set; }
		public bool boxscoreAvailable { get; set; }
		public bool ticketsAvailable { get; set; }
		public Venue venue { get; set; }
		public Competitor[] competitors { get; set; }
		public object[] notes { get; set; }
		public Odd[] odds { get; set; }
		public object[] broadcasts { get; set; }
		public Status1 status { get; set; }
	}

	public class Venue
	{
		public string fullName { get; set; }
		public Address address { get; set; }
	}

	public class Address
	{
		public string city { get; set; }
		public string country { get; set; }
	}

	public class Status1
	{
		public float clock { get; set; }
		public float addedClock { get; set; }
		public string displayClock { get; set; }
		public int period { get; set; }
		public Type1 type { get; set; }
	}

	public class Type1
	{
		public string id { get; set; }
		public string name { get; set; }
		public string state { get; set; }
		public bool completed { get; set; }
		public string description { get; set; }
		public string detail { get; set; }
		public string shortDetail { get; set; }
	}

	public class Competitor
	{
		public string id { get; set; }
		public string type { get; set; }
		public int order { get; set; }
		public string homeAway { get; set; }
		public bool winner { get; set; }
		public Team1 team { get; set; }
	}

	public class Team1
	{
		public string id { get; set; }
		public string location { get; set; }
		public string nickname { get; set; }
		public string abbreviation { get; set; }
		public string displayName { get; set; }
		public string shortDisplayName { get; set; }
		public Logo2[] logos { get; set; }
		public Link3[] links { get; set; }
	}

	public class Logo2
	{
		public string href { get; set; }
		public int width { get; set; }
		public int height { get; set; }
		public string alt { get; set; }
		public string[] rel { get; set; }
		public string lastUpdated { get; set; }
	}

	public class Link3
	{
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
	}

	public class Odd
	{
		public Awayteamodds awayTeamOdds { get; set; }
		public Hometeamodds homeTeamOdds { get; set; }
		public Link4[] links { get; set; }
	}

	public class Awayteamodds
	{
		public bool favorite { get; set; }
		public bool underdog { get; set; }
		public int moneyLine { get; set; }
		public float spreadOdds { get; set; }
		public Team2 team { get; set; }
		public Odds odds { get; set; }
	}

	public class Team2
	{
		public string id { get; set; }
		public string name { get; set; }
		public string abbreviation { get; set; }
	}

	public class Odds
	{
		public string summary { get; set; }
		public float value { get; set; }
		public float handicap { get; set; }
	}

	public class Hometeamodds
	{
		public bool favorite { get; set; }
		public bool underdog { get; set; }
		public int moneyLine { get; set; }
		public float spreadOdds { get; set; }
		public Team3 team { get; set; }
		public Odds1 odds { get; set; }
	}

	public class Team3
	{
		public string id { get; set; }
		public string name { get; set; }
		public string abbreviation { get; set; }
	}

	public class Odds1
	{
		public string summary { get; set; }
		public float value { get; set; }
		public float handicap { get; set; }
	}

	public class Link4
	{
		public string language { get; set; }
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
		public string shortText { get; set; }
		public bool isExternal { get; set; }
		public bool isPremium { get; set; }
	}

	public class Link5
	{
		public string language { get; set; }
		public string[] rel { get; set; }
		public string href { get; set; }
		public string text { get; set; }
		public string shortText { get; set; }
		public bool isExternal { get; set; }
		public bool isPremium { get; set; }
	}

}
