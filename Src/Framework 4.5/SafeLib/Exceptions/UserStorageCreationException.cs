using System;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Exception of user storage creation.
	/// </summary>
	[Serializable]
	public class UserStorageCreationException : SafeException
	{
		/// <summary>
		/// Reason of error.
		/// </summary>
		public UserStorageStatus ErrorReason { get; private set; }

        /// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="status">User storage status.</param>
		public UserStorageCreationException( UserStorageStatus status )
        { ErrorReason = status; }

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="status">User storage status.</param>
		/// <param name="message">Error message.</param>
		public UserStorageCreationException( UserStorageStatus status, string message )
			: base( message )
        { ErrorReason = status; }

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="status">User storage status.</param>
		/// <param name="message">Error message.</param>
		/// <param name="inner">Inner exception.</param>
		public UserStorageCreationException( UserStorageStatus status, string message, Exception inner )
			: base( message, inner )
        { ErrorReason = status; }

		/// <summary>
		/// Constructor.
		/// </summary>
		protected UserStorageCreationException(
		 System.Runtime.Serialization.SerializationInfo info,
		 System.Runtime.Serialization.StreamingContext context )
			: base( info, context ) { }
	}
}
