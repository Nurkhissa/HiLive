// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

namespace HiLive.API.Models
{
    public class VideoMetadata
    {
        public Guid Id { get; set; } = new Guid();
        public string Title { get; set; }
        public string Description { get; set; }
        public string BlobPath { get; set; }
        public string Thubnail { get; set; }
        public DateTimeOffset CreatedDate { get; } = new DateTimeOffset();
        public DateTimeOffset UpdatedDate { get; } = new DateTimeOffset();
    }
}
