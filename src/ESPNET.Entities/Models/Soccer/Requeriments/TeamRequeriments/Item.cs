using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.TeamRequeriments;

public sealed class Item
{
    public string Description { get; set; }
    public string Type { get; set; }
    public string Summary { get; set; }
    public IEnumerable<Stat> Stats { get; set; }
}