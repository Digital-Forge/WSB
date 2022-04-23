using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using SystemOfBookHotel.Application.Interface;
using SystemOfBookHotel.Application.Service;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // services
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IAccessService, AccessService>();
            services.AddTransient<IAdminService, AdminService>();

            // validation
            services.AddTransient<IValidator<ClientDataVM>, ClientDataValidation>();
            services.AddTransient<IValidator<AccessVM>, AccessValidation>();

            return services;
        }
    }
}
