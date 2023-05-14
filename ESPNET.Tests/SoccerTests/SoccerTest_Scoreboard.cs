using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer;
using ESPNET.Query.Soccer;
using Xunit.Abstractions;

namespace ESPNET.Tests.SoccerTests;

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
		SoccerScoreboard score = await Soccer.GetSoccerCompetitionScoreboardAsync(Competitions.UEFA_CHAMPIONS);

		Assert.NotNull(score);
	}

	[Fact]
	public async Task LeagueScoreboard_LeaguesNotEmpty_ShouldPass()
	{
		SoccerScoreboard score = await Soccer.GetSoccerLeagueScoreboardAsync(Leagues.ENG);

		output.WriteLine(score.Leagues.First().Abbreviation);

		Assert.NotEmpty(score.Leagues);
	}

	[Fact]
	public async Task LeagueScoreboard_ContainsValidData_ShouldPass()
	{
		SoccerScoreboard score = await Soccer.GetSoccerLeagueScoreboardAsync(Leagues.ENG);

		int? year = score.Season.Year;

		output.WriteLine(year.ToString());

		Assert.NotNull(year);
	}
}
