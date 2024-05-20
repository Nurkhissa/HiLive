// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HiLive.API.Brokers.Storoges
{
    public partial class StorageBroker
    {
        private static void SeedVideoMetadatas(EntityTypeBuilder<VideoMetadata> builder)
        {
            builder.HasData(
                new VideoMetadata
                {
                    Id = Guid.Parse(input: "1a99ed58-54fc-4c2d-b68d-f0f8c96f88c8"),
                    Title = "Internet",
                    BlobPath = "test/path",
                    Description = "Description",
                    Thubnail = "Thumnail",
                    CreatedDate = DateTimeOffset.Now,
                    UpdatedDate = DateTimeOffset.Now,
                },
                 new VideoMetadata
                 {
                     Id = Guid.Parse(input: "71577dac-0a17-4a58-8285-7fdc5c008b4e"),
                     Title = "Title2",
                     BlobPath = "test/path2",
                     Description = "Description2",
                     Thubnail = "Thumnail2",
                     CreatedDate = DateTimeOffset.Now,
                     UpdatedDate = DateTimeOffset.Now,
                 },
                  new VideoMetadata
                  {
                      Id = Guid.Parse(input: "0ca6c0a4-2a85-4b88-9c42-2fb86334b1ed"),
                      Title = "Title3",
                      BlobPath = "test/path3",
                      Description = "Description3",
                      Thubnail = "Thumnail3",
                      CreatedDate = DateTimeOffset.Now,
                      UpdatedDate = DateTimeOffset.Now,
                  }
            );
        }
    }
}
