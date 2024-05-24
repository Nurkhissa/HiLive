using Xeptions;
namespace HiLive.API.Models.Exeptions
{
    public class InvalidVideoMetadataException:Xeption
    {
        public InvalidVideoMetadataException(string message) 
            : base(message) 
        { }
    }
}
