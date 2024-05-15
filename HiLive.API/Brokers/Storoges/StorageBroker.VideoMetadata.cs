using HiLive.API.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore;

namespace HiLive.API.Brokers.Storoges
{
    internal partial class StorageBroker
    {
        public DbSet<VideoMetadata> VideoMetadatas {  get; set; }      
    }
}
