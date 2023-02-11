using System;

using R5T.T0062;
using R5T.T0063;


namespace R5T.D0115.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="PathOperator"/> implementation of <see cref="IPathOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IPathOperator> AddPathOperatorAction(this IServiceAction _)
        {
            var serviceAction = _.New<IPathOperator>(services => services.AddPathOperator());
            return serviceAction;
        }
    }
}
