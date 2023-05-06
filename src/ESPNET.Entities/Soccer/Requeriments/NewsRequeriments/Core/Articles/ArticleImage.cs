using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Entities.Soccer.Requeriments.NewsRequeriments.Core.Articles;

public sealed class ArticleImage
{
	public string DataSourceIdentifier { get; set; }
	public string Name { get; set; }
	public int Width { get; set; }
	public string Alt { get; set; }
	public int ID { get; set; }
	public string Credit { get; set; }
	public string Type { get; set; }
	public string Url { get; set; }
	public int Height { get; set; }
	public string Caption { get; set; }
}