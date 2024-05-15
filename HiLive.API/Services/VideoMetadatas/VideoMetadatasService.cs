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

        public async ValueTask<VideoMetadata> ModifyVideoMetadataAsync(VideoMetadata category) => 
            await this.storageBroker.UpdateVideoMetadataAsync(category);
        public async ValueTask<VideoMetadata?> RemoveVideoMetadatasByIdAsync(Guid categoryId) =>
        await this.storageBroker.DeleteVideoMetadataByIdAsync(categoryId);

        public IQueryable<VideoMetadata> RetrieveAllVideoMetadatas() => 
            this.storageBroker.SelectAllVideoMetadatas();

        public async ValueTask<VideoMetadata?> RetrieveVideoMetadataByIdAsync(Guid categoryId) => 
            await this.storageBroker.SelectVideoMetadataByIdAsync(categoryId);
        }
}
