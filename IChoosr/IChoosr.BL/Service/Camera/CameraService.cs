using System.Collections.Generic;
using System.IO;
using System.Linq;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Model;
using IChoosr.DA;

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
            var cameras = GetAllCameras();

            return cameras;
        }

        public IEnumerable<CameraModel> GetCamerasByName(string name)
        {
            var camera = GetAllCameras()
                .Where(cam => cam.Name.ToUpper().Contains(name));

            return camera;
        }


        private IEnumerable<CameraModel> GetAllCameras()
        {
            var reader = _cameraRepo.GetCameraCsv();

            return GetCamerasFromCsv(reader);
        }

        private static IEnumerable<CameraModel> GetCamerasFromCsv(StreamReader reader)
        {
            var cameras = new List<CameraModel>();
            
            // Ignore header
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                
                if (LineIsValid(line)) cameras.Add(SetupCamera(line));
            }
           
            return cameras;
        }

        private static bool LineIsValid(string line) => line != null && !line.Contains("ERROR");
        

        private static CameraModel SetupCamera(string line)
        {
            var values = line.Split(';');

            var name = values[0]
                .Remove(0, 10).Trim(' ', '-');

            var camera = new CameraModel
            {
                Id = line.Substring(7, 3),
                FullId = line.Substring(0, 10),
                Name = name,
                Latitude = values[1],
                Longitude = values[2]
            };

            return camera;
        }
    }
}
