using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WarehouseSystem.Application.Interfaces;
using WarehouseSystem.Application.Services;
using WarehouseSystem.DAL;
using WarehouseSystem.DAL.Interfaces;
using WarehouseSystem.DAL.Repositories;
using WarehouseSystem.WinFormApp.Forms;

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
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            System.Windows.Forms.Application.Run(ServiceProvider.GetRequiredService<>());
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
                        options.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=WarehouseDb;Integrated Security=True;");
                    });

                    //Repositories
                    services.AddScoped<IProductRepository, ProductRepository>();
                    services.AddScoped<IProductExemplarRepository, ProductExemplarRepository>();

                    //Services
                    services.AddScoped<IProductService, ProductService>();
                    services.AddScoped<IProductExemplarService, ProductExemplarService>();

                    
                });
        }
    }
}