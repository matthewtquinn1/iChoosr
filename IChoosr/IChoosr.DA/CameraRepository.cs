using System.Collections.Generic;
using System.IO;
using IChoosr.DA.Entities;

namespace IChoosr.DA
{
    public class CameraRepository : ICameraRepository
    {
        public List<BaseCamera> GetCameras()
        {
            var cameras = GetCamerasFromCsv();

            return cameras;
        }

        private static List<BaseCamera> GetCamerasFromCsv()
        {
            var baseCameras = new List<BaseCamera>();
            using (var reader = new StreamReader(@"./Data/cameras-defb.csv"))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    var camera = new BaseCamera { Id = values[0], Latitude = values[1], Longitude = values[2] };
                    baseCameras.Add(camera);
                }
            }

            return baseCameras;
        }
    }
}
