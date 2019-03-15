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
    public partial class ShipForm : MaterialForm
    {
        public ShipForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            MainForm.ShowPanel(this);
        }

        private void btnFinishShipping_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDispatchItem_Click(object sender, EventArgs e)
        {
            if(txtItemBarcode.Text != string.Empty)
            {
                MessageBox.Show(this, "Item Dispatched", "", MessageBoxButtons.OK);
            }
            
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
