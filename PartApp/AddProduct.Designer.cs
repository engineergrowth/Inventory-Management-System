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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssociatedParts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLB
            // 
            this.AddProductLB.AutoSize = true;
            this.AddProductLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLB.Location = new System.Drawing.Point(71, 45);
            this.AddProductLB.Name = "AddProductLB";
            this.AddProductLB.Size = new System.Drawing.Size(188, 34);
            this.AddProductLB.TabIndex = 2;
            this.AddProductLB.Text = "Add Product:";
            // 
            // AddProductIDLB
            // 
            this.AddProductIDLB.AutoSize = true;
            this.AddProductIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductIDLB.Location = new System.Drawing.Point(71, 152);
            this.AddProductIDLB.Name = "AddProductIDLB";
            this.AddProductIDLB.Size = new System.Drawing.Size(53, 34);
            this.AddProductIDLB.TabIndex = 23;
            this.AddProductIDLB.Text = " ID";
            // 
            // AddPartNameLB
            // 
            this.AddPartNameLB.AutoSize = true;
            this.AddPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLB.Location = new System.Drawing.Point(71, 207);
            this.AddPartNameLB.Name = "AddPartNameLB";
            this.AddPartNameLB.Size = new System.Drawing.Size(93, 34);
            this.AddPartNameLB.TabIndex = 24;
            this.AddPartNameLB.Text = "Name";
            // 
            // AddProductInvLB
            // 
            this.AddProductInvLB.AutoSize = true;
            this.AddProductInvLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductInvLB.Location = new System.Drawing.Point(71, 266);
            this.AddProductInvLB.Name = "AddProductInvLB";
            this.AddProductInvLB.Size = new System.Drawing.Size(142, 34);
            this.AddProductInvLB.TabIndex = 25;
            this.AddProductInvLB.Text = "Inventory";
            // 
            // AddProductCostLB
            // 
            this.AddProductCostLB.AutoSize = true;
            this.AddProductCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductCostLB.Location = new System.Drawing.Point(71, 329);
            this.AddProductCostLB.Name = "AddProductCostLB";
            this.AddProductCostLB.Size = new System.Drawing.Size(148, 34);
            this.AddProductCostLB.TabIndex = 26;
            this.AddProductCostLB.Text = "Price/Cost";
            // 
            // AddProductMaxLB
            // 
            this.AddProductMaxLB.AutoSize = true;
            this.AddProductMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductMaxLB.Location = new System.Drawing.Point(71, 388);
            this.AddProductMaxLB.Name = "AddProductMaxLB";
            this.AddProductMaxLB.Size = new System.Drawing.Size(72, 34);
            this.AddProductMaxLB.TabIndex = 27;
            this.AddProductMaxLB.Text = "Max";
            // 
            // AddProductMinLB
            // 
            this.AddProductMinLB.AutoSize = true;
            this.AddProductMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductMinLB.Location = new System.Drawing.Point(71, 446);
            this.AddProductMinLB.Name = "AddProductMinLB";
            this.AddProductMinLB.Size = new System.Drawing.Size(67, 34);
            this.AddProductMinLB.TabIndex = 28;
            this.AddProductMinLB.Text = "Min";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(232, 441);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(186, 39);
            this.txtMin.TabIndex = 30;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(232, 383);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(186, 39);
            this.txtMax.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(232, 324);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 39);
            this.txtPrice.TabIndex = 32;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(232, 261);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(186, 39);
            this.txtInventory.TabIndex = 33;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(232, 202);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 39);
            this.txtName.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(232, 147);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(186, 39);
            this.txtID.TabIndex = 35;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(77, 551);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(744, 627);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(108, 42);
            this.BtnDelete.TabIndex = 38;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(744, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 42);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(502, 23);
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.RowHeadersWidth = 62;
            this.dgvAllParts.RowTemplate.Height = 28;
            this.dgvAllParts.Size = new System.Drawing.Size(563, 249);
            this.dgvAllParts.TabIndex = 40;
            // 
            // dgvAssociatedParts
            // 
            this.dgvAssociatedParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssociatedParts.Location = new System.Drawing.Point(502, 354);
            this.dgvAssociatedParts.Name = "dgvAssociatedParts";
            this.dgvAssociatedParts.RowHeadersWidth = 62;
            this.dgvAssociatedParts.RowTemplate.Height = 28;
            this.dgvAssociatedParts.Size = new System.Drawing.Size(563, 256);
            this.dgvAssociatedParts.TabIndex = 41;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1119, 698);
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
    }
}