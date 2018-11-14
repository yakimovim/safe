using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace EdlinSoftware.Safe.SafeLib
{
    /// <summary>
    /// Class of global storage.
    /// </summary>
    public static class GlobalStorage
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static IPathFinder m_PathFinder = PathFinderCreator.Create();

        /// <summary>
        /// Finder of path to global storage.
        /// </summary>
        public static IPathFinder PathFinder
        {
            [DebuggerStepThrough]
            get { return m_PathFinder; }
            [DebuggerStepThrough]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                m_PathFinder = value;
            }
        }

        /// <summary>
        /// Returns directory name of global storage.
        /// </summary>
        /// <returns>Directory name of global storage.</returns>
        public static string GetGlobalStorageDirectory()
        {
            return ExecuteWithErrorLog(() =>
            {
                Debug.Assert(m_PathFinder != null);
                return m_PathFinder.GetGlobalStorageDirectory();
            });
        }

        /// <summary>
        /// Returns directory name of user storage.
        /// </summary>
        /// <returns>Directory name of user storage.</returns>
        public static string GetUserStorageDirectory()
        {
            return ExecuteWithErrorLog(() =>
            {
                Debug.Assert(m_PathFinder != null);
                return m_PathFinder.GetUserStorageDirectory();
            });
        }

        /// <summary>
        /// Does directory of global storage exists.
        /// </summary>
        /// <returns>Does directory of global storage exists.</returns>
        private static bool DoesGlobalStorageExists()
        {
            return ExecuteWithErrorLog(() => Directory.Exists(GetGlobalStorageDirectory()));
        }

        /// <summary>
        /// Does directory of global storage exists.
        /// </summary>
        /// <returns>Does directory of global storage exists.</returns>
        private static bool DoesUserStorageExists()
        {
            return ExecuteWithErrorLog(() => Directory.Exists(GetUserStorageDirectory()));
        }

        /// <summary>
        /// Does user have access to global storage.
        /// </summary>
        /// <returns>Does user have access to global storage.</returns>
        private static bool HasGlobalStorageAccess()
        {
            try
            {
                new DirectoryInfo(GetGlobalStorageDirectory()).GetFileSystemInfos();
                return true;
            }
            catch (Exception)
            { return false; }
        }

        /// <summary>
        /// Does user have access to user storage.
        /// </summary>
        /// <returns>Does user have access to user storage.</returns>
        private static bool HasUserStorageAccess()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(GetUserStorageDirectory());
                dirInfo.GetFileSystemInfos();

                FileInfo tempFileInfo = new FileInfo(Path.Combine(GetUserStorageDirectory(), Path.GetRandomFileName()));
                FileStream fStream = tempFileInfo.Create();
                fStream.Close();
                tempFileInfo.Delete();

                return true;
            }
            catch (Exception)
            { return false; }
        }

        /// <summary>
        /// Returns status of global storage.
        /// </summary>
        /// <returns>Status of global storage.</returns>
        public static GlobalStorageStatus GetGlobalStorageStatus()
        {
            if (!DoesGlobalStorageExists())
                return GlobalStorageStatus.Absent;

            if (!HasGlobalStorageAccess())
                return GlobalStorageStatus.NoAccess;

            return GlobalStorageStatus.Ready;
        }

        /// <summary>
        /// Returns status of user storage.
        /// </summary>
        /// <returns>Status of user storage.</returns>
        public static UserStorageStatus GetUserStorageStatus()
        {
            if (!DoesUserStorageExists())
                return UserStorageStatus.Absent;

            if (!HasUserStorageAccess())
                return UserStorageStatus.NoAccess;

            return UserStorageStatus.Ready;
        }

        /// <summary>
        /// Creates directory for global storage.
        /// </summary>
        public static void CreateGlobalStorage()
        {
            ExecuteWithErrorLog(() => Directory.CreateDirectory(GetGlobalStorageDirectory()));
        }

        /// <summary>
        /// Creates directory for user storage.
        /// </summary>
        public static void CreateUserStorageDirectory()
        {
            ExecuteWithErrorLog(() => {
                DirectorySecurity ds = new DirectorySecurity();
                ds.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Allow));
                Directory.CreateDirectory(GetUserStorageDirectory(), ds);
            });
        }

        private static void ExecuteWithErrorLog(Action actionToExecute)
        {
            try
            {
                actionToExecute();
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex.Message, ex);
            }
        }

        private static T ExecuteWithErrorLog<T>(Func<T> actionToExecute, T errorResult = default(T))
        {
            try
            {
                return actionToExecute();
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex.Message, ex);
                return errorResult;
            }
        }

        /// <summary>
        /// Returns object of user storage.
        /// </summary>
        /// <returns>Object of user storage.</returns>
        public static UserStorage GetUserStorage()
        {
            return UserStorage.GetInstance(GetUserStorageDirectory());
        }
    }
}
