// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Brokers.Loggings;
using HiLive.API.Brokers.Storoges;
using HiLive.API.Models.VideoMetadatas;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HiLive.API.Services.VideoMetadatas
{
    public partial class VideoMetadatasService : IVideoMetadatasService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public VideoMetadatasService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<VideoMetadata> AddVideoMetadataAsync(VideoMetadata videoMetadata) =>
            await this.storageBroker.InsertVideoMetadataAsync(videoMetadata);

        public async ValueTask<VideoMetadata> ModifyVideoMetadataAsync(VideoMetadata videoMetadata) =>
            await this.storageBroker.UpdateVideoMetadataAsync(videoMetadata);
        public async ValueTask<VideoMetadata?> RemoveVideoMetadatasByIdAsync(Guid videoMetadataId) =>
        await this.storageBroker.DeleteVideoMetadataByIdAsync(videoMetadataId);

        public IQueryable<VideoMetadata>
            RetrieveAllVideoMetadatas() =>
            this.storageBroker.SelectAllVideoMetadatas();

        public async ValueTask<VideoMetadata?> RetrieveVideoMetadataByIdAsync(Guid videoMetadataId) =>
            await this.storageBroker.SelectVideoMetadataByIdAsync(videoMetadataId);

        IQueryable<VideoMetadata> IVideoMetadatasService.RetrieveAllVideoMetadatas() =>
            throw new NotImplementedException();
    }
}
