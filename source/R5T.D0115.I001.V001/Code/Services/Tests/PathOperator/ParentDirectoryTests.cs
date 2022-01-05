using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.D0115.V001.PathOperator;


namespace R5T.D0115.I001.V001.PathOperator
{
    [TestClass]
    public class ParentDirectoryTests : ParentDirectoryTestFixture
    {
        #region Static

        private static ServiceProvider ServiceProvider { get; set; }


        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            ParentDirectoryTests.ServiceProvider = Instances.ServiceProviderOperator.GetServiceProvider();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ParentDirectoryTests.ServiceProvider.Dispose();
        }

        #endregion


        public ParentDirectoryTests()
            : base(ParentDirectoryTests.ServiceProvider)
        {
        }
    }
}