using System;
using System.Diagnostics;
using System.Windows.Forms;
using EdlinSoftware.Safe.Properties;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
	/// <summary>
	/// Form for work with data fields.
	/// </summary>
	public partial class DataFieldsForm : Form
	{
		/// <summary>
		/// Selected item.
		/// </summary>
		private ListViewItem _selectedItem;

		/// <summary>
		/// Topic to work with.
		/// </summary>
		public Topic Topic { get; set; }

		/// <summary>
		/// Constructor.
		/// </summary>
		[DebuggerStepThrough]
		public DataFieldsForm()
		{
			InitializeComponent();
		}

		private void OnAddField( object sender, EventArgs e )
		{
			var frm = new AddDataFieldForm();
			if( frm.ShowDialog( this ) == DialogResult.OK )
			{
			    foreach (var dataField in frm.DataFields)
			    {
                    AddField(dataField);
                }
			}
		}

		private void OnFormShown( object sender, EventArgs e )
		{
			foreach( IDataField dataField in Topic.Fields )
			{
				lvDataFields.Items.Add( GetFieldItem( dataField ) );
			}
		}

		private void OnFormClosing( object sender, FormClosingEventArgs e )
		{
			if( _selectedItem != null )
			{
				GetItemField( _selectedItem ).SaveProperties();
				_selectedItem.Text = GetItemField( _selectedItem ).Name;
			}
		}

		private void OnSelectedFieldChanged( object sender, EventArgs e )
		{
			if( _selectedItem != null )
			{
				GetItemField( _selectedItem ).SaveProperties();
				_selectedItem.Text = GetItemField( _selectedItem ).Name;
			}

			splitContainer.Panel2.Controls.Clear();

			if( lvDataFields.SelectedItems.Count > 0 )
			{
				IDataField dataField = GetItemField( lvDataFields.SelectedItems[ 0 ] );
				dataField.PropertiesControl.Dock = DockStyle.Top;

				splitContainer.Panel2.Controls.Add( dataField.PropertiesControl );

				_selectedItem = lvDataFields.SelectedItems[ 0 ];
			}
			else
			{ _selectedItem = null; }
		}

		private void OnDelete( object sender, EventArgs e )
		{
			if( lvDataFields.SelectedItems.Count > 0 )
			{
				DialogResult res =
					MessageBox.Show(
						this,
						Resources.DataFieldDeleteConfirmation,
						Resources.Confirmation,
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
						);

				if( res == DialogResult.Yes )
				{
					IDataField dataField = GetItemField( lvDataFields.SelectedItems[ 0 ] );

					Topic.Fields.Remove( dataField );

					lvDataFields.Items.Remove( lvDataFields.SelectedItems[ 0 ] );
				}
			}
		}

		private void OnMoveUp( object sender, EventArgs e )
		{
			if( lvDataFields.SelectedItems.Count > 0 )
			{
				if( lvDataFields.SelectedIndices[ 0 ] > 0 )
				{
					IDataField dataField = GetItemField( lvDataFields.SelectedItems[ 0 ] );

					int index = Topic.Fields.IndexOf( dataField );
					Debug.Assert( index > 0, "Element can't be the first." );

					ListViewItem item = lvDataFields.SelectedItems[ 0 ];

					lvDataFields.Items.RemoveAt( index );
					lvDataFields.Items.Insert( index - 1, item );

					Topic.Fields.Move( index, index - 1 );
				}
			}
		}

		private void OnMoveDown( object sender, EventArgs e )
		{
			if( lvDataFields.SelectedItems.Count > 0 )
			{
				if( lvDataFields.SelectedIndices[ 0 ] < lvDataFields.Items.Count - 1 )
				{
					IDataField dataField = GetItemField( lvDataFields.SelectedItems[ 0 ] );

					int index = Topic.Fields.IndexOf( dataField );
					Debug.Assert( index < Topic.Fields.Count - 1, "Element can't be the last." );

					ListViewItem item = lvDataFields.SelectedItems[ 0 ];

					lvDataFields.Items.RemoveAt( index );
					lvDataFields.Items.Insert( index + 1, item );

					Topic.Fields.Move( index, index + 1 );
				}
			}
		}

		/// <summary>
		/// Adds data field to the list of fields.
		/// </summary>
		/// <param name="dataField">Data field to add.</param>
		private void AddField( IDataField dataField )
		{
			if( dataField == null )
				throw new ArgumentNullException( "dataField" );

			Topic.Fields.Add( dataField );

			lvDataFields.Items.Add( GetFieldItem( dataField ) );
		}

		/// <summary>
		/// Returns list view item for data field.
		/// </summary>
		/// <param name="dataField">Data field.</param>
		/// <returns>List view item for data field.</returns>
		private ListViewItem GetFieldItem( IDataField dataField )
		{
			if( dataField == null )
				throw new ArgumentNullException( "dataField" );

			var item = new ListViewItem {Text = dataField.Name, Tag = dataField};

		    if( dataField.Image != null )
			{
				ilFieldsImages.Images.Add( dataField.Image );
				item.ImageIndex = ilFieldsImages.Images.Count - 1;
				item.StateImageIndex = ilFieldsImages.Images.Count - 1;
			}

			return item;
		}

		/// <summary>
		/// Returns data field for list view item.
		/// </summary>
		/// <param name="item">List view item.</param>
		/// <returns>Data field for list view item.</returns>
		private static IDataField GetItemField( ListViewItem item )
		{
			if( item == null )
				return null;

			Debug.Assert( item.Tag is IDataField, "Each item must be connected with data field." );
			return (IDataField) item.Tag;
		}
	}
}