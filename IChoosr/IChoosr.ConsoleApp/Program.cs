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
        }

        private static IServiceCollection ConfigureServices()
        {
          IServiceCollection services = new ServiceCollection();
          services.AddScoped<ICameraRepository, CameraRepository>();
          services.AddTransient<ICameraService, CameraService>();

          return services;
        }
  }
}
