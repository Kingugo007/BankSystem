using BankSystemCore.DTO;
using BankSystemCore.Helpers;
using BankSystemCore.Interface;
using BankSystemCore.Services;
using Microsoft.Extensions.DependencyInjection;
namespace BankSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Login>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IJsonOperation, JsonOperation>();
            services.AddScoped<IValidators, Validators>();
            services.AddScoped<IUtilities, Utilities>();
            services.AddScoped<Login>();
            services.AddScoped<Welcome>();           
            services.AddScoped<IUserDTO, UserDTO>();
            services.AddScoped<IAccountServices, AccountServices>();
            services.AddScoped<ChooseAccount>();           
            services.AddScoped<IAccountDTO, AccountDTO>();
            services.AddScoped<ITransactionServices, TransactionServices>();
            services.AddScoped<CreateNewAccount>();
            services.AddScoped<Dashboard>();
           

        }
    }
}