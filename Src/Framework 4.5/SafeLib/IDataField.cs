using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Interface of data field.
	/// </summary>
	public interface IDataField : ISerializable
	{
		/// <summary>
		/// Parent list of fields.
		/// </summary>
		FieldsList ParentList { get; set; }
		/// <summary>
		/// Name of data field.
		/// </summary>
		string Name { get; }
		/// <summary>
		/// Image of data field.
		/// </summary>
		Image Image { get; }
		/// <summary>
		/// Control for storing user data.
		/// </summary>
		Control FieldControl { get; }
		/// <summary>
		/// Control for editing properties of field control.
		/// </summary>
		Control PropertiesControl { get; }
		/// <summary>
		/// Saves data from field control.
		/// </summary>
		void SaveData();
		/// <summary>
		/// Saves properties from properties control.
		/// </summary>
		void SaveProperties();
		/// <summary>
		/// Does this field contain given text.
		/// </summary>
		/// <param name="text">Text to search.</param>
		/// <returns>True if field contains given text; false, otherwise.</returns>
		/// <exception cref="ArgumentNullException">Text is null or empty.</exception>
		bool ContainsText(string text);
	}
}
