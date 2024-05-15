using HiLive.API.Brokers.Storoges;
using HiLive.API.Models.VideoMetadatas;

namespace HiLive.API.Services.VideoMetadatas
{
    public class VideoMetadatasService : IVideoMetadatasService
    {

        private readonly IStorageBroker storageBroker;

        public VideoMetadatasService(IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata category) => 
            await this.storageBroker.InsertVideoMetadataAsync(category);

        public ValueTask<VideoMetadata> ModifyVideoMetadataAsync(VideoMetadata category)
        {
            throw new NotImplementedException();
        }

        public async ValueTask<VideoMetadata?> RemoveVideoMetadatasByIdAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<VideoMetadata> RetrieveAllVideoMetadatas() => this.storageBroker.SelectAllVideoMetadatas();

        public async ValueTask<VideoMetadata?> RetrieveVideoMetadataByIdAsync(Guid categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
