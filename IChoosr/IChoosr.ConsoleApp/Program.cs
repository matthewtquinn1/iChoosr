using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Service.Camera;
using IChoosr.DA;
using Microsoft.Extensions.DependencyInjection;

namespace IChoosr.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetService<CameraApplication>().StartApplication();
        }

        private static IServiceCollection ConfigureServices()
        {
          IServiceCollection services = new ServiceCollection();
          services.AddTransient<ICameraRepository, CameraRepository>();
          services.AddTransient<ICameraService, CameraService>();

          services.AddTransient<CameraApplication>();

            return services;
        }
  }
}
