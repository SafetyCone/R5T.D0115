using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0114;


namespace R5T.D0115.I001.V001
{
    public class ServiceProviderStartup : IServiceProviderStartup
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            var pathOperatorAction = Instances.ServiceAction.AddPathOperatorAction();

            // Run.
            services
                .Run(pathOperatorAction)
                ;

            return Task.CompletedTask;
        }
    }
}
