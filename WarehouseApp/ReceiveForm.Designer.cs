namespace WarehouseApp
{
    partial class ReceiveForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtItemBarcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.btnReceive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblItemBarcode = new MaterialSkin.Controls.MaterialLabel();
            this.panelReceiveSideline = new System.Windows.Forms.Panel();
            this.btnCancelSideline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSideline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSideline = new MaterialSkin.Controls.MaterialLabel();
            this.numItemQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelReceiveSideline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(347, 87);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Scan Item";
            // 
            // txtItemBarcode
            // 
            this.txtItemBarcode.Depth = 0;
            this.txtItemBarcode.Hint = "";
            this.txtItemBarcode.Location = new System.Drawing.Point(164, 142);
            this.txtItemBarcode.MaxLength = 32767;
            this.txtItemBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemBarcode.Name = "txtItemBarcode";
            this.txtItemBarcode.PasswordChar = '\0';
            this.txtItemBarcode.SelectedText = "";
            this.txtItemBarcode.SelectionLength = 0;
            this.txtItemBarcode.SelectionStart = 0;
            this.txtItemBarcode.Size = new System.Drawing.Size(228, 23);
            this.txtItemBarcode.TabIndex = 1;
            this.txtItemBarcode.TabStop = false;
            this.txtItemBarcode.UseSystemPasswordChar = false;
            this.txtItemBarcode.Leave += new System.EventHandler(this.txtItemBarcode_Leave);
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Depth = 0;
            this.lblItemQuantity.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemQuantity.Location = new System.Drawing.Point(443, 142);
            this.lblItemQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(93, 19);
            this.lblItemQuantity.TabIndex = 2;
            this.lblItemQuantity.Text = "Item Quanity";
            // 
            // btnReceive
            // 
            this.btnReceive.AutoSize = true;
            this.btnReceive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReceive.Depth = 0;
            this.btnReceive.Icon = null;
            this.btnReceive.Location = new System.Drawing.Point(348, 297);
            this.btnReceive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Primary = true;
            this.btnReceive.Size = new System.Drawing.Size(75, 36);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // lblItemBarcode
            // 
            this.lblItemBarcode.AutoSize = true;
            this.lblItemBarcode.Depth = 0;
            this.lblItemBarcode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblItemBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblItemBarcode.Location = new System.Drawing.Point(41, 146);
            this.lblItemBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemBarcode.Name = "lblItemBarcode";
            this.lblItemBarcode.Size = new System.Drawing.Size(98, 19);
            this.lblItemBarcode.TabIndex = 5;
            this.lblItemBarcode.Text = "Item Barcode";
            // 
            // panelReceiveSideline
            // 
            this.panelReceiveSideline.Controls.Add(this.btnCancelSideline);
            this.panelReceiveSideline.Controls.Add(this.btnSideline);
            this.panelReceiveSideline.Controls.Add(this.materialLabel2);
            this.panelReceiveSideline.Controls.Add(this.lblSideline);
            this.panelReceiveSideline.Location = new System.Drawing.Point(96, 109);
            this.panelReceiveSideline.Name = "panelReceiveSideline";
            this.panelReceiveSideline.Size = new System.Drawing.Size(588, 290);
            this.panelReceiveSideline.TabIndex = 6;
            this.panelReceiveSideline.Visible = false;
            // 
            // btnCancelSideline
            // 
            this.btnCancelSideline.AutoSize = true;
            this.btnCancelSideline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelSideline.Depth = 0;
            this.btnCancelSideline.Icon = null;
            this.btnCancelSideline.Location = new System.Drawing.Point(175, 156);
            this.btnCancelSideline.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelSideline.Name = "btnCancelSideline";
            this.btnCancelSideline.Primary = true;
            this.btnCancelSideline.Size = new System.Drawing.Size(73, 36);
            this.btnCancelSideline.TabIndex = 3;
            this.btnCancelSideline.Text = "Cancel";
            this.btnCancelSideline.UseVisualStyleBackColor = true;
            this.btnCancelSideline.Click += new System.EventHandler(this.btnCancelSideline_Click);
            // 
            // btnSideline
            // 
            this.btnSideline.AutoSize = true;
            this.btnSideline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSideline.Depth = 0;
            this.btnSideline.Icon = null;
            this.btnSideline.Location = new System.Drawing.Point(328, 156);
            this.btnSideline.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSideline.Name = "btnSideline";
            this.btnSideline.Primary = true;
            this.btnSideline.Size = new System.Drawing.Size(114, 36);
            this.btnSideline.TabIndex = 2;
            this.btnSideline.Text = "Sideline Item";
            this.btnSideline.UseVisualStyleBackColor = true;
            this.btnSideline.Click += new System.EventHandler(this.btnSideline_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(233, 12);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(107, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Item not found";
            // 
            // lblSideline
            // 
            this.lblSideline.AutoSize = true;
            this.lblSideline.Depth = 0;
            this.lblSideline.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSideline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSideline.Location = new System.Drawing.Point(221, 85);
            this.lblSideline.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSideline.Name = "lblSideline";
            this.lblSideline.Size = new System.Drawing.Size(108, 19);
            this.lblSideline.TabIndex = 0;
            this.lblSideline.Text = "materialLabel2";
            // 
            // numItemQuantity
            // 
            this.numItemQuantity.Location = new System.Drawing.Point(553, 141);
            this.numItemQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numItemQuantity.Name = "numItemQuantity";
            this.numItemQuantity.Size = new System.Drawing.Size(93, 20);
            this.numItemQuantity.TabIndex = 7;
            this.numItemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReceiveSideline);
            this.Controls.Add(this.lblItemBarcode);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.numItemQuantity);
            this.Controls.Add(this.txtItemBarcode);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ReceiveForm";
            this.Text = "ReceiveForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelReceiveSideline.ResumeLayout(false);
            this.panelReceiveSideline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemBarcode;
        private MaterialSkin.Controls.MaterialLabel lblItemQuantity;
        private MaterialSkin.Controls.MaterialRaisedButton btnReceive;
        private MaterialSkin.Controls.MaterialLabel lblItemBarcode;
        private System.Windows.Forms.Panel panelReceiveSideline;
        private MaterialSkin.Controls.MaterialRaisedButton btnSideline;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblSideline;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelSideline;
        private System.Windows.Forms.NumericUpDown numItemQuantity;
    }
}