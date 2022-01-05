using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0118;


namespace R5T.D0115.V001.PathOperator
{
    [ServiceTestFixtureMarker]
    public abstract class ParentDirectoryTestFixture : PathOperatorTestFixtureBase
    {
        [TestMethod]
        public void WindowsFilePath01()
        {
            var expectedValue = Instances.ExpectedValue.ParentDirectoryForWindowsFile01();

            var actualValue = this.Service.GetParentDirectoryPath(expectedValue.Input);

            Instances.Assertion.AreEqual(expectedValue, actualValue);
        }


        protected ParentDirectoryTestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}
