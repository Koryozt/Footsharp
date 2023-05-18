namespace Footsharp.Objects.Requeriments.Shared;

public sealed class Logo
{
	public string Href { get; set; }
	public string Alt { get; set; }
	public string[] Rel { get; set; }
	public int Width { get; set; }
	public int Height { get; set; }
	public string LastUpdated { get; set; } = string.Empty;
}
