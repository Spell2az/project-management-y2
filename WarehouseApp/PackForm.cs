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
    public partial class PackForm : MaterialForm
    {
        private string itemBarcode = "B0117RGXC8";
        public PackForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            MainForm.ShowPanel(this);
        }

        private void btnFinishPack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Drop Items to Ready To Ship area", "", MessageBoxButtons.OK) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Label Printed", "", MessageBoxButtons.OK);
        }
    }
}
