using LA.Economy.Helpers;
using LA.Economy.Infra.Repositories;
using LA.Economy.Interfaces.Helpers;
using LA.Economy.Interfaces.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace LA.Economy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                //var form1 = serviceProvider.GetRequiredService<Form1>();
                var form1 = serviceProvider.GetRequiredService<MyMaterialForm>();
                Application.Run(form1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            //services.AddSingleton<Form1>()
            services.AddSingleton<MyMaterialForm>()
                    .AddLogging(configure => configure.AddConsole())
                    .AddScoped<ITransactionRepository, TransactionRepository>()
                    .AddScoped<IDataRecorder, DataRecorder>();
        }
    }
}