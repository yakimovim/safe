using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EdlinSoftware.Safe.SafeLib;

namespace EdlinSoftware.Safe
{
    /// <summary>
    /// Form for selecting one type of data field.
    /// </summary>
    public partial class AddDataFieldForm : Form
    {
        /// <summary>
        /// Array of different data fields.
        /// </summary>
        private static readonly IDataField[] AvailableDataFields = DataFieldsHelper.GetDifferentDataFields();

        /// <summary>
        /// Selected data fields.
        /// </summary>
        public IDataField[] DataFields
        {
            get
            {
                if (lvDataFields.SelectedIndices.Count == 0)
                    return null;

                return lvDataFields.SelectedIndices
                    .OfType<int>()
                    .Select(i => AvailableDataFields[i].GetType())
                    .Select(t => (IDataField)Activator.CreateInstance(t))
                    .ToArray();
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        [DebuggerStepThrough]
        public AddDataFieldForm()
        {
            InitializeComponent();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            foreach (IDataField field in AvailableDataFields)
            {
                var item = new ListViewItem { Text = field.Name };

                if (field.Image != null)
                {
                    ilDataFields.Images.Add(field.Image);
                    item.ImageIndex = ilDataFields.Images.Count - 1;
                    item.StateImageIndex = ilDataFields.Images.Count - 1;
                }

                lvDataFields.Items.Add(item);
            }
        }

        private void OnOk(object sender, EventArgs e)
        {
            if (lvDataFields.SelectedIndices.Count > 0)
                DialogResult = DialogResult.OK;
        }
    }
}