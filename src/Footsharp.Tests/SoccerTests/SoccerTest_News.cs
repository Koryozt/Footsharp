using Footsharp;
using Footsharp.Objects;
using Footsharp.Query.Soccer;

namespace Footsharp.Tests.SoccerTests;

public class SoccerTest_News
{
	private Soccer Soccer = new Soccer();
	private readonly ITestOutputHelper output;

	public SoccerTest_News(ITestOutputHelper output)
	{
		this.output = output;
	}

	[Fact]
	public async Task CompetitionsNews_NotNull_ShouldPass()
	{
		News news = await Soccer.GetSoccerCompetitionNewsAsync(Competitions.UEFA_CHAMPIONS);

		Assert.NotNull(news);
	}

	[Fact]
	public async Task LeagueNews_LinkNotNull_ShouldPass()
	{
		News news = await Soccer.GetSoccerLeagueNewsAsync(Leagues.ENG);

		Assert.NotNull(news.Link);
	}

	[Fact]
	public async Task LeagueNews_ValidArticles_ShouldPass()
	{
		News news = await Soccer.GetSoccerLeagueNewsAsync(Leagues.ENG);

		Assert.NotEmpty(news.Articles);
	}
}
