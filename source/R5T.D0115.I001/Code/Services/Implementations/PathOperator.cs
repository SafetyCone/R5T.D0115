using System;
using System.Collections.Generic;

using R5T.T0064;


namespace R5T.D0115.I001
{
    [ServiceImplementationMarker]
    public class PathOperator : IPathOperator, IServiceImplementation
    {
        public string[] GetAllPathParts(string path)
        {
            var output = Instances.PathOperator.GetAllPathParts(path);
            return output;
        }

        public bool IsDirectoryIndicatedPath(string path)
        {
            var output = Instances.PathOperator.IsDirectoryIndicated(path);
            return output;
        }

        public bool IsUnresolvedPath(string path)
        {
            var output = Instances.PathOperator.IsUnresolved(path);
            return output;
        }

        public string ResolvePath(string path)
        {
            var output = Instances.PathOperator.ResolvePath(path);
            return output;
        }

        public bool IsDirectoryPath(string path)
        {
            var output = Instances.PathOperator.IsDirectoryPath(path);
            return output;
        }

        public bool IsFilePath(string path)
        {
            var output = Instances.PathOperator.IsFilePath(path);
            return output;
        }

        public string GetParentDirectoryPath(string path)
        {
            var output = Instances.PathOperator.GetParentDirectoryPath(path);
            return output;
        }
    }
}