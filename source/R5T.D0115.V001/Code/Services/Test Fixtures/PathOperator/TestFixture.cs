using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0118;


namespace R5T.D0115.V001.PathOperator
{
    [ServiceTestFixtureMarker]
    public abstract class TestFixture : PathOperatorTestFixtureBase
    {



        protected TestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}
