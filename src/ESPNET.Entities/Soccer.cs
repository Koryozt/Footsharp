using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ESPNET.Models;
using ESPNET.Models.Soccer;
using ESPNET.Query.Soccer;
using ESPNET.Request;

namespace ESPNET;

public sealed class Soccer : Sender
{
	private Sender Sender { get; init; }

	public Soccer() : 
		base(Sports.Soccer)
	{

	}

	public async Task<SoccerLeagueScoreboard> GetSoccerLeagueScoreboardAsync(
		Leagues league,
		int division = 1,
		CancellationToken cancellationToken = default)
	{
		string method = "scoreboard";
		string endpoint = $"{league}{division}/{method}/";

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerLeagueScoreboard scoreboard = JsonSerializer.Deserialize<SoccerLeagueScoreboard>(request);

		return scoreboard;
	}

	public async Task<SoccerLeague> GetSoccerLeagueAsync(
	Leagues league,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string method = "teams";
		string endpoint = $"{league}{division}/{method}/";

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerLeague soccerLeague = JsonSerializer.Deserialize<SoccerLeague>(request);

		return soccerLeague;
	}

	public async Task<SoccerTeam> GetSoccerLeagueTeamAsync(
	Leagues league,
	int id,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string method = "teams";
		string endpoint = $"{league}{division}/{method}/{id}?enable=roster";

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerTeam team = JsonSerializer.Deserialize<SoccerTeam>(request);

		return team;
	}

	public async Task<SoccerNews> GetSoccerLeagueNewsAsync(
	Leagues league,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string method = "news";
		string endpoint = $"{league}{division}/{method}/";

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerNews news = JsonSerializer.Deserialize<SoccerNews>(request);

		return news;
	}
}
