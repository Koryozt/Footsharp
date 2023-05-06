using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.NewsRequeriments.Core;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer;

public sealed class SoccerNews
{
    public string Header { get; set; }
    public Link Link { get; set; }
    public IEnumerable<Article> Articles { get; set; }
}
