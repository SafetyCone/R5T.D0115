using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0115.I001.V001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ServiceProviderStartup"/> operation as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ServiceProviderStartup> AddServiceProviderStartupAction(this IServiceAction _)
        {
            var serviceAction = _.New<ServiceProviderStartup>(services => services.AddServiceProviderStartup());
            return serviceAction;
        }
    }
}
