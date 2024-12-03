namespace PartApp
{
    partial class AddProduct
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
            this.AddProductIDLB = new System.Windows.Forms.Label();
            this.AddPartNameLB = new System.Windows.Forms.Label();
            this.AddProductInvLB = new System.Windows.Forms.Label();
            this.AddProductCostLB = new System.Windows.Forms.Label();
            this.AddProductMaxLB = new System.Windows.Forms.Label();
            this.AddProductMinLB = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssociatedParts = new System.Windows.Forms.DataGridView();
            this.AllCandidatePartsLB = new System.Windows.Forms.Label();
            this.PartsAssociatedLB = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLB
            // 
            this.AddProductLB.AutoSize = true;
            this.AddProductLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLB.Location = new System.Drawing.Point(47, 29);
            this.AddProductLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductLB.Name = "AddProductLB";
            this.AddProductLB.Size = new System.Drawing.Size(129, 21);
            this.AddProductLB.TabIndex = 2;
            this.AddProductLB.Text = "Add Product:";
            // 
            // AddProductIDLB
            // 
            this.AddProductIDLB.AutoSize = true;
            this.AddProductIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductIDLB.Location = new System.Drawing.Point(47, 99);
            this.AddProductIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductIDLB.Name = "AddProductIDLB";
            this.AddProductIDLB.Size = new System.Drawing.Size(35, 21);
            this.AddProductIDLB.TabIndex = 23;
            this.AddProductIDLB.Text = " ID";
            // 
            // AddPartNameLB
            // 
            this.AddPartNameLB.AutoSize = true;
            this.AddPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLB.Location = new System.Drawing.Point(47, 135);
            this.AddPartNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartNameLB.Name = "AddPartNameLB";
            this.AddPartNameLB.Size = new System.Drawing.Size(62, 21);
            this.AddPartNameLB.TabIndex = 24;
            this.AddPartNameLB.Text = "Name";
            // 
            // AddProductInvLB
            // 
            this.AddProductInvLB.AutoSize = true;
            this.AddProductInvLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductInvLB.Location = new System.Drawing.Point(47, 173);
            this.AddProductInvLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductInvLB.Name = "AddProductInvLB";
            this.AddProductInvLB.Size = new System.Drawing.Size(97, 21);
            this.AddProductInvLB.TabIndex = 25;
            this.AddProductInvLB.Text = "Inventory";
            // 
            // AddProductCostLB
            // 
            this.AddProductCostLB.AutoSize = true;
            this.AddProductCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductCostLB.Location = new System.Drawing.Point(47, 214);
            this.AddProductCostLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductCostLB.Name = "AddProductCostLB";
            this.AddProductCostLB.Size = new System.Drawing.Size(101, 21);
            this.AddProductCostLB.TabIndex = 26;
            this.AddProductCostLB.Text = "Price/Cost";
            // 
            // AddProductMaxLB
            // 
            this.AddProductMaxLB.AutoSize = true;
            this.AddProductMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductMaxLB.Location = new System.Drawing.Point(47, 252);
            this.AddProductMaxLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductMaxLB.Name = "AddProductMaxLB";
            this.AddProductMaxLB.Size = new System.Drawing.Size(49, 21);
            this.AddProductMaxLB.TabIndex = 27;
            this.AddProductMaxLB.Text = "Max";
            // 
            // AddProductMinLB
            // 
            this.AddProductMinLB.AutoSize = true;
            this.AddProductMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductMinLB.Location = new System.Drawing.Point(47, 290);
            this.AddProductMinLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddProductMinLB.Name = "AddProductMinLB";
            this.AddProductMinLB.Size = new System.Drawing.Size(45, 21);
            this.AddProductMinLB.TabIndex = 28;
            this.AddProductMinLB.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(155, 287);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(125, 29);
            this.txtMin.TabIndex = 30;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(155, 249);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(125, 29);
            this.txtMax.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(155, 211);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 29);
            this.txtPrice.TabIndex = 32;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(155, 170);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(125, 29);
            this.txtInventory.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(155, 131);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 29);
            this.txtName.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(155, 96);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(125, 29);
            this.txtID.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(51, 358);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 27);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(207, 358);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 27);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(509, 422);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(72, 27);
            this.BtnDelete.TabIndex = 38;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(509, 217);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 27);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(335, 51);
            this.dgvAllParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.RowHeadersWidth = 62;
            this.dgvAllParts.RowTemplate.Height = 28;
            this.dgvAllParts.Size = new System.Drawing.Size(375, 162);
            this.dgvAllParts.TabIndex = 40;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(335, 252);
            this.dgvAssociatedParts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 62;
            this.dgvAssociatedParts.RowTemplate.Height = 28;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(375, 166);
            this.dgvAssociatedParts.TabIndex = 41;
            // 
            // AllCandidatePartsLB
            // 
            this.AllCandidatePartsLB.AutoSize = true;
            this.AllCandidatePartsLB.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCandidatePartsLB.Location = new System.Drawing.Point(331, 20);
            this.AllCandidatePartsLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllCandidatePartsLB.Name = "AllCandidatePartsLB";
            this.AllCandidatePartsLB.Size = new System.Drawing.Size(142, 19);
            this.AllCandidatePartsLB.TabIndex = 42;
            this.AllCandidatePartsLB.Text = "All Candidate Parts";
            // 
            // PartsAssociatedLB
            // 
            this.PartsAssociatedLB.AutoSize = true;
            this.PartsAssociatedLB.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsAssociatedLB.Location = new System.Drawing.Point(331, 227);
            this.PartsAssociatedLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PartsAssociatedLB.Name = "PartsAssociatedLB";
            this.PartsAssociatedLB.Size = new System.Drawing.Size(125, 19);
            this.PartsAssociatedLB.TabIndex = 43;
            this.PartsAssociatedLB.Text = "Associated Parts";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(723, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 27);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(488, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(223, 29);
            this.txtSearch.TabIndex = 50;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 464);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.PartsAssociatedLB);
            this.Controls.Add(this.AllCandidatePartsLB);
            this.Controls.Add(this.dgvAssociatedParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.AddProductMinLB);
            this.Controls.Add(this.AddProductMaxLB);
            this.Controls.Add(this.AddProductCostLB);
            this.Controls.Add(this.AddProductInvLB);
            this.Controls.Add(this.AddPartNameLB);
            this.Controls.Add(this.AddProductIDLB);
            this.Controls.Add(this.AddProductLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLB;
        private System.Windows.Forms.Label AddProductIDLB;
        private System.Windows.Forms.Label AddPartNameLB;
        private System.Windows.Forms.Label AddProductInvLB;
        private System.Windows.Forms.Label AddProductCostLB;
        private System.Windows.Forms.Label AddProductMaxLB;
        private System.Windows.Forms.Label AddProductMinLB;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssociatedParts;
        private System.Windows.Forms.Label AllCandidatePartsLB;
        private System.Windows.Forms.Label PartsAssociatedLB;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}