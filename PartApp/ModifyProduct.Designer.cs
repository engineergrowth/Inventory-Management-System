namespace PartApp
{
    partial class ModifyProduct
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
            this.AddProductLB = new System.Windows.Forms.Label();
            this.ModifyProductIDLB = new System.Windows.Forms.Label();
            this.ModifyPartNameLB = new System.Windows.Forms.Label();
            this.ModifyProductInvLB = new System.Windows.Forms.Label();
            this.ModifyProductCostLB = new System.Windows.Forms.Label();
            this.ModifyProductMaxLB = new System.Windows.Forms.Label();
            this.ModifyProductMinLB = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.ModifyProductSaveBT = new System.Windows.Forms.Button();
            this.ModifyProductCancelBT = new System.Windows.Forms.Button();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.btnDeletePart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLB
            // 
            this.AddProductLB.AutoSize = true;
            this.AddProductLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLB.Location = new System.Drawing.Point(71, 42);
            this.AddProductLB.Name = "AddProductLB";
            this.AddProductLB.Size = new System.Drawing.Size(229, 34);
            this.AddProductLB.TabIndex = 3;
            this.AddProductLB.Text = "Modify Product:";
            // 
            // ModifyProductIDLB
            // 
            this.ModifyProductIDLB.AutoSize = true;
            this.ModifyProductIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductIDLB.Location = new System.Drawing.Point(71, 125);
            this.ModifyProductIDLB.Name = "ModifyProductIDLB";
            this.ModifyProductIDLB.Size = new System.Drawing.Size(53, 34);
            this.ModifyProductIDLB.TabIndex = 24;
            this.ModifyProductIDLB.Text = " ID";
            // 
            // ModifyPartNameLB
            // 
            this.ModifyPartNameLB.AutoSize = true;
            this.ModifyPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartNameLB.Location = new System.Drawing.Point(71, 183);
            this.ModifyPartNameLB.Name = "ModifyPartNameLB";
            this.ModifyPartNameLB.Size = new System.Drawing.Size(93, 34);
            this.ModifyPartNameLB.TabIndex = 25;
            this.ModifyPartNameLB.Text = "Name";
            // 
            // ModifyProductInvLB
            // 
            this.ModifyProductInvLB.AutoSize = true;
            this.ModifyProductInvLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductInvLB.Location = new System.Drawing.Point(71, 239);
            this.ModifyProductInvLB.Name = "ModifyProductInvLB";
            this.ModifyProductInvLB.Size = new System.Drawing.Size(142, 34);
            this.ModifyProductInvLB.TabIndex = 26;
            this.ModifyProductInvLB.Text = "Inventory";
            // 
            // ModifyProductCostLB
            // 
            this.ModifyProductCostLB.AutoSize = true;
            this.ModifyProductCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductCostLB.Location = new System.Drawing.Point(71, 295);
            this.ModifyProductCostLB.Name = "ModifyProductCostLB";
            this.ModifyProductCostLB.Size = new System.Drawing.Size(148, 34);
            this.ModifyProductCostLB.TabIndex = 27;
            this.ModifyProductCostLB.Text = "Price/Cost";
            // 
            // ModifyProductMaxLB
            // 
            this.ModifyProductMaxLB.AutoSize = true;
            this.ModifyProductMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMaxLB.Location = new System.Drawing.Point(71, 354);
            this.ModifyProductMaxLB.Name = "ModifyProductMaxLB";
            this.ModifyProductMaxLB.Size = new System.Drawing.Size(72, 34);
            this.ModifyProductMaxLB.TabIndex = 28;
            this.ModifyProductMaxLB.Text = "Max";
            // 
            // ModifyProductMinLB
            // 
            this.ModifyProductMinLB.AutoSize = true;
            this.ModifyProductMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMinLB.Location = new System.Drawing.Point(71, 414);
            this.ModifyProductMinLB.Name = "ModifyProductMinLB";
            this.ModifyProductMinLB.Size = new System.Drawing.Size(67, 34);
            this.ModifyProductMinLB.TabIndex = 29;
            this.ModifyProductMinLB.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(279, 414);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(186, 39);
            this.txtMin.TabIndex = 37;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(281, 356);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(186, 39);
            this.txtMax.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(279, 297);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 39);
            this.txtPrice.TabIndex = 39;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(279, 241);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(186, 39);
            this.txtInventory.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(279, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 39);
            this.txtName.TabIndex = 41;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProductId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(279, 127);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(186, 39);
            this.txtProductId.TabIndex = 42;
            // 
            // ModifyProductSaveBT
            // 
            this.ModifyProductSaveBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductSaveBT.Location = new System.Drawing.Point(77, 517);
            this.ModifyProductSaveBT.Name = "ModifyProductSaveBT";
            this.ModifyProductSaveBT.Size = new System.Drawing.Size(108, 42);
            this.ModifyProductSaveBT.TabIndex = 43;
            this.ModifyProductSaveBT.Text = "Save ";
            this.ModifyProductSaveBT.UseVisualStyleBackColor = true;
            this.ModifyProductSaveBT.Click += new System.EventHandler(this.ModifyProductSaveBT_Click);
            // 
            // ModifyProductCancelBT
            // 
            this.ModifyProductCancelBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductCancelBT.Location = new System.Drawing.Point(357, 517);
            this.ModifyProductCancelBT.Name = "ModifyProductCancelBT";
            this.ModifyProductCancelBT.Size = new System.Drawing.Size(108, 42);
            this.ModifyProductCancelBT.TabIndex = 44;
            this.ModifyProductCancelBT.Text = "Cancel";
            this.ModifyProductCancelBT.UseVisualStyleBackColor = true;
            this.ModifyProductCancelBT.Click += new System.EventHandler(this.ModifyProductCancelBT_Click);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(523, 24);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.RowHeadersWidth = 62;
            this.dgvAllParts.RowTemplate.Height = 28;
            this.dgvAllParts.Size = new System.Drawing.Size(563, 249);
            this.dgvAllParts.TabIndex = 45;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(756, 294);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(108, 42);
            this.btnAddPart.TabIndex = 46;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(523, 356);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 62;
            this.dgvAssociatedParts.RowTemplate.Height = 28;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(563, 256);
            this.dgvAssociatedParts.TabIndex = 47;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.Location = new System.Drawing.Point(756, 629);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(108, 42);
            this.btnDeletePart.TabIndex = 48;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1116, 696);
            this.Controls.Add(this.btnDeletePart);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.ModifyProductCancelBT);
            this.Controls.Add(this.ModifyProductSaveBT);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.ModifyProductMinLB);
            this.Controls.Add(this.ModifyProductMaxLB);
            this.Controls.Add(this.ModifyProductCostLB);
            this.Controls.Add(this.ModifyProductInvLB);
            this.Controls.Add(this.ModifyPartNameLB);
            this.Controls.Add(this.ModifyProductIDLB);
            this.Controls.Add(this.AddProductLB);
            this.Name = "ModifyProduct";
            this.Text = "Modfy Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLB;
        private System.Windows.Forms.Label ModifyProductIDLB;
        private System.Windows.Forms.Label ModifyPartNameLB;
        private System.Windows.Forms.Label ModifyProductInvLB;
        private System.Windows.Forms.Label ModifyProductCostLB;
        private System.Windows.Forms.Label ModifyProductMaxLB;
        private System.Windows.Forms.Label ModifyProductMinLB;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Button ModifyProductSaveBT;
        private System.Windows.Forms.Button ModifyProductCancelBT;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Button btnDeletePart;
    }
}