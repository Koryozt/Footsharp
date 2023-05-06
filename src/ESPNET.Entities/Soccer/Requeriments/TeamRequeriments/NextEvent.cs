using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Shared;

namespace ESPNET.Entities.Soccer.TeamRequeriments;

#pragma warning disable

public sealed class Nextevent
{
	public string ID { get; set; }
	public string Date { get; set; }
	public string Name { get; set; }
	public string ShortName { get; set; }
	public Season Season_ { get; set; }
	public Seasontype SeasonType { get; set; }
	public bool TimeValid { get; set; }
	public IEnumerable<Competition> Competitions { get; set; }
	public IEnumerable<Link> Links { get; set; }
	public League League { get; set; }

	public sealed class Season
	{
		public int Year { get; set; }
		public string DisplayName { get; set; }
	}
}

public class League
{
	public string ID { get; set; }
	public string AlternateId { get; set; }
	public string Name { get; set; }
	public string Abbreviation { get; set; }
	public string ShortName { get; set; }
	public string MidsizeName { get; set; }
	public string Slug { get; set; }
	public bool IsTournament { get; set; }
}



