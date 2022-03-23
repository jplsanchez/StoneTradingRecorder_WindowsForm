using LA.Economy.Domain.Helpers;
using LA.Economy.Domain.Interfaces.Helpers;
using LA.Economy.Domain.Interfaces.Repositories;
using LA.Economy.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace LA.Economy.App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(form);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<MainForm>()
                    .AddLogging(configure => configure.AddConsole())
                    .AddScoped<ITransactionRepository, TransactionRepository>()
                    .AddScoped<IDataRecorder, DataRecorder>();
        }
    }
}