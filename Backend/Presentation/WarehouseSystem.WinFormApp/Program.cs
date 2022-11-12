using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WarehouseSystem.DAL;

namespace WarehouseSystem.WinFormApp
{
    public static class Program
    {
        ///// <summary>
        /////  The main entry point for the application.
        ///// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    ApplicationConfiguration.Initialize();
        //    Application.Run(new Form1());
        //}

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<WarehouseContext>(options =>
                    {
                        options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=WarehouseDb;Integrated Security=True;");
                    });
                    services.AddTransient<Form1>();
                });
        }
    }
}