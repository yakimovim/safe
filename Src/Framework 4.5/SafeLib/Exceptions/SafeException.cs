using System;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Base class for all Safe exceptions. 
	/// </summary>
	[Serializable]
	public abstract class SafeException : ApplicationException
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public SafeException() { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="message">Error message.</param>
		public SafeException( string message ) : base( message ) { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="message">Error message.</param>
		/// <param name="inner">Inner exception.</param>
		public SafeException( string message, Exception inner ) : base( message, inner ) { }
		/// <summary>
		/// Deserialization constructor.
		/// </summary>
		protected SafeException(
		 SerializationInfo info,
		 StreamingContext context )
			: base( info, context ) { }
	}
}
