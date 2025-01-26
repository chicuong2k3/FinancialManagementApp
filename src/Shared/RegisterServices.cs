using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Shared
{
    public static class RegisterServices
    {
        public static IServiceCollection AddSharedServices(this IServiceCollection services)
        {
            var assembly = typeof(RegisterServices).Assembly;

            services.AddValidatorsFromAssemblies([assembly]);

            return services;
        }
    }
}
