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
            this.PartsAssociatedLB = new System.Windows.Forms.Label();
            this.AllCandidatePartsLB = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLB
            // 
            this.AddProductLB.AutoSize = true;
            this.AddProductLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLB.Location = new System.Drawing.Point(47, 27);
            this.AddProductLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductLB.Name = "AddProductLB";
            this.AddProductLB.Size = new System.Drawing.Size(156, 21);
            this.AddProductLB.TabIndex = 3;
            this.AddProductLB.Text = "Modify Product:";
            // 
            // ModifyProductIDLB
            // 
            this.ModifyProductIDLB.AutoSize = true;
            this.ModifyProductIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductIDLB.Location = new System.Drawing.Point(47, 81);
            this.ModifyProductIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductIDLB.Name = "ModifyProductIDLB";
            this.ModifyProductIDLB.Size = new System.Drawing.Size(35, 21);
            this.ModifyProductIDLB.TabIndex = 24;
            this.ModifyProductIDLB.Text = " ID";
            // 
            // ModifyPartNameLB
            // 
            this.ModifyPartNameLB.AutoSize = true;
            this.ModifyPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartNameLB.Location = new System.Drawing.Point(47, 119);
            this.ModifyPartNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyPartNameLB.Name = "ModifyPartNameLB";
            this.ModifyPartNameLB.Size = new System.Drawing.Size(62, 21);
            this.ModifyPartNameLB.TabIndex = 25;
            this.ModifyPartNameLB.Text = "Name";
            // 
            // ModifyProductInvLB
            // 
            this.ModifyProductInvLB.AutoSize = true;
            this.ModifyProductInvLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductInvLB.Location = new System.Drawing.Point(47, 155);
            this.ModifyProductInvLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductInvLB.Name = "ModifyProductInvLB";
            this.ModifyProductInvLB.Size = new System.Drawing.Size(97, 21);
            this.ModifyProductInvLB.TabIndex = 26;
            this.ModifyProductInvLB.Text = "Inventory";
            // 
            // ModifyProductCostLB
            // 
            this.ModifyProductCostLB.AutoSize = true;
            this.ModifyProductCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductCostLB.Location = new System.Drawing.Point(47, 192);
            this.ModifyProductCostLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductCostLB.Name = "ModifyProductCostLB";
            this.ModifyProductCostLB.Size = new System.Drawing.Size(101, 21);
            this.ModifyProductCostLB.TabIndex = 27;
            this.ModifyProductCostLB.Text = "Price/Cost";
            // 
            // ModifyProductMaxLB
            // 
            this.ModifyProductMaxLB.AutoSize = true;
            this.ModifyProductMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMaxLB.Location = new System.Drawing.Point(47, 230);
            this.ModifyProductMaxLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductMaxLB.Name = "ModifyProductMaxLB";
            this.ModifyProductMaxLB.Size = new System.Drawing.Size(49, 21);
            this.ModifyProductMaxLB.TabIndex = 28;
            this.ModifyProductMaxLB.Text = "Max";
            // 
            // ModifyProductMinLB
            // 
            this.ModifyProductMinLB.AutoSize = true;
            this.ModifyProductMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductMinLB.Location = new System.Drawing.Point(47, 269);
            this.ModifyProductMinLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifyProductMinLB.Name = "ModifyProductMinLB";
            this.ModifyProductMinLB.Size = new System.Drawing.Size(45, 21);
            this.ModifyProductMinLB.TabIndex = 29;
            this.ModifyProductMinLB.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(186, 269);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(125, 29);
            this.txtMin.TabIndex = 37;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(187, 231);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(125, 29);
            this.txtMax.TabIndex = 38;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(186, 193);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 29);
            this.txtPrice.TabIndex = 39;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(186, 157);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(125, 29);
            this.txtInventory.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(186, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 29);
            this.txtName.TabIndex = 41;
            // 
            // txtProductId
            // 
            this.txtProductId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtProductId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(186, 83);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.ReadOnly = true;
            this.txtProductId.Size = new System.Drawing.Size(125, 29);
            this.txtProductId.TabIndex = 42;
            // 
            // ModifyProductSaveBT
            // 
            this.ModifyProductSaveBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductSaveBT.Location = new System.Drawing.Point(51, 336);
            this.ModifyProductSaveBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyProductSaveBT.Name = "ModifyProductSaveBT";
            this.ModifyProductSaveBT.Size = new System.Drawing.Size(72, 27);
            this.ModifyProductSaveBT.TabIndex = 43;
            this.ModifyProductSaveBT.Text = "Save ";
            this.ModifyProductSaveBT.UseVisualStyleBackColor = true;
            this.ModifyProductSaveBT.Click += new System.EventHandler(this.ModifyProductSaveBT_Click);
            // 
            // ModifyProductCancelBT
            // 
            this.ModifyProductCancelBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductCancelBT.Location = new System.Drawing.Point(238, 336);
            this.ModifyProductCancelBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModifyProductCancelBT.Name = "ModifyProductCancelBT";
            this.ModifyProductCancelBT.Size = new System.Drawing.Size(72, 27);
            this.ModifyProductCancelBT.TabIndex = 44;
            this.ModifyProductCancelBT.Text = "Cancel";
            this.ModifyProductCancelBT.UseVisualStyleBackColor = true;
            this.ModifyProductCancelBT.Click += new System.EventHandler(this.ModifyProductCancelBT_Click);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(349, 45);
            this.dgvAllParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.RowHeadersWidth = 62;
            this.dgvAllParts.RowTemplate.Height = 28;
            this.dgvAllParts.Size = new System.Drawing.Size(375, 162);
            this.dgvAllParts.TabIndex = 45;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.Location = new System.Drawing.Point(502, 211);
            this.btnAddPart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(72, 27);
            this.btnAddPart.TabIndex = 46;
            this.btnAddPart.Text = "Add";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(349, 253);
            this.dgvAssociatedParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 62;
            this.dgvAssociatedParts.RowTemplate.Height = 28;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(375, 166);
            this.dgvAssociatedParts.TabIndex = 47;
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.Location = new System.Drawing.Point(504, 424);
            this.btnDeletePart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(72, 27);
            this.btnDeletePart.TabIndex = 48;
            this.btnDeletePart.Text = "Delete";
            this.btnDeletePart.UseVisualStyleBackColor = true;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // PartsAssociatedLB
            // 
            this.PartsAssociatedLB.AutoSize = true;
            this.PartsAssociatedLB.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsAssociatedLB.Location = new System.Drawing.Point(353, 231);
            this.PartsAssociatedLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsAssociatedLB.Name = "PartsAssociatedLB";
            this.PartsAssociatedLB.Size = new System.Drawing.Size(125, 19);
            this.PartsAssociatedLB.TabIndex = 49;
            this.PartsAssociatedLB.Text = "Associated Parts";
            // 
            // AllCandidatePartsLB
            // 
            this.AllCandidatePartsLB.AutoSize = true;
            this.AllCandidatePartsLB.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCandidatePartsLB.Location = new System.Drawing.Point(345, 18);
            this.AllCandidatePartsLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllCandidatePartsLB.Name = "AllCandidatePartsLB";
            this.AllCandidatePartsLB.Size = new System.Drawing.Size(142, 19);
            this.AllCandidatePartsLB.TabIndex = 50;
            this.AllCandidatePartsLB.Text = "All Candidate Parts";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(502, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 29);
            this.txtSearch.TabIndex = 51;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(741, 8);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 27);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 457);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.AllCandidatePartsLB);
            this.Controls.Add(this.PartsAssociatedLB);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label PartsAssociatedLB;
        private System.Windows.Forms.Label AllCandidatePartsLB;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}