using System.Collections.Generic;
using IChoosr.DA.Entities;

namespace IChoosr.DA
{
    public interface ICameraRepository
    {
        List<BaseCamera> GetCameras();
    }
}
