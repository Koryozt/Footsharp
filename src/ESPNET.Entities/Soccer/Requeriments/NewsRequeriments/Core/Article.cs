using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles;

namespace ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core;

public sealed class Article
{
	public IEnumerable<ArticleImage> Images { get; set; }
	public string DataSourceIdentifier { get; set; }
	public string Description { get; set; }
	public DateTime Published { get; set; }
	public string Type { get; set; }
	public bool Premium { get; set; }
	public ArticleLinks Links { get; set; }
	public DateTime LastModified { get; set; }
	public IEnumerable<ArticleCategory> Categories { get; set; }
	public string Headline { get; set; }
	public string Byline { get; set; }
}