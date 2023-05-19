# Footsharp

## What is Footsharp?

Footsharp is a C# class library project and nuget package to get information in real time about any kind of soccer information, like league or championships matches, scoreboard, news, teams and players. 
These information is obtained by the ESPN API, Footsharp deserialize the response for a better usage for you!

<hr />

## Usage examples

##### Retrieve Manchester United team information.
```cs
Soccer soccer = new();
int manUtdId = 360;

SoccerTeam team = await soccer.GetSoccerLeagueTeamAsync(Leagues.ENG, manUtdId); 
```
##### Get scoreboard from the UEFA Champions League.

```cs
Soccer soccer = new();

CompetitionScoreboard scoreboard = await soccer.GetSoccerCompetitionScoreboardAsync(Competitions.UEFA_CHAMPIONS);

```

## Package details

Name: Koryozt.Footsharp
.NET version: .NET 7
Package version: 1.0.0
