using System;

using R5T.T0042;


namespace R5T.D0115.X001
{
    public static class Instances
    {
        public static T0041.IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static IStringOperator StringOperator { get; } = T0042.StringOperator.Instance;
    }
}
