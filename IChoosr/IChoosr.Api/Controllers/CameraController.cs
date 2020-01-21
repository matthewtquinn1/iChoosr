using System.Collections.Generic;
using IChoosr.BL.Model;
using Microsoft.AspNetCore.Mvc;

namespace IChoosr.Api.Controllers
{
    [Route("api/[controller]")]
    public class CameraController : Controller
    {
        [HttpGet]
        public IEnumerable<Camera> Get()
        {
            return new List<Camera>();
        }

        [HttpGet]
        public IEnumerable<Camera> Get(string name)
        {
          return new List<Camera>();
        }
  }
}
