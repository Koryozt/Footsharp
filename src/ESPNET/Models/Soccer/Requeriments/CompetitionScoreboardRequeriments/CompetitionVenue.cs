using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Models.Soccer.Requeriments.Shared;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionScoreboardRequeriments;

public sealed class CompetitionVenue
{
    public string Id { get; set; }
    public string FullName { get; set; }
    public Address Address { get; set; }
}
