using System.Collections.Generic;
using Footsharp.Objects.Requeriments.SportingEventRequeriments;

namespace Footsharp.Objects;

public sealed class League
{
	public IEnumerable<Sport> Sports { get; set; }
}
