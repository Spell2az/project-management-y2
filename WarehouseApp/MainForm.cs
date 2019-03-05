using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace WarehouseApp
{
    public partial class MainForm : Form
    {
        public static void ShowPanel(Form form)
        {
            var findResult = form.MdiParent.Controls.Find("panelMainControls", true);
            if (findResult.Length == 1)
            {
                findResult[0].Show();
            }
        }

        public Panel ControlPanel;
        public MainForm()
        {
            InitializeComponent();
           
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ControlPanel = panelMainControls;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void ShowTaskForm<T>() where T: Form, new()
        {
            var form = new T()
            {
                MdiParent = this
            };
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            form.BringToFront();
            panelMainControls.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Task Form Button Handlers

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ShowTaskForm<ReceiveForm>();
        }
        private void btnStow_Click(object sender, EventArgs e)
        {
            ShowTaskForm<StowForm>();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            ShowTaskForm<PickForm>();
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            ShowTaskForm<PackForm>();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            ShowTaskForm<ShipForm>();
        }

        #endregion
        
    }
}
