// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace HiLive.API.Models.Exceptions
{
    
        public class VideoMetadataValidationException : Xeption
        {
            public VideoMetadataValidationException(string message, Xeption innerException)
                : base(message: message, innerException: innerException)
            { }
        }
}
