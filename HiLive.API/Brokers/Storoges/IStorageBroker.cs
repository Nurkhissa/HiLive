// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Models.VideoMetadatas;

namespace HiLive.API.Brokers.Storoges
{
    public partial interface IStorageBroker
    {
        ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata);
        IQueryable<VideoMetadata> SelectAllVideoMetadatas();
        ValueTask<VideoMetadata?> SelectVideoMetadataByIdAsync(Guid videoMetadataId);
        ValueTask<VideoMetadata> UpdateVideoMetadataAsync(VideoMetadata videoMetadata);
        ValueTask<VideoMetadata?> DeleteVideoMetadataByIdAsync(Guid videoMetadataId);
    }
}
