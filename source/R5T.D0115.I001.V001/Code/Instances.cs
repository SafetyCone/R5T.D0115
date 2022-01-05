using System;

using R5T.T0061;
using R5T.T0062;


namespace R5T.D0115.I001.V001
{
    public static class Instances
    {
        public static IServiceAction ServiceAction { get; } = T0062.ServiceAction.Instance;
        public static T0061.IServiceProvider ServiceProvider { get; } = T0061.ServiceProvider.Instance;
        public static IServiceProviderOperator ServiceProviderOperator { get; } = T0061.ServiceProviderOperator.Instance;
    }
}
