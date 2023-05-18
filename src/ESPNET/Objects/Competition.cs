using System.Collections.Generic;
using Footsharp.Objects.Requeriments.SportingEventRequeriments;

namespace Footsharp.Objects;

public sealed class Competition
{
	public IEnumerable<Sport> Sports { get; set; }
}
