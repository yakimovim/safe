using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe.SafeLibTest
{
    /// <summary>
    /// Class of utilities.
    /// </summary>
    internal class Utils
    {
        private static readonly string randomName = Path.GetRandomFileName();
        private static IPathFinder m_PathFinder;

        static Utils()
        {
            Uri codeBasePath = new Uri(Assembly.GetExecutingAssembly().CodeBase);

            string path = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(codeBasePath.LocalPath), @"..\..\..\..\..\Test"));

            m_PathFinder = new TestPathFinder(path);
        }

        /// <summary>
        /// Returns test path finder.
        /// </summary>
        /// <returns>Test path finder.</returns>
        public static IPathFinder PathFinder
        {
            [DebuggerStepThrough]
            get { return m_PathFinder; }
        }

        /// <summary>
        /// Returns path finder to directory with no access.
        /// </summary>
        /// <returns>Path finder to directory with no access.</returns>
        public static IPathFinder GetNoAccessPathFinder()
        {
            return new TestPathFinder(Path.Combine(PathFinder.GetGlobalStorageDirectory(), "NoAccess"));
        }

        /// <summary>
        /// Returns path finder to absent directory.
        /// </summary>
        /// <returns>Path finder to absent directory.</returns>
        public static IPathFinder GetAbsentPathFinder()
        {
            return new TestPathFinder(Path.Combine(PathFinder.GetGlobalStorageDirectory(), randomName));
        }
    }

    /// <summary>
    /// Path finder for test.
    /// </summary>
    public class TestPathFinder : IPathFinder
    {
        private string m_Path;

        public TestPathFinder(string path)
        {
            m_Path = path;
        }

        #region IPathFinder Members

        public string GetGlobalStorageDirectory()
        {
            return m_Path;
        }

        public string GetUserStorageDirectory()
        {
            return m_Path;
        }

        #endregion
    }
}
