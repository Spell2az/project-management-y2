namespace WarehouseApp
{
    partial class StowForm
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
            this.txtLocation = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblScanLocation = new MaterialSkin.Controls.MaterialLabel();
            this.lblScanItem = new MaterialSkin.Controls.MaterialLabel();
            this.btnStow = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtItemBarcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblItemQuantity = new MaterialSkin.Controls.MaterialLabel();
            this.numItemQuanity = new System.Windows.Forms.NumericUpDown();
            this.panelReceiveSideline = new System.Windows.Forms.Panel();
            this.btnCancelSideline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSideline = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblSideline = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuanity)).BeginInit();
            this.panelReceiveSideline.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Depth = 0;
            this.txtLocation.Hint = "";
            this.txtLocation.Location = new System.Drawing.Point(294, 144);
            this.txtLocation.MaxLength = 32767;
            this.txtLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.SelectedText = "";
            this.txtLocation.SelectionLength = 0;
            this.txtLocation.SelectionStart = 0;
            this.txtLocation.Size = new System.Drawing.Size(233, 23);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.TabStop = false;
            this.txtLocation.UseSystemPasswordChar = false;
            this.txtLocation.Leave += new System.EventHandler(this.txtLocation_Leave);
            // 
            // lblScanLocation
            // 
            this.lblScanLocation.AutoSize = true;
            this.lblScanLocation.Depth = 0;
            this.lblScanLocation.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblScanLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblScanLocation.Location = new System.Drawing.Point(129, 144);
            this.lblScanLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblScanLocation.Name = "lblScanLocation";
            this.lblScanLocation.Size = new System.Drawing.Size(105, 19);
            this.lblScanLocation.TabIndex = 1;
            this.lblScanLocation.Text = "Scan Location";
            // 
            // lblScanItem
            // 
            this.lblScanItem.AutoSize = true;
            this.lblScanItem.Depth = 0;
            this.lblScanItem.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblScanItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblScanItem.Location = new System.Drawing.Point(158, 208);
            this.lblScanItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblScanItem.Name = "lblScanItem";
            this.lblScanItem.Size = new System.Drawing.Size(76, 19);
            this.lblScanItem.TabIndex = 2;
            this.lblScanItem.Text = "Scan Item";
            // 
            // btnStow
            // 
            this.btnStow.AutoSize = true;
            this.btnStow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStow.Depth = 0;
            this.btnStow.Icon = null;
            this.btnStow.Location = new System.Drawing.Point(313, 323);
            this.btnStow.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStow.Name = "btnStow";
            this.btnStow.Primary = true;
            this.btnStow.Size = new System.Drawing.Size(59, 36);
            this.btnStow.TabIndex = 3;
            this.btnStow.Text = "Stow";
            this.btnStow.UseVisualStyleBackColor = true;
            this.btnStow.Click += new System.EventHandler(this.btnStow_Click);
            // 
            // txtItemBarcode
            // 
            this.txtItemBarcode.Depth = 0;
            this.txtItemBarcode.Hint = "";
            this.txtItemBarcode.Location = new System.Drawing.Point(294, 204);
            this.txtItemBarcode.MaxLength = 32767;
            this.txtItemBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemBarcode.Name = "txtItemBarcode";
            this.txtItemBarcode.PasswordChar = '\0';
            this.txtItemBarcode.SelectedText = "";
            this.txtItemBarcode.SelectionLength = 0;
            this.txtItemBarcode.SelectionStart = 0;
            this.txtItemBarcode.Size = new System.Drawing.Size(233, 23);
            this.txtItemBarcode.TabIndex = 4;
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
            this.lblItemQuantity.Location = new System.Drawing.Point(136, 263);
            this.lblItemQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(98, 19);
            this.lblItemQuantity.TabIndex = 5;
            this.lblItemQuantity.Text = "Item Quantity";
            // 
            // numItemQuanity
            // 
            this.numItemQuanity.Location = new System.Drawing.Point(294, 262);
            this.numItemQuanity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numItemQuanity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemQuanity.Name = "numItemQuanity";
            this.numItemQuanity.Size = new System.Drawing.Size(120, 20);
            this.numItemQuanity.TabIndex = 6;
            this.numItemQuanity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelReceiveSideline
            // 
            this.panelReceiveSideline.Controls.Add(this.btnCancelSideline);
            this.panelReceiveSideline.Controls.Add(this.btnSideline);
            this.panelReceiveSideline.Controls.Add(this.materialLabel2);
            this.panelReceiveSideline.Controls.Add(this.lblSideline);
            this.panelReceiveSideline.Location = new System.Drawing.Point(79, 105);
            this.panelReceiveSideline.Name = "panelReceiveSideline";
            this.panelReceiveSideline.Size = new System.Drawing.Size(588, 290);
            this.panelReceiveSideline.TabIndex = 7;
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
            this.materialLabel2.Location = new System.Drawing.Point(206, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(159, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Item Barcode not valid";
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
            // StowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReceiveSideline);
            this.Controls.Add(this.numItemQuanity);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.txtItemBarcode);
            this.Controls.Add(this.btnStow);
            this.Controls.Add(this.lblScanItem);
            this.Controls.Add(this.lblScanLocation);
            this.Controls.Add(this.txtLocation);
            this.Name = "StowForm";
            this.Text = "StowForm";
            ((System.ComponentModel.ISupportInitialize)(this.numItemQuanity)).EndInit();
            this.panelReceiveSideline.ResumeLayout(false);
            this.panelReceiveSideline.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocation;
        private MaterialSkin.Controls.MaterialLabel lblScanLocation;
        private MaterialSkin.Controls.MaterialLabel lblScanItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnStow;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemBarcode;
        private MaterialSkin.Controls.MaterialLabel lblItemQuantity;
        private System.Windows.Forms.NumericUpDown numItemQuanity;
        private System.Windows.Forms.Panel panelReceiveSideline;
        private MaterialSkin.Controls.MaterialRaisedButton btnCancelSideline;
        private MaterialSkin.Controls.MaterialRaisedButton btnSideline;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel lblSideline;
    }
}