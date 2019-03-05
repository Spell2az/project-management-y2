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
        private ReceiveForm receiveForm;
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
            ControlPanel = mainControlsPanel;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {

            PickForm pickForm = new PickForm();
            pickForm.MdiParent = this;
            pickForm.Show();
            pickForm.BringToFront();
            mainControlsPanel.Hide();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            receiveForm = new ReceiveForm();
          
            receiveForm.Show();
        }

        private void pickToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pcikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
