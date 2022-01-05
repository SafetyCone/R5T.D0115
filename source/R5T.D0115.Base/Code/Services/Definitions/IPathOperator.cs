using System;

using R5T.T0064;


namespace R5T.D0115
{
    [ServiceDefinitionMarker]
    public interface IPathOperator : IServiceDefinition
    {
        #region All

        string GetParentDirectoryPath(string path);

        #endregion

        #region Classification

        /// <summary>
        /// Determines whether a path is directory indicated (ends with a directory separator char).
        /// </summary>
        bool IsDirectoryIndicatedPath(string path);
        /// <summary>
        /// Determines whether a path is a directory path.
        /// Note: there is no way to determine with certainty whether a stringly-typed path is a directory path without reference to a file system.
        /// However, this method provides the best possible answer.
        /// </summary>
        bool IsDirectoryPath(string path);
        /// <summary>
        /// Determines whether a path is a file path.
        /// Note: there is no way to determine with certainty whether a stringly-typed path is a file path without reference to a file system.
        /// However, this method provides the best possible answer.
        /// </summary>
        bool IsFilePath(string path);
        /// <summary>
        /// Determines whether a path contains any of the relative directory names (current directory name ("."), or parent directory name ("..")).
        /// </summary>
        bool IsUnresolvedPath(string path);

        #endregion

        #region Decomposition

        /// <summary>
        /// Splits a path into parts based on directory separators (both Windows and non-Windows).
        /// Provides all parts, even empty ones.
        /// </summary>
        string[] GetAllPathParts(string path);

        #endregion

        #region Resolution

        string ResolvePath(string path);

        #endregion
    }
}