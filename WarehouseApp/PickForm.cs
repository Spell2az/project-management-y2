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
    public partial class PickForm : MaterialForm
    {
        private string itemBarcode = "B0117RGXC8";
        public PickForm()
        {
            InitializeComponent();
            lblItemBarcode.Text = itemBarcode;

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            MainForm.ShowPanel(this);
        }

        private void btnFinishPick_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Drop Items to Ready To Pack area", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnPickItem_Click(object sender, EventArgs e)
        {
            if(txtItemBarcode.Text != String.Empty)
            {
                if (txtItemBarcode.Text == itemBarcode)
                {
                    MessageBox.Show(this, $"{itemBarcode} picked succesfully", "", MessageBoxButtons.OK);
                } else
                {
                    MessageBox.Show(this, $"Wrong item", "", MessageBoxButtons.OK);
                }
            }
            

            
        }
    }
}
