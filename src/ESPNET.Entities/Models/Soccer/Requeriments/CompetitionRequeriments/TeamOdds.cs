using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.CompetitionRequeriments;


public sealed class HomeTeamOdds
{
    public bool Favorite { get; set; }
    public bool Underdog { get; set; }
    public int MoneyLine { get; set; }
    public int SpreadOdds { get; set; }
    public IEnumerable<Team> Teams { get; set; }


    public sealed class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}

internal class AwayTeamOdds
{
    public bool Favorite { get; set; }
    public bool Underdog { get; set; }
    public int MoneyLine { get; set; }
    public int SpreadOdds { get; set; }
    public IEnumerable<Team> Teams { get; set; }


    public sealed class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
    }
}

