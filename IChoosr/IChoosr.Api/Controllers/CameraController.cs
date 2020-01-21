using System.Collections.Generic;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Model;
using Microsoft.AspNetCore.Mvc;

namespace IChoosr.Api.Controllers
{
    [Route("api/[controller]")]
    public class CameraController : Controller
    {
        private readonly ICameraService _cameraService;

        public CameraController(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        [HttpGet]
        public IEnumerable<CameraModel> Get()
        {
            var cameras = _cameraService.GetCameras();

            return cameras;
        }
  }
}
