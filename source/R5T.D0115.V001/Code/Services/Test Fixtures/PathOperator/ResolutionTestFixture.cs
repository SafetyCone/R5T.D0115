using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0118;


namespace R5T.D0115.V001.PathOperator
{
    [ServiceTestFixtureMarker]
    public abstract class ResolutionTestFixture : PathOperatorTestFixtureBase
    {
        #region Windows

        /// <summary>
        /// Test resolution of an unresolved Windows file path.
        /// </summary>
        [TestMethod]
        public void ResolveWindowsFilePath()
        {
            var expected = Instances.ExpectedValue.ResolutionForUnresolvedWindowsFilePath();

            var actual = this.PathOperator.ResolvePath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test resolution of an unresolved Windows directory path.
        /// </summary>
        [TestMethod]
        public void ResolveWindowsDirectoryPath()
        {
            var expected = Instances.ExpectedValue.ResolutionForUnresolvedWindowsDirectoryPath();

            var actual = this.PathOperator.ResolvePath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        #endregion

        #region Non-Windows

        /// <summary>
        /// Test resolution of an unresolved non-Windows file path.
        /// </summary>
        [TestMethod]
        public void ResolveNonWindowsFilePath()
        {
            var expected = Instances.ExpectedValue.ResolutionForUnresolvedNonWindowsFilePath();

            var actual = this.PathOperator.ResolvePath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test resolution of an unresolved non-Windows directory path.
        /// </summary>
        [TestMethod]
        public void ResolveNonWindowsDirectoryPath()
        {
            var expected = Instances.ExpectedValue.ResolutionForUnresolvedNonWindowsDirectoryPath();

            var actual = this.PathOperator.ResolvePath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        #endregion


        protected ResolutionTestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}
