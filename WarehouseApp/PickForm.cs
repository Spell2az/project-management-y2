using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseApp
{
    public partial class PickForm : Form
    {
        public PickForm()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            var panel = this.MdiParent.Controls.Find("mainControlsPanel", true);
            panel[0].Visible = true;
        }
    }
}
