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

        [HttpGet("id/{videoMetdataId}")]
        public async ValueTask<ActionResult<VideoMetadata>> GetVideoMetadataById(Guid videoMetdataId)
        {
            VideoMetadata? videoMetdata = await 
                _videoMetadatasService.RetrieveVideoMetadataByIdAsync(videoMetdataId);

            return Ok(videoMetdata);
        }

        [HttpPut]
        public async ValueTask<ActionResult<VideoMetadata>> PutVideoMetadata(VideoMetadata videoMetadata)
        {
            VideoMetadata updateVideoMetadata = await this._videoMetadatasService.ModifyVideoMetadataAsync(videoMetadata);

            return Ok(updateVideoMetadata);
        }

        [HttpDelete("{videoMetadataId:guid}")]
        public async ValueTask<ActionResult<VideoMetadata>> DeleteByIdVideoMetadata(Guid videoMetadataId)
        {
            VideoMetadata? deleteVideoMetadata = await this._videoMetadatasService.
                RemoveVideoMetadatasByIdAsync(videoMetadataId);

            return Ok(deleteVideoMetadata);
        }
    }
}
