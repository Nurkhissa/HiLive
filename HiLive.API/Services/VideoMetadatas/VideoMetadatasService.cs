// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

//using HiLive.API.Brokers.Loggings;
using HiLive.API.Brokers.Storoges;
using HiLive.API.Models.VideoMetadatas;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HiLive.API.Services.VideoMetadatas
{
    public class VideoMetadatasService : IVideoMetadatasService
    {
        private readonly IStorageBroker storageBroker;
        //private readonly ILoggingBroker loggingBroker;

        public VideoMetadatasService(
            IStorageBroker storageBroker)
            //ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            //this.loggingBroker = loggingBroker;
        }

        public async ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata category) => 
            await this.storageBroker.InsertVideoMetadataAsync(category);

        public async ValueTask<VideoMetadata> ModifyVideoMetadataAsync(VideoMetadata category) => 
            await this.storageBroker.UpdateVideoMetadataAsync(category);
        public async ValueTask<VideoMetadata?> RemoveVideoMetadatasByIdAsync(Guid categoryId) =>
        await this.storageBroker.DeleteVideoMetadataByIdAsync(categoryId);

        public IQueryable<VideoMetadata> 
            RetrieveAllVideoMetadatas() => 
            this.storageBroker.SelectAllVideoMetadatas();

        public async ValueTask<VideoMetadata?> RetrieveVideoMetadataByIdAsync(Guid categoryId) => 
            await this.storageBroker.SelectVideoMetadataByIdAsync(categoryId);

        IQueryable<VideoMetadata> IVideoMetadatasService.RetrieveAllVideoMetadatas()
        {
            throw new NotImplementedException();
        }
    }
}
