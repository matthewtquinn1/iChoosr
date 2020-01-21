using System.IO;

namespace IChoosr.DA
{
    public class CameraRepository : ICameraRepository
    {
        public StreamReader GetCameraCsv()
        {
            return new StreamReader(@"D:\Web_workspace\iChoosr\IChoosr\IChoosr.DA\Data\cameras-defb.csv");
        }
    }
}
