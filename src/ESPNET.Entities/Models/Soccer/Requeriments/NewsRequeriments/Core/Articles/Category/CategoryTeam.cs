using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.NewsRequeriments.Core.Articles.Category;

public sealed class CategoryTeam
{
    public int ID { get; set; }
    public string Description { get; set; }
    public CategoryLinks Links { get; set; }
}
