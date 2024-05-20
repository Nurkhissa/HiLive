// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Models.VideoMetadatas;

namespace HiLive.API.Services.VideoMetadatas
{
    public interface IVideoMetadatasService
    {
        ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata category);
        IQueryable<VideoMetadata> RetrieveAllVideoMetadatas();
        ValueTask<VideoMetadata?> RetrieveVideoMetadataByIdAsync(Guid categoryId);
        ValueTask<VideoMetadata> ModifyVideoMetadataAsync(VideoMetadata category);
        ValueTask<VideoMetadata?> RemoveVideoMetadatasByIdAsync(Guid categoryId);
    }
}
