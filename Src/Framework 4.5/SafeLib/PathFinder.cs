using System;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Interface for getting path of global storage.
	/// </summary>
	public interface IPathFinder
	{
		/// <summary>
		/// Returns path to global storage directory.
		/// </summary>
		/// <returns>Path to global storage directory.</returns>
		string GetGlobalStorageDirectory();

		/// <summary>
		/// Returns directory name of user storage.
		/// </summary>
		/// <returns>Directory name of user storage.</returns>
		string GetUserStorageDirectory();
	}

    /// <summary>
    /// Creator of path finders.
    /// </summary>
    public static class PathFinderCreator
    {
        /// <summary>
        /// Creates a path finder for the current user.
        /// </summary>
        /// <returns></returns>
        public static IPathFinder Create()
        {
            var defaultPathFinder = new DefaultPathFinder();

            try
            {
                var referencePath = Path.Combine(defaultPathFinder.GetUserStorageDirectory(), "storage.ref");
                if (!File.Exists(referencePath))
                    return defaultPathFinder;

                var userStoragePath = File.ReadAllText(referencePath, Encoding.Default);

                return new UserSpecifiedPathFinder(userStoragePath);
            }
            catch (Exception)
            {
                return defaultPathFinder;
            }
        }
    }

	/// <summary>
	/// Class for getting default path to global storage.
	/// </summary>
	public class DefaultPathFinder : IPathFinder
	{
		/// <summary>
		/// Returns path to global storage directory.
		/// </summary>
		/// <returns>Path to global storage directory.</returns>
		public string GetGlobalStorageDirectory()
		{
			Uri codeBaseUri = new Uri(Assembly.GetExecutingAssembly().CodeBase);

			return Path.Combine(Path.GetDirectoryName(codeBaseUri.LocalPath), "Storage");
		}

		/// <summary>
		/// Returns directory name of user storage.
		/// </summary>
		/// <returns>Directory name of user storage.</returns>
		public string GetUserStorageDirectory()
		{
			return Path.Combine(GetGlobalStorageDirectory(), GetCurrentUserName());
		}

        /// <summary>
		/// Return name of current user.
		/// </summary>
		/// <returns>Name of current user.</returns>
		private static string GetCurrentUserName()
		{
			try
			{
				WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
				if (currentIdentity == null)
					return null;

				string[] nameParts = currentIdentity.Name.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
				if (nameParts == null)
					return null;

				return nameParts.Length > 1 ? nameParts[1] : nameParts[0];
			}
			catch
			{
				return null;
			}
		}
	}

    /// <summary>
	/// Class for getting user specified path to global storage.
	/// </summary>
    public class UserSpecifiedPathFinder : IPathFinder
    {
        private readonly string _path;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="path">Path to user-specified directory.</param>
        public UserSpecifiedPathFinder(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
            { throw new ArgumentNullException(nameof(path)); }

            _path = path;
        }

        /// <summary>
        /// Returns path to global storage directory.
        /// </summary>
        /// <returns>Path to global storage directory.</returns>
        public string GetGlobalStorageDirectory() => _path;

        /// <summary>
        /// Returns directory name of user storage.
        /// </summary>
        /// <returns>Directory name of user storage.</returns>
        public string GetUserStorageDirectory() => _path;
    }
}
