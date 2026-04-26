using System;
using System.Windows.Forms;

namespace NoFences
{
    public partial class EditDialog : Form
    {
        public EditDialog(string oldName)
        {
            InitializeComponent();
            tbName.Text = oldName;
        }

        public string NewName => tbName.Text;

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
