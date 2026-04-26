using NoFences.Model;
using System;
using System.Windows.Forms;

namespace NoFences
{
    public partial class FenceSettings : Form
    {
        private FenceInfo fence;

        public FenceSettings(FenceInfo fenceToEdit)
        {
            InitializeComponent();
            fence = fenceToEdit;
            chkLocked.Checked = fence.Locked;
            chkMinify.Checked = fence.CanMinify;
            txtFenceName.Text = fence.Name;
            numTitleHeight.Value = fence.TitleHeight;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            fence.Locked = chkLocked.Checked;
            fence.CanMinify = chkMinify.Checked;
            fence.Name = txtFenceName.Text;
            fence.TitleHeight = (int)numTitleHeight.Value;

            // Save changes to disk
            FenceManager.Instance.UpdateFence(fence);

            base.OnFormClosing(e);
        }
        private void btnNewFence_Click(object sender, EventArgs e)
        {
            // Use the existing instance API. Provide a default name or obtain one from UI.
            FenceManager.Instance.CreateFence("New Fence");
        }

        private void btnDeleteFence_Click(object sender, EventArgs e)
        {
            // RemoveFence expects a FenceInfo object (per provided signature), not an id.
            FenceManager.Instance.RemoveFence(fence);
            this.Close();
        }



    }
}

