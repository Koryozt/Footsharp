using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESPNET.Models.Soccer.SoccerNews;

namespace ESPNET.Models.Soccer.Requeriments.NewsRequeriments.Core.Articles.Category;

public sealed class CategoryLeague
{
    public int ID { get; set; }
    public string Abbreviation { get; set; }
    public string Description { get; set; }
    public CategoryLinks Links { get; set; }
}
