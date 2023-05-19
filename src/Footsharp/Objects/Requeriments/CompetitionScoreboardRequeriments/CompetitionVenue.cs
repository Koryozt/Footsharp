using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitionVenue
{
	public string Id { get; set; }
	public string FullName { get; set; }
	public Address Address { get; set; }
}
