using System.Collections.Generic;
using IChoosr.BL.Model;

namespace IChoosr.BL.Interface.Camera
{
    public interface ICameraService
    {
        IEnumerable<CameraModel> GetCameras();
    }
}
