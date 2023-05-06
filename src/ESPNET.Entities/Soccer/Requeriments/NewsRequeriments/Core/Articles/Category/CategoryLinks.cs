using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles.Links;

namespace ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles.Category;

public sealed class CategoryLinks
{
	public LinksApiAlternative Api { get; set; }
	public LinksMobile Mobile { get; set; }
	public LinksWeb Web { get; set; }
}
