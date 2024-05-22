// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using HiLive.API.Models.VideoMetadatas;
using HiLive.API.Services.VideoMetadatas;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HiLive.API.Controllers
{
    [Route(template: "api/[controller]/[action]")]
    [ApiController]
    public class VideoMetadatasController : ControllerBase
    {
        private readonly IVideoMetadatasService videoMetadatasService;

        public VideoMetadatasController(IVideoMetadatasService videoMetadatasService)
            => this.videoMetadatasService = videoMetadatasService;

        [HttpPost]
        public async ValueTask<ActionResult<VideoMetadata>> PostVideoMetadata(VideoMetadata videoMetadata)
        {
            VideoMetadata addedVideoMetadata =
                await videoMetadatasService.AddVideoMetadataAsync(category: videoMetadata);

            return Ok(value: addedVideoMetadata);
        }

        [HttpGet]
        public ActionResult<IQueryable<VideoMetadata>> GetAllVideoMetadatas()
        {
            IQueryable<VideoMetadata> videoMetadatas =
                this.videoMetadatasService.RetrieveAllVideoMetadatas();

            return Ok(value: videoMetadatas);
        }

        [HttpGet(template: "id/{videoMetdataId}")]
        public async ValueTask<ActionResult<VideoMetadata>> GetVideoMetadataById(Guid videoMetdataId)
        {
            VideoMetadata? videoMetdata =
                await videoMetadatasService.RetrieveVideoMetadataByIdAsync(categoryId: videoMetdataId);

            return Ok(value: videoMetdata);
        }

        [HttpPut]
        public async ValueTask<ActionResult<VideoMetadata>> PutVideoMetadata(VideoMetadata videoMetadata)
        {
            VideoMetadata updateVideoMetadata =
                await this.videoMetadatasService.ModifyVideoMetadataAsync(category: videoMetadata);

            return Ok(value: updateVideoMetadata);
        }

        [HttpDelete(template: "{videoMetadataId:guid}")]
        public async ValueTask<ActionResult<VideoMetadata>> DeleteByIdVideoMetadata(Guid videoMetadataId)
        {
            VideoMetadata? deleteVideoMetadata =
                await this.videoMetadatasService.RemoveVideoMetadatasByIdAsync(categoryId: videoMetadataId);

            return Ok(value: deleteVideoMetadata);
        }
    }
}
