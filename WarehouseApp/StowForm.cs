using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace WarehouseApp
{
    public partial class StowForm : MaterialForm
    {
        public StowForm()
        {
            InitializeComponent();
            panelReceiveSideline.Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            MainForm.ShowPanel(this);
        }

        private void txtLocation_Leave(object sender, EventArgs e)
        {
            if(txtLocation.Text != String.Empty)
            {
                if (!IsLocationValid(txtLocation.Text))
                {
                    MessageBox.Show(this, $"{txtLocation.Text} does not seem to be a valid location", "", MessageBoxButtons.OK);
                }
            }
        }

        private bool IsLocationValid(string locationId)
        {
            // Check if it is valid location id
            return true;
        }

        private bool IsItemRegistered(string itemBarcode)
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
                panelReceiveSideline.Visible = false;
            }
        }

        private void txtItemBarcode_Leave(object sender, EventArgs e)
        {
            if (txtItemBarcode.Text != String.Empty)
            {
                panelReceiveSideline.Visible = !IsItemRegistered(txtItemBarcode.Text);
                lblSideline.Text = $"Sideline item {txtItemBarcode.Text}";
            }
        }

        private void btnStow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, $"{txtItemBarcode.Text} stowed into location {txtLocation.Text}", "", MessageBoxButtons.OK);
        }
    }
}
