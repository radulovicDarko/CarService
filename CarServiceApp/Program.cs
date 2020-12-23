using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces.Repository;
using DataAccessLayer;
using Shared.Interfaces.Business;
using BusinessLayer;

namespace CarServiceApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<MainMenu>();
                Application.Run(new MainMenu());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IOwnerRepository, OwnerRepository>();
            services.AddScoped<IOwnerBusiness, OwnerBusiness>();
            services.AddScoped<MainMenu>();
        }
    }
}
