namespace WarehouseApp
{
    partial class ShipForm
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
            this.btnDispatchItem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtItemBarcode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFinishShipping = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // btnDispatchItem
            // 
            this.btnDispatchItem.AutoSize = true;
            this.btnDispatchItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDispatchItem.Depth = 0;
            this.btnDispatchItem.Icon = null;
            this.btnDispatchItem.Location = new System.Drawing.Point(562, 166);
            this.btnDispatchItem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDispatchItem.Name = "btnDispatchItem";
            this.btnDispatchItem.Primary = true;
            this.btnDispatchItem.Size = new System.Drawing.Size(122, 36);
            this.btnDispatchItem.TabIndex = 14;
            this.btnDispatchItem.Text = "Dispatch Item";
            this.btnDispatchItem.UseVisualStyleBackColor = true;
            this.btnDispatchItem.Click += new System.EventHandler(this.btnDispatchItem_Click);
            // 
            // txtItemBarcode
            // 
            this.txtItemBarcode.Depth = 0;
            this.txtItemBarcode.Hint = "";
            this.txtItemBarcode.Location = new System.Drawing.Point(273, 170);
            this.txtItemBarcode.MaxLength = 32767;
            this.txtItemBarcode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtItemBarcode.Name = "txtItemBarcode";
            this.txtItemBarcode.PasswordChar = '\0';
            this.txtItemBarcode.SelectedText = "";
            this.txtItemBarcode.SelectionLength = 0;
            this.txtItemBarcode.SelectionStart = 0;
            this.txtItemBarcode.Size = new System.Drawing.Size(264, 23);
            this.txtItemBarcode.TabIndex = 13;
            this.txtItemBarcode.TabStop = false;
            this.txtItemBarcode.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(96, 174);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(134, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Scan Item barcode";
            // 
            // btnFinishShipping
            // 
            this.btnFinishShipping.AutoSize = true;
            this.btnFinishShipping.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinishShipping.Depth = 0;
            this.btnFinishShipping.Icon = null;
            this.btnFinishShipping.Location = new System.Drawing.Point(345, 338);
            this.btnFinishShipping.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinishShipping.Name = "btnFinishShipping";
            this.btnFinishShipping.Primary = true;
            this.btnFinishShipping.Size = new System.Drawing.Size(121, 36);
            this.btnFinishShipping.TabIndex = 15;
            this.btnFinishShipping.Text = "Finish Picking";
            this.btnFinishShipping.UseVisualStyleBackColor = true;
            this.btnFinishShipping.Click += new System.EventHandler(this.btnFinishShipping_Click);
            // 
            // ShipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinishShipping);
            this.Controls.Add(this.btnDispatchItem);
            this.Controls.Add(this.txtItemBarcode);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ShipForm";
            this.Text = "ShipForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnDispatchItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtItemBarcode;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnFinishShipping;
    }
}