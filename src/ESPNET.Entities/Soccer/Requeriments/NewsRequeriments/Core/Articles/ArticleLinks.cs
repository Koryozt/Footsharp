using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles.LinksRequeriments;
using ESPNET.Entities.Soccer.Requeriments.Shared;

namespace ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles;

public class ArticleLinks
{
	public LinksApi Api { get; set; }
	public Ref Web { get; set; }
	public Ref Mobile { get; set; }
}
