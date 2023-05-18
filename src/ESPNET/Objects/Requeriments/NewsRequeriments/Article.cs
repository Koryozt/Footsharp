using System;
using System.Collections.Generic;

namespace Footsharp.Objects.Requeriments.NewsRequeriments;

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