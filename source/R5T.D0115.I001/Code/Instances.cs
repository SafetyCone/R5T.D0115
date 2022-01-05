using System;

using R5T.T0041;
using R5T.T0042;


namespace R5T.D0115.I001
{
    public static class Instances
    {
        public static IDirectorySeparator DirectorySeparator { get; } = T0041.DirectorySeparator.Instance;
        public static T0041.IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IStringOperator StringOperator { get; } = T0042.StringOperator.Instance;
    }
}
