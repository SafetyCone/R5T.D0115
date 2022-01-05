using System;
using System.Linq;

using R5T.D0115;

using Instances = R5T.D0115.X001.Instances;


namespace System
{
    public static class IPathOperatorExtensions
    {
        public static string[] GetNonEmptyPathParts(this IPathOperator _,
            string path)
        {
            var output = Instances.PathOperator.GetNonEmptyPathParts(path);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetNonEmptyPathParts(IPathOperator, string)"/> as the default.
        /// </summary>
        public static string[] GetPathParts(this IPathOperator _,
            string path)
        {
            var output = Instances.PathOperator.GetPathParts(path);
            return output;
        }
    }
}