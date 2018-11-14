using System;
using System.Collections.Generic;
using System.Text;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Enumeration of statuses of user storage.
	/// </summary>
	public enum UserStorageStatus
	{
		/// <summary>
		/// User storage does not exist.
		/// </summary>
		Absent,
		/// <summary>
		/// User storage is ready to use.
		/// </summary>
		Ready,
		/// <summary>
		/// There is no access to user storage.
		/// </summary>
		NoAccess
	}
}
