using Xeptions;
namespace HiLive.API.Models.Exeptions
{
    public class VideoMetadataValidationException:Xeption
    {
        public VideoMetadataValidationException(string message, Xeption innerException)
            : base(message: message, innerException: innerException)
        { }
    }
}
