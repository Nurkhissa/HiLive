using HiLive.API.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore;

namespace HiLive.API.Brokers.Storoges
{
    public partial class StorageBroker
    {
        public DbSet<VideoMetadata> VideoMetadatas {  get; set; }

        public async ValueTask<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata videoMetadata) =>
        await this.InsertAsync(videoMetadata);
        //Task<VideoMetadata> InsertVideoMetadataAsync(VideoMetadata category);

        //Task<VideoMetadata> IStorageBroker.InsertVideoMetadataAsync(VideoMetadata category)
        //{
        //    throw new NotImplementedException();
        //}

        public IQueryable<VideoMetadata> SelectAllVideoMetadatas() =>
            this.SelectAll<VideoMetadata>();

        //public async ValueTask<VideoMetadata?> SelectVideoMetadataByIdAsync(Guid categoryId) =>
        //    await this.SelectAsync<VideoMetadata>(categoryId);

        //public async ValueTask<VideoMetadata> UpdateVideoMetadataAsync(VideoMetadata category) =>
        //    await this.UpdateAsync(category);

        //public async ValueTask<VideoMetadata?> DeleteCategoryByIdAsync(Guid categoryId)
        //{
        //    var maybeCategory = await SelectCategoryByIdAsync(categoryId);
        //    return await this.DeleteAsync(maybeCategory);
        //}
    }
}
