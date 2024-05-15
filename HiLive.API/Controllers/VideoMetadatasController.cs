using HiLive.API.Models.VideoMetadatas;
using HiLive.API.Services.VideoMetadatas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HiLive.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VideoMetadatasController : ControllerBase
    {
        private readonly IVideoMetadatasService _videoMetadatasService;

        public VideoMetadatasController(IVideoMetadatasService videoMetadatasService)
        {
            _videoMetadatasService = videoMetadatasService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<VideoMetadata>> PostVideoMetadata(VideoMetadata videoMetadata)
        {
            VideoMetadata addedVideoMetadata = await _videoMetadatasService.AddVideoMetadataAsync(videoMetadata);

            return Ok(addedVideoMetadata);
        }

        [HttpGet]
        public ActionResult<IQueryable<VideoMetadata>> GetAllVideoMetadatas()
        {
            IQueryable<VideoMetadata> videoMetadatas = this._videoMetadatasService.RetrieveAllVideoMetadatas();

            return Ok(videoMetadatas);
        }
    }
}
