using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core;
using ESPNET.Entities.Soccer.Shared;

namespace ESPNET.Entities.Soccer;

public sealed class SoccerNews
{
	public string Header { get; set; }
	public Link Link { get; set; }
	public IEnumerable<Article> Articles { get; set; }
}
