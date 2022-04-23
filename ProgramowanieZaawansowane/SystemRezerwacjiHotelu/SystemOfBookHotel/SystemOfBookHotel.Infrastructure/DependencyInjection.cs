using Microsoft.Extensions.DependencyInjection;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Infrastructure.Repositories;

namespace SystemOfBookHotel.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IRoomRepository, RoomRepository>();
            services.AddTransient<IReservationRepository, ReservationRepository>();
            services.AddTransient<IExtraPerkRepository, ExtraPerkRepository>();
            services.AddTransient<IProgramSettingRepository, ProgramSettingRepository>();
            return services;
        }
    }
}
