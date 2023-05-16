using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Tests.SoccerTests;

public class SoccerTest_LeagueAndCompetition
{
	private Soccer Soccer = new Soccer();
	private readonly ITestOutputHelper output;

	public SoccerTest_LeagueAndCompetition(ITestOutputHelper output)
	{
		this.output = output;
	}

	[Fact]
	public async Task SoccerLeague_GetLeagueInformation_ShouldPass()
	{
		SoccerCompetition competition = await Soccer.GetSoccerLeagueAsync(Leagues.ENG);

		Assert.NotNull(competition);
	}

	[Fact]
	public async Task SoccerCompetition_GetLeagueInformation_ShouldPass()
	{
		SoccerCompetition competition = await Soccer.GetSoccerCompetitionAsync(Competitions.UEFA_CHAMPIONS);

		Assert.NotNull(competition);
	}

	[Fact]
	public async Task SoccerLeague_LeaguesNotEmpty_ShouldPass()
	{
		SoccerCompetition competition = await Soccer.GetSoccerLeagueAsync(Leagues.ENG);

		Assert.NotEmpty(competition.Sports);
		Assert.NotEmpty(competition.Sports.First().Leagues);
	}

	[Fact]
	public async Task SoccerLeague_GetLeagueInformation_InvalidDivision_ShoulReturnNull()
	{
		SoccerCompetition competition = await Soccer.GetSoccerLeagueAsync(Leagues.ENG, 10);

		Assert.Null(competition);
	}
}
