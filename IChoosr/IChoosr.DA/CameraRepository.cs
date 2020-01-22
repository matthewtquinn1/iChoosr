using System.IO;

namespace IChoosr.DA
{
    public class CameraRepository : ICameraRepository
    {
        public StreamReader GetCameraCsv()
        {
            return new StreamReader(@"C:\temp\cameras-defb.csv");
        }
    }
}
