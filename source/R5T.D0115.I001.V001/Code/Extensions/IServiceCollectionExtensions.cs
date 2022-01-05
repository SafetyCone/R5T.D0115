using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0115.I001.V001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceProviderStartup"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddServiceProviderStartup(this IServiceCollection services)
        {
            services.AddSingleton<ServiceProviderStartup>();

            return services;
        }
    }
}
