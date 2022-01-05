using System;

using R5T.D0115;


namespace System
{
    public static class IPathOperatorExtensions
    {
        public static bool IsResolvedPath(this IPathOperator pathOperator,
            string path)
        {
            var isUnresolvedPath = pathOperator.IsUnresolvedPath(path);

            var output = !isUnresolvedPath;
            return output;
        }
    }
}
