namespace ESPNET.Models.Soccer.Requeriments.LeagueScoreboardRequeriments.Core.Events.Competition.Video;

public sealed class HeadlineVideo
{
    public string Source { get; set; }
    public int ID { get; set; }
    public string Headline { get; set; }
    public VideoTracking Tracking { get; set; }
    public VideoDeviceRestrictions DeviceRestrictions { get; set; }
    public int Duration { get; set; }
    public string Thumbnail { get; set; }
    public VideoLinks Links { get; set; }
}