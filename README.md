# ESPNET

## What is ESPNET?

ESPNET is a C# class library project (and future nuget package) to interact with the ESPN API from .NET, retrieving and deserializing all the information that you need into simple classes to handle the data in a more flexible way and to do anything you want with that information. Also, ESPNET is built with .NET 7 and C# 11.

## Project status
We're currently developing the soccer methods and testing them for a correct use; we're discussing about implementing a Dictionary with the teams and their identifier for the API request.
The next step will be implementing the Baseball models and requests.

## Usage examples

##### Retrieve soccer team information.
Let's get the Manchester United team data with the following code example
```cs
...

Soccer soccer = new();
int manUtdId = 360;

SoccerTeam team = await soccer.GetSoccerLeagueTeamAsync(Leagues.ENG, manUtdId); 

...
```

## Extra

If you want to help with this package, send a message to my discord `zxt#8196`!
