// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore;

namespace HiLive.API.Brokers.Storoges
{
    public partial class StorageBroker
    {
        public DbSet<VideoMetadata> VideoMetadatas {  get; set; }

        public async ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata) =>
        await this.InsertAsync(videoMetadata);

        public IQueryable<VideoMetadata> SelectAllVideoMetadatas() =>
            this.SelectAll<VideoMetadata>();

        public async ValueTask<VideoMetadata?> SelectVideoMetadataByIdAsync(Guid videoMetadataId) =>
            await this.SelectAsync<VideoMetadata>(videoMetadataId);

        public async ValueTask<VideoMetadata> UpdateVideoMetadataAsync(VideoMetadata videoMetadata) =>
            await this.UpdateAsync(videoMetadata);

        public async ValueTask<VideoMetadata?> DeleteVideoMetadataByIdAsync(Guid videoMetadataId)
        {
            var maybeVideoMetadata = await SelectVideoMetadataByIdAsync(videoMetadataId);
            return await this.DeleteAsync(maybeVideoMetadata);
        }
    }
}
