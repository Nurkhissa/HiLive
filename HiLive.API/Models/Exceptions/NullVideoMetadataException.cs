// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Xeptions;

namespace HiLive.API.Models.Exceptions
{
    public class NullVideoMetadataException : Xeption
    {
        public NullVideoMetadataException(string message)
            : base(message: message)
        { }
    }
}
