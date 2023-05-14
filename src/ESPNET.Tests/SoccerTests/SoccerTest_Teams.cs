using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer;
using ESPNET.Query.Soccer;
using Xunit.Abstractions;

namespace ESPNET.Tests.SoccerTests;

public class SoccerTest_Teams
{
	private Soccer Soccer = new Soccer();
	private int _teamId = 364;
	private readonly ITestOutputHelper output;

	public SoccerTest_Teams(ITestOutputHelper output)
	{
		this.output = output;
	}

	[Fact]
	public async Task CompetitionTeam_NotNull_ShouldPass()
	{
		SoccerTeam team = await Soccer.GetSoccerCompetitionTeamAsync(Competitions.UEFA_CHAMPIONS, _teamId);

		Assert.NotNull(team);
	}


	[Fact]
	public async Task LeagueTeam_AthletesNotEmpty_ShouldPass()
	{
		SoccerTeam team = await Soccer.GetSoccerLeagueTeamAsync(Leagues.ENG, _teamId);

		Assert.NotEmpty(team.Team.Athletes);
	}

	[Fact]
	public async Task LeagueTeam_ValidIdentifiers_ShouldPass()
	{
		SoccerTeam team = await Soccer.GetSoccerLeagueTeamAsync(Leagues.ENG, _teamId);

		Assert.NotNull(team.Team.UID);
		Assert.NotNull(team.Team.ID);
	}
}
