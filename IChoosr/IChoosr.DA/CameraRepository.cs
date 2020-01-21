using System.IO;

namespace IChoosr.DA
{
    public class CameraRepository : ICameraRepository
    {
        public StreamReader GetCameraCsv()
        {
            return new StreamReader(@"../IChoosr.DA/Data/cameras-defb.csv");
        }
    }
}
