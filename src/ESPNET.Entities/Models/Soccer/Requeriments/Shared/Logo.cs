using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.Shared;

public sealed class Logo
{
    public string Href { get; set; }
    public string Alt { get; set; }
    public string[] Rel { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public string LastUpdated { get; set; } = string.Empty;
}
