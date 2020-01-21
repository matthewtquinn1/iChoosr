using System;
using IChoosr.DA.Entities;

namespace IChoosr.BL.Model
{
    public class CameraModel
    {
        public CameraModel(BaseCamera cam)
        {
            Latitude = Convert.ToInt64(cam.Latitude);
            Longitude = Convert.ToInt64(cam.Longitude);
        }


        public int Id { get; set; }
        public string FullId { get; set; }
        public string Name { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
    }
}
