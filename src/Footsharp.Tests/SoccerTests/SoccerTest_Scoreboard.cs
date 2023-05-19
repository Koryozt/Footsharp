using Footsharp;
using Footsharp.Objects;
using Footsharp.Query.Soccer;

namespace Footsharp.Tests.SoccerTests;

public class SoccerTest_Scoreboard
{
	private Soccer Soccer = new Soccer();
	private readonly ITestOutputHelper output;

	public SoccerTest_Scoreboard(ITestOutputHelper output)
	{
		this.output = output;
	}

	[Fact]
	public async Task CompetitionScoreboard_NotNull_ShouldPass()
	{
		CompetitionScoreboard score = await Soccer.GetSoccerCompetitionScoreboardAsync(Competitions.UEFA_CHAMPIONS);

		Assert.NotNull(score);
	}

	[Fact]
	public async Task LeagueScoreboard_LeaguesNotEmpty_ShouldPass()
	{
        LeagueScoreboard score = await Soccer.GetSoccerLeagueScoreboardAsync(Query.Soccer.Leagues.ENG);

		Assert.NotEmpty(score.Leagues);
	}

	[Fact]
	public async Task LeagueScoreboard_ContainsValidData_ShouldPass()
	{
        LeagueScoreboard score = await Soccer.GetSoccerLeagueScoreboardAsync(Query.Soccer.Leagues.ENG);

		int? year = score.Season.Year;

		output.WriteLine(year.ToString());

		Assert.NotNull(year);
	}
}
