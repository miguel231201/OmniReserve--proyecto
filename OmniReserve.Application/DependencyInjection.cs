using Microsoft.Extensions.DependencyInjection;

namespace OmniReserve.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Aquí se registrarán los servicios de la capa de Aplicación
        return services;
    }
}