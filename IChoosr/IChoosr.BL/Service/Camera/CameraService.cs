using System.Collections.Generic;
using System.Linq;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Model;
using IChoosr.DA;
using IChoosr.DA.Entities;

namespace IChoosr.BL.Service.Camera
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository _cameraRepo;

        public CameraService(ICameraRepository cameraRepo)
        {
            _cameraRepo = cameraRepo;
        }


        public IEnumerable<CameraModel> GetCameras()
        {
            var cameras = GetAllCameras().Select(cam => new CameraModel(cam));

            return cameras;
        }

        public void GetCameraByName(string name)
        {

        }

        private IEnumerable<BaseCamera> GetAllCameras() => _cameraRepo.GetCameras();
    }
}
