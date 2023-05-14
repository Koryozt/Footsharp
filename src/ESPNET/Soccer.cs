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
using Newtonsoft.Json;

namespace ESPNET;

public sealed class Soccer
{
	private Sender Sender { get; init; }

	public Soccer()
	{
		Sender = new Sender(Sports.Soccer);
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

		SoccerScoreboard scoreboard = JsonConvert.DeserializeObject<SoccerScoreboard>(request);

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

		SoccerLeague soccerLeague = JsonConvert.DeserializeObject<SoccerLeague>(request);

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

		SoccerTeam team = JsonConvert.DeserializeObject<SoccerTeam>(request);

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

		SoccerNews news = JsonConvert.DeserializeObject<SoccerNews>(request);

		return news;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API	scoreboard
	/// to get the scoreboard of that competition.
	/// </summary>
	/// <param name="comp"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task<SoccerScoreboard> GetSoccerCompetitionScoreboardAsync(
	Competitions comp,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleCompetitionEndpoint(comp, "scoreboard");
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerScoreboard scoreboard = JsonConvert.DeserializeObject<SoccerScoreboard>(request);

		return scoreboard;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API	news method
	/// to get the most recent news about a competition.
	/// </summary>
	/// <param name="comp"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task<SoccerNews> GetSoccerCompetitionNewsAsync(
	Competitions comp,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleCompetitionEndpoint(comp, "news");
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerNews news = JsonConvert.DeserializeObject<SoccerNews>(request);

		return news;
	}

	/// <summary>
	///	Deserialize the JSON response from the ESPN API teams with roster enabled method
	/// to get the complete information about a specified league.
	/// </summary>
	/// <param name="comp"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task<SoccerTeam> GetSoccerCompetitionTeamAsync(
	Competitions comp,
	int id,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleCompetitionEndpoint(comp, "teams", id);
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerTeam team = JsonConvert.DeserializeObject<SoccerTeam>(request);

		return team;
	}

	/// <summary>
	/// Deserialize the JSON response from the ESPN API teams method
	/// to get the general information of that competition.
	/// </summary>
	/// <param name="comp"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	public async Task<SoccerLeague> GetSoccerCompetitionAsync(
	Competitions comp,
	CancellationToken cancellationToken = default)
	{
		string endpoint = HandleCompetitionEndpoint(comp, "teams");
		var request = await Sender.SendAsync(endpoint, cancellationToken);

		SoccerLeague league = JsonConvert.DeserializeObject<SoccerLeague>(request);

		return league;
	}

	/// <summary>
	/// Allows the conversion and modification of the League enum parameter provide to make a valid endpoint for the API.
	/// </summary>
	/// <param name="league"></param>
	/// <param name="method"></param>
	/// <param name="division"></param>
	/// <param name="id"></param>
	/// <returns>
	///		A string with the valid endpoint.
	/// </returns>
	private string HandleLeagueEndpoint(Leagues league, string method, int division, int? id = null)
	{
		string mod = league.ToString().ToLower();

		if (id is not null)
		{
			return $"{mod}.{division}/{method}/{id}?enable=roster";
		}

		return $"{mod}.{division}/{method}";
	}

	/// <summary>
	/// Allows the conversion and modification of the Competition enum parameter provide to make a valid endpoint for the API.
	/// </summary>
	/// <param name="competitions"></param>
	/// <param name="method"></param>
	/// <param name="id"></param>
	/// <returns>
	///		A string with the valid endpoint.
	/// </returns>
	private string HandleCompetitionEndpoint(Competitions competitions, string method, int? id = null)
	{
		string mod = competitions
			.ToString()
			.Replace("_", ".")
			.Replace("x", "_").ToLower();

		if (id is not null)
		{
			return $"{mod}/{method}/{id}?enable=roster";
		}

		return $"{mod}/{method}";
	}
}