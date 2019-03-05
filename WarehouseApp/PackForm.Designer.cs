namespace WarehouseApp
{
    partial class PackForm
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
            this.btnScanItem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnFinishPack = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(180, 128);
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
            this.txtItemBarcode.Location = new System.Drawing.Point(292, 124);
            this.txtItemBarcode.MaxLength = 32767;
            this.txtItemBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemBarcode.Name = "txtItemBarcode";
            this.txtItemBarcode.PasswordChar = '\0';
            this.txtItemBarcode.SelectedText = "";
            this.txtItemBarcode.SelectionLength = 0;
            this.txtItemBarcode.SelectionStart = 0;
            this.txtItemBarcode.Size = new System.Drawing.Size(251, 23);
            this.txtItemBarcode.TabIndex = 1;
            this.txtItemBarcode.TabStop = false;
            this.txtItemBarcode.UseSystemPasswordChar = false;
            // 
            // btnScanItem
            // 
            this.btnScanItem.AutoSize = true;
            this.btnScanItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScanItem.Depth = 0;
            this.btnScanItem.Icon = null;
            this.btnScanItem.Location = new System.Drawing.Point(566, 120);
            this.btnScanItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanItem.Name = "btnScanItem";
            this.btnScanItem.Primary = true;
            this.btnScanItem.Size = new System.Drawing.Size(57, 36);
            this.btnScanItem.TabIndex = 2;
            this.btnScanItem.Text = "Scan";
            this.btnScanItem.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(310, 225);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(170, 36);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "Print Shipping Label";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // btnFinishPack
            // 
            this.btnFinishPack.AutoSize = true;
            this.btnFinishPack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishPack.Depth = 0;
            this.btnFinishPack.Icon = null;
            this.btnFinishPack.Location = new System.Drawing.Point(587, 345);
            this.btnFinishPack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishPack.Name = "btnFinishPack";
            this.btnFinishPack.Primary = true;
            this.btnFinishPack.Size = new System.Drawing.Size(126, 36);
            this.btnFinishPack.TabIndex = 10;
            this.btnFinishPack.Text = "Finish Packing";
            this.btnFinishPack.UseVisualStyleBackColor = true;
            this.btnFinishPack.Click += new System.EventHandler(this.btnFinishPack_Click);
            // 
            // PackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinishPack);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.btnScanItem);
            this.Controls.Add(this.txtItemBarcode);
            this.Controls.Add(this.materialLabel1);
            this.Name = "PackForm";
            this.Text = "PackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemBarcode;
        private MaterialSkin.Controls.MaterialRaisedButton btnScanItem;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinishPack;
    }
}