using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FinancialManagementApp.Shared
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
