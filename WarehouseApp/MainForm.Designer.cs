namespace WarehouseApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReceive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnStow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPick = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnShip = new MaterialSkin.Controls.MaterialRaisedButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSignOut = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panelMainControls = new System.Windows.Forms.Panel();
            this.panelMainControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReceive
            // 
            this.btnReceive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReceive.AutoSize = true;
            this.btnReceive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReceive.Depth = 0;
            this.btnReceive.Icon = null;
            this.btnReceive.Location = new System.Drawing.Point(333, 87);
            this.btnReceive.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnReceive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Primary = true;
            this.btnReceive.Size = new System.Drawing.Size(200, 36);
            this.btnReceive.TabIndex = 0;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnStow
            // 
            this.btnStow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStow.AutoSize = true;
            this.btnStow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStow.Depth = 0;
            this.btnStow.Icon = null;
            this.btnStow.Location = new System.Drawing.Point(333, 151);
            this.btnStow.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnStow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStow.Name = "btnStow";
            this.btnStow.Primary = true;
            this.btnStow.Size = new System.Drawing.Size(200, 36);
            this.btnStow.TabIndex = 1;
            this.btnStow.Text = "Stow";
            this.btnStow.UseVisualStyleBackColor = true;
            this.btnStow.Click += new System.EventHandler(this.btnStow_Click);
            // 
            // btnPick
            // 
            this.btnPick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPick.AutoSize = true;
            this.btnPick.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPick.Depth = 0;
            this.btnPick.Icon = null;
            this.btnPick.Location = new System.Drawing.Point(333, 216);
            this.btnPick.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnPick.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPick.Name = "btnPick";
            this.btnPick.Primary = true;
            this.btnPick.Size = new System.Drawing.Size(200, 36);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Pick";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnPack
            // 
            this.btnPack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPack.AutoSize = true;
            this.btnPack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPack.Depth = 0;
            this.btnPack.Icon = null;
            this.btnPack.Location = new System.Drawing.Point(333, 276);
            this.btnPack.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnPack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPack.Name = "btnPack";
            this.btnPack.Primary = true;
            this.btnPack.Size = new System.Drawing.Size(200, 36);
            this.btnPack.TabIndex = 3;
            this.btnPack.Text = "Pack";
            this.btnPack.UseVisualStyleBackColor = true;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // btnShip
            // 
            this.btnShip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShip.AutoSize = true;
            this.btnShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShip.Depth = 0;
            this.btnShip.Icon = null;
            this.btnShip.Location = new System.Drawing.Point(333, 338);
            this.btnShip.MinimumSize = new System.Drawing.Size(200, 0);
            this.btnShip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShip.Name = "btnShip";
            this.btnShip.Primary = true;
            this.btnShip.Size = new System.Drawing.Size(200, 36);
            this.btnShip.TabIndex = 4;
            this.btnShip.Text = "Ship";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSignOut.AutoSize = true;
            this.btnSignOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSignOut.Depth = 0;
            this.btnSignOut.Icon = null;
            this.btnSignOut.Location = new System.Drawing.Point(771, 18);
            this.btnSignOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSignOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Primary = false;
            this.btnSignOut.Size = new System.Drawing.Size(82, 36);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panelMainControls
            // 
            this.panelMainControls.BackColor = System.Drawing.Color.White;
            this.panelMainControls.Controls.Add(this.btnReceive);
            this.panelMainControls.Controls.Add(this.btnSignOut);
            this.panelMainControls.Controls.Add(this.btnStow);
            this.panelMainControls.Controls.Add(this.btnPick);
            this.panelMainControls.Controls.Add(this.btnPack);
            this.panelMainControls.Controls.Add(this.btnShip);
            this.panelMainControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainControls.Location = new System.Drawing.Point(0, 24);
            this.panelMainControls.Name = "panelMainControls";
            this.panelMainControls.Size = new System.Drawing.Size(866, 461);
            this.panelMainControls.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 485);
            this.Controls.Add(this.panelMainControls);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMainControls.ResumeLayout(false);
            this.panelMainControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnReceive;
        private MaterialSkin.Controls.MaterialRaisedButton btnShip;
        private MaterialSkin.Controls.MaterialRaisedButton btnPack;
        private MaterialSkin.Controls.MaterialRaisedButton btnPick;
        private MaterialSkin.Controls.MaterialRaisedButton btnStow;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialFlatButton btnSignOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panelMainControls;
    }
}