using System;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Wrong password exception.
	/// </summary>
	[Serializable]
	public class WrongPasswordException : SafeException
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		public WrongPasswordException() { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="message">Exception message.</param>
		public WrongPasswordException( string message ) : base( message ) { }
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="message">Exception message.</param>
		/// <param name="inner">Inner exception.</param>
		public WrongPasswordException( string message, Exception inner ) : base( message, inner ) { }
		/// <summary>
		/// Deserialization constructor.
		/// </summary>
		protected WrongPasswordException(
		 SerializationInfo info,
		 StreamingContext context )
			: base( info, context ) { }
	}
}
