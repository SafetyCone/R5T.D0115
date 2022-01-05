using System;

using Microsoft.Extensions.DependencyInjection;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.D0115.V001.PathOperator;


namespace R5T.D0115.I001.V001.PathOperator
{
    [TestClass]
    public class ClassificationTests : ClassificationTestFixture
    {
        #region Static

        private static ServiceProvider ServiceProvider { get; set; }


        [ClassInitialize]
        public static void ClassInitialize(TestContext _)
        {
            ClassificationTests.ServiceProvider = Instances.ServiceProviderOperator.GetServiceProvider();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ClassificationTests.ServiceProvider.Dispose();
        }

        #endregion


        public ClassificationTests()
            : base(ClassificationTests.ServiceProvider)
        {
        }
    }
}