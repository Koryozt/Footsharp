using Footsharp;
using Footsharp.Objects;
using Footsharp.Query.Soccer;

namespace Footsharp.Tests.SoccerTests;

public class SoccerTest_LeagueAndCompetition
{
	private Soccer Soccer = new Soccer();
	private readonly ITestOutputHelper output;

	public SoccerTest_LeagueAndCompetition(ITestOutputHelper output)
	{
		this.output = output;
	}

	[Fact]
	public async Task League_GetLeagueInformation_ShouldPass()
	{
		League league = await Soccer.GetSoccerLeagueAsync(Leagues.ENG);

		Assert.NotNull(league);
	}

	[Fact]
	public async Task Competition_GetLeagueInformation_ShouldPass()
	{
		Competition competition = await Soccer.GetSoccerCompetitionAsync(Competitions.UEFA_CHAMPIONS);

		Assert.NotNull(competition);
	}

	[Fact]
	public async Task League_LeaguesNotEmpty_ShouldPass()
	{
		League league = await Soccer.GetSoccerLeagueAsync(Leagues.ENG);

		Assert.NotEmpty(league.Sports);
		Assert.NotEmpty(league.Sports.First().Leagues);
	}

	[Fact]
	public async Task League_GetLeagueInformation_InvalidDivision_ShoulReturnNull()
	{
		League league = await Soccer.GetSoccerLeagueAsync(Leagues.ENG, 10);

		Assert.Null(league);
	}
}
