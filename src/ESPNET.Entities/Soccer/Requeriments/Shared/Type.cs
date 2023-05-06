using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.Requeriments.Shared;

public sealed class Type
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public bool Completed { get; set; }
    public string Description { get; set; }
    public string Detail { get; set; }
    public string ShortDetail { get; set; }
}