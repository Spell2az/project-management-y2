using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WarehouseApp
{
    public partial class ReceiveForm : MaterialForm
    {
        public ReceiveForm()
        {
            InitializeComponent();
            panelReceiveSideline.Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            MainForm.ShowPanel(this);
        }

        private void txtItemBarcode_Leave(object sender, EventArgs e)
        {
            if (txtItemBarcode.Text != String.Empty)
            {
                panelReceiveSideline.Visible = !IsItemRegistered(txtItemBarcode.Text);
                lblSideline.Text = $"Sideline item {txtItemBarcode.Text}";
            }
           
        }

        private bool IsItemRegistered(string text)
        {
            return false;
        }

        private void btnCancelSideline_Click(object sender, EventArgs e)
        {
            panelReceiveSideline.Visible = false;
        }

        private void btnSideline_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Put item in the sideline area", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                ResetInputAndPanel();
            }
        }

        private void ResetInputAndPanel()
        {
            panelReceiveSideline.Visible = false;
            txtItemBarcode.Text = String.Empty;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (ReceiveItem(txtItemBarcode.Text, numItemQuantity.Value))
            {
                if (MessageBox.Show(this, $"Item {txtItemBarcode.Text} received, drop it to Ready to Stow area", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    ResetInputAndPanel();
                }
            }
        }

        private bool ReceiveItem(string text, decimal value)
        {
            return true;
        }
    }
}
