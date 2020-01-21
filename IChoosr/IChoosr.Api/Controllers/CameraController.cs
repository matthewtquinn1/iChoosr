using System.Collections.Generic;
using IChoosr.BL.Model;
using Microsoft.AspNetCore.Mvc;

namespace IChoosr.Api.Controllers
{
    [Route("api/[controller]")]
    public class CameraController : Controller
    {
        [HttpGet]
        public IEnumerable<CameraModel> Get()
        {
            return new List<CameraModel>();
        }

        [HttpGet]
        public IEnumerable<CameraModel> Get(string name)
        {
          return new List<CameraModel>();
        }
  }
}
