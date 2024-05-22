// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace HiLive.API.Models.Exceptions
{
    public class InvalidVideoMetadataException : Exception
    {
        public InvalidVideoMetadataException(string message)
            : base(message)
        { }
    }
}
