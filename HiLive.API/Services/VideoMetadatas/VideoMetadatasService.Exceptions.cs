using HiLive.API.Models.Exceptions;
using HiLive.API.Models.VideoMetadatas;
using System.Threading.Tasks;
using Xeptions;

namespace HiLive.API.Services.VideoMetadatas
{
    public partial class VideoMetadatasService
    {
        private delegate ValueTask<VideoMetadata> ReturningVideoMetadataFunction();

        private async ValueTask<VideoMetadata> TryCatch(ReturningVideoMetadataFunction returningVideoMetadataFunction)
        {
            try
            {
                return await returningVideoMetadataFunction();
            } catch (NullVideoMetadataException nullVideoMetadataException)
            {
                throw CreateAndLogValidationException(nullVideoMetadataException);
            } catch (InvalidVideoMetadataException invalidVideoMetadataException)
            {
                throw CreateAndLogValidationException(invalidVideoMetadataException);
            }
        }

        private VideoMetadataValidationException CreateAndLogValidationException(Xeption innerException)
        {
            var videoMetadataValidationException =
                new VideoMetadataValidationException("Video metadata validation error occured, fix errors and try again.", innerException);

            return videoMetadataValidationException;
        }
    }
}
