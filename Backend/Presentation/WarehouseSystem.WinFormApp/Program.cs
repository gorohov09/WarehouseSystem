using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WarehouseSystem.DAL;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Repositories;

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

        //Damir
        //@"data source=LAPTOP-9S2AK2B9;initial catalog=WarehouseDb;trusted_connection=true"

        //Andrey
        //@"Data Source=.\SQLEXPRESS;Initial Catalog=WarehouseDb;Integrated Security=True;"

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddDbContext<WarehouseContext>(options =>
                    {
                        options.UseSqlServer(@"data source=LAPTOP-9S2AK2B9;initial catalog=WarehouseDb;trusted_connection=true");
                    });

                    services.AddScoped<IProductRepository, ProductRepository>();

                    services.AddTransient<Form1>();
                });
        }
    }
}