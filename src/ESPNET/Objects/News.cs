using System.Collections.Generic;
using Footsharp.Objects.Requeriments.NewsRequeriments;
using Footsharp.Objects.Requeriments.Shared;

namespace Footsharp.Objects;

public sealed class News
{
	public string Header { get; set; }
	public Link Link { get; set; }
	public IEnumerable<Article> Articles { get; set; }
}
