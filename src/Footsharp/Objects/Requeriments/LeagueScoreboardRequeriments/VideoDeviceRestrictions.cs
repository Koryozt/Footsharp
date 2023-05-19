using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.LeagueScoreboardRequeriments;

public class VideoDeviceRestrictions
{
	public string Type { get; set; }
	public IEnumerable<string> Devices { get; set; }
}