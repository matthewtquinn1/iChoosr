using System.Threading.Tasks;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Service.Camera;
using Microsoft.Extensions.DependencyInjection;

namespace IChoosr.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
        }

        private static IServiceCollection ConfigureServices()
        {
          IServiceCollection services = new ServiceCollection();
          services.AddTransient<ICameraService, CameraService>();

          return services;
        }
  }
}
