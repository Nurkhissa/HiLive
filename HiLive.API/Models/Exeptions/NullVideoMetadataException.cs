using System.Reflection;
using Xeptions;
namespace HiLive.API.Models.Exeptions
{
    public class NullVideoMetadataException :Xeption
    {
        public NullVideoMetadataException(string message) 
            : base(message: message)
        { }
    }
}
