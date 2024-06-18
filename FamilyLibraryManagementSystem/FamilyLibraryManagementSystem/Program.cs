using FamilyLibraryManagementSystem.Data;
using FamilyLibraryManagementSystem.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyLibraryManagementSystem
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new LibraryInitializer());

            var services = ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(serviceProvider.GetService<LibraryService>()));
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddScoped<LibraryContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<LibraryService>();
            return services;
        }
    }
}
