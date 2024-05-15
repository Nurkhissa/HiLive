using HiLive.API.Models.VideoMetadatas;

namespace HiLive.API.Brokers.Storoges
{
    public partial interface IStorageBroker
    {
        ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata category);
        IQueryable<VideoMetadata> SelectAllVideoMetadatas();
    }
}
