using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using R5T.T0118;


namespace R5T.D0115.V001.PathOperator
{
    [ServiceTestFixtureMarker]
    public abstract class ClassificationTestFixture : PathOperatorTestFixtureBase
    {
        #region Directory and File

        /// <summary>
        /// Tests that a directory path is recognized as a directory path.
        /// </summary>
        [TestMethod]
        public void IsDirectoryPathADirectoryPath()
        {
            var expected = Instances.ExpectedValue.IsDirectoryIndicatedForDirectoryIndicatedPath();

            var actual = this.PathOperator.IsDirectoryPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that a non-directory indicated path is not recognized as a directory path.
        /// Note: even though the non-directory indicated path could be a directory path, without reference to a file system it could also be a file path!
        /// At the stringly-typed level of abstraction there is no way to know for sure without asking a file system.
        /// </summary>
        [TestMethod]
        public void IsNonDirectoryIndicatedPathNotADirectoryPath()
        {
            var expected = Instances.ExpectedValue.IsNotDirectoryIndicatedForNonDirectoryIndicatedPath();

            var actual = this.PathOperator.IsDirectoryPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Whether or not a path is a Windows or non-Windows path should be irrelevant to whether it is a directory path.
        /// </summary>
        [TestMethod]
        public void IsDirectoryPathWindowsOrNonWindowsIrrelevant()
        {
            var expecteds = new[]
            {
                Instances.ExpectedValue.IsDirectoryIndicatedForDirectoryIndicatedPath_NonWindows(),
                Instances.ExpectedValue.IsDirectoryIndicatedForDirectoryIndicatedPath_Windows(),
                Instances.ExpectedValue.IsNotDirectoryIndicatedForNonDirectoryIndicatedPath_NonWindows(),
                Instances.ExpectedValue.IsNotDirectoryIndicatedForNonDirectoryIndicatedPath_Windows(),
            };

            var actuals = expecteds.Select(expected => this.PathOperator.IsDirectoryPath(expected));

            Instances.Assertion.AreEqual(expecteds, actuals);
        }

        #endregion

        #region Resolved and Unresolved

        /// <summary>
        /// Tests that a resolved path is recognized as resolved.
        /// </summary>
        [TestMethod]
        public void IsAResolvedPathAResolvedPath()
        {
            var expected = Instances.ExpectedValue.ResolvedPathIsResolved();

            var actual = this.PathOperator.IsResolvedPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that an unresolved path is not recognized as resolved.
        /// </summary>
        [TestMethod]
        public void IsAnUnresolvedPathNotAResolvedPath()
        {
            var expected = Instances.ExpectedValue.UnresolvedPathIsNotResolved();

            var actual = this.PathOperator.IsResolvedPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that an unresolved path is recognized as unresolved.
        /// </summary>
        [TestMethod]
        public void IsAnUnresolvedPathAnUnresolvedPath()
        {
            var expected = Instances.ExpectedValue.UnresolvedPathIsUnresolved();

            var actual = this.PathOperator.IsUnresolvedPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        /// <summary>
        /// Tests that an resolved path is not recognized as unresolved.
        /// </summary>
        [TestMethod]
        public void IsAResolvedPathNotAnUnresolvedPath()
        {
            var expected = Instances.ExpectedValue.ResolvedPathIsNotUnresolved();

            var actual = this.PathOperator.IsUnresolvedPath(expected);

            Instances.Assertion.AreEqual(expected, actual);
        }

        #endregion


        protected ClassificationTestFixture(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }
    }
}