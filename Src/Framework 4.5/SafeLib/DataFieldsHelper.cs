using System;
using System.Collections.Generic;
using System.Reflection;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Class for help in work with data fields.
	/// </summary>
	public static class DataFieldsHelper
	{
		/// <summary>
		/// Returnt array of different avaliable data fields.
		/// </summary>
		/// <returns>Array of different avaliable data fields.</returns>
		public static IDataField[] GetDifferentDataFields()
		{
			List<IDataField> dataFields = new List<IDataField>();

			foreach( Type type in Assembly.GetExecutingAssembly().GetTypes() )
			{
				if( type.IsAbstract )
					continue;
				if( type.IsInterface )
					continue;

				if( type.GetInterface( "EdlinSoftware.Safe.SafeLib.IDataField", true ) == null )
					continue;

				dataFields.Add( (IDataField) Activator.CreateInstance( type ) );
			}

			return dataFields.ToArray();
		}
	}
}
