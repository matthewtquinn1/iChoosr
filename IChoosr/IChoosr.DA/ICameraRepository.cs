using System.IO;

namespace IChoosr.DA
{
    public interface ICameraRepository
    {
        StreamReader GetCameraCsv();
    }
}
