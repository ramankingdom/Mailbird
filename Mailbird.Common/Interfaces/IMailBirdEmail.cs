namespace Mailbird.Common.Interfaces
{
    public interface IMailBirdEmail
    {
        byte[] BodyInfo { get; set; }
        byte[] HeaderInfo { get; set; }
        bool isBodyDownloaded { get; set; }
        bool isHeaderDownloaded { get; set; }
        long UId { get; set; }
    }
}