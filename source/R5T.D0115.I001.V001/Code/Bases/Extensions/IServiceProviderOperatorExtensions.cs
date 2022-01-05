using System;

using R5T.D0114;
using R5T.T0061;

using ServiceProvider = Microsoft.Extensions.DependencyInjection.ServiceProvider;


namespace R5T.D0115.I001.V001
{
    public static class IServiceProviderOperatorExtensions
    {
        public static ServiceProvider GetServiceProvider(this IServiceProviderOperator _)
        {
            var output = Instances.ServiceProvider.NewBuilder()
                .UseServiceProviderStartup<ServiceProviderStartup, T0079.IServiceProviderBuilder>(
                    Instances.ServiceAction.AddServiceProviderStartupAction())
                .Build()
                ;

            return output;
        }
    }
}
