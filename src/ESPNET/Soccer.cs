using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
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

	/// <summary>
	/// Deserialize the JSON response from the ESPN API	scoreboard
	/// to get the scoreboard of that league.
	/// </summary>
	/// <param name="league"></param>
	/// <param name="division"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>
	///		A SoccerLeagueScoreboard instance.
	/// </returns>
	public async Task<SoccerScoreboard> GetSoccerLeagueScoreboardAsync(
		Leagues league,
		int division = 1,
		CancellationToken cancellationToken = default)
	{
		string endpoint = HandleLeagueEndpoint(league, "scoreboard", division);
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerScoreboard scoreboard = JsonSerializer.Deserialize<SoccerScoreboard>(request);

		return scoreboard;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API teams method
	/// to get the general information of that league.
	/// </summary>
	/// <param name="league"></param>
	/// <param name="division"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>
	///		A SoccerLeague instance.
	/// </returns>
	public async Task<SoccerLeague> GetSoccerLeagueAsync(
	Leagues league,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleLeagueEndpoint(league, "teams", division);

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerLeague soccerLeague = JsonSerializer.Deserialize<SoccerLeague>(request);

		return soccerLeague;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API	teams with roster enabled method
	/// to get a complete information about a specified team.
	/// </summary>
	/// <param name="league"></param>
	/// <param name="id"></param>
	/// <param name="division"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>
	///		A SoccerTeam instance.
	/// </returns>
	public async Task<SoccerTeam> GetSoccerLeagueTeamAsync(
	Leagues league,
	int id,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleLeagueEndpoint(league, "teams", division, id);
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerTeam team = JsonSerializer.Deserialize<SoccerTeam>(request);

		return team;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API	news method
	/// to get the most recent news about a league.
	/// </summary>
	/// <param name="league"></param>
	/// <param name="division"></param>
	/// <param name="cancellationToken"></param>
	/// <returns>
	///		A SoccerNews instance.
	/// </returns>
	public async Task<SoccerNews> GetSoccerLeagueNewsAsync(
	Leagues league,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleLeagueEndpoint(league, "news", division);

		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerNews news = JsonSerializer.Deserialize<SoccerNews>(request);

		return news;
	}

	public async Task<SoccerScoreboard> GetSoccerCompetitionScoreboardAsync(
	Competitions comp,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public async Task<SoccerNews> GetSoccerCompetitionNewsAsync(
	Competitions comp,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public async Task<SoccerTeam> GetSoccerCompetitionTeamAsync(
	Competitions comp,
	int id,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

	public async Task<SoccerLeague> GetSoccerCompetitionAsync(
	Competitions comp,
	int division = 1,
	CancellationToken cancellationToken = default)
	{
		throw new NotImplementedException();
	}

private string HandleLeagueEndpoint(Leagues league, string method, int division, int? id = null)
	{
		string mod = league.ToString().Replace("_", ".");

		if (id is not null)
		{
			return HttpUtility.UrlEncode($"{mod}.{division}/{method}/{id}?enable=roster");
		}

		return HttpUtility.UrlEncode($"{mod}.{division}/{method}/");
	}

	private string HandleCompetitionEndpoint(Competitions competitions, string method, int division, int? id = null)
	{
		string mod = competitions
			.ToString()
			.Replace("_", ".")
			.Replace("x", "_");

		if (id is not null)
		{
			return HttpUtility.UrlEncode($"{mod}.{division}/{method}/{id}?enable=roster");
		}

		return HttpUtility.UrlEncode($"{mod}.{division}/{method}/");
	}
}