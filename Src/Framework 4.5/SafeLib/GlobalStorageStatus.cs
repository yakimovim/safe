
namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Enumeration of statuses of global storage.
	/// </summary>
	public enum GlobalStorageStatus
	{
		/// <summary>
		/// Global storage does not exist.
		/// </summary>
		Absent,
		/// <summary>
		/// Global storage is ready to use.
		/// </summary>
		Ready,
		/// <summary>
		/// There is no access to global storage.
		/// </summary>
		NoAccess
	}
}
