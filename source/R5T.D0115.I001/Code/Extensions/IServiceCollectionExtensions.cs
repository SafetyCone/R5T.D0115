using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.T0063;


namespace R5T.D0115.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="PathOperator"/> implementation of <see cref="IPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddPathOperator(this IServiceCollection services)
        {
            services.AddSingleton<IPathOperator, PathOperator>();

            return services;
        }
    }
}