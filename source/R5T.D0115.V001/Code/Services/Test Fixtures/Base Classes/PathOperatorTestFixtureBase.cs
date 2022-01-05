using System;

using R5T.T0118;


namespace R5T.D0115.V001
{
    public abstract class PathOperatorTestFixtureBase : ServiceTestFixtureBase<IPathOperator>
    {
        // For convenience.
        protected IPathOperator PathOperator => this.Service;


        protected PathOperatorTestFixtureBase(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}
