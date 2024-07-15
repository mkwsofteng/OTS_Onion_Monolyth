using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OTS.Application.Interfaces;
using OTS.Application.Interfaces.Data;
using OTS.Application.Services;
using OTS.Domain.Interfaces;
using OTS.Infrastructure.Data.Repositories;
using OTS.Infrastructure.Services;

namespace OTS.Infrastructure.IOC
{
    public static class Extensions
    {
        public static void RegisterOtsServices(this IServiceCollection services, IConfiguration configuration)
        {
            RegisterRepositories(services);
            RegisterDataServices(services);
            RegisterNonDataServices(services);
        }


        static void RegisterRepositories(IServiceCollection services) 
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
        }

        static void RegisterDataServices(IServiceCollection services)
        {
            services.AddScoped<IEventService, EventService>();
        }


        static void RegisterNonDataServices(IServiceCollection services)
        {
            services.AddScoped<IPaymentGateway, StripeService>();
            services.AddScoped<ISmtpService, SmtpService>();
            services.AddScoped<ISmsService, SmsService>();
        }

    }
}
