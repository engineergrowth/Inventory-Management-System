namespace PartApp
{
    partial class ModifyPart
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
            this.ModPartLB = new System.Windows.Forms.Label();
            this.ModPartIDLB = new System.Windows.Forms.Label();
            this.ModPartNameLB = new System.Windows.Forms.Label();
            this.ModPartInventoryLB = new System.Windows.Forms.Label();
            this.ModPartCostLB = new System.Windows.Forms.Label();
            this.ModPartMaxLB = new System.Windows.Forms.Label();
            this.AddPartMinLB = new System.Windows.Forms.Label();
            this.labelMachineID = new System.Windows.Forms.Label();
            this.AddPartSaveBT = new System.Windows.Forms.Button();
            this.AddPartCancelBT = new System.Windows.Forms.Button();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtPartId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ModPartLB
            // 
            this.ModPartLB.AutoSize = true;
            this.ModPartLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartLB.Location = new System.Drawing.Point(27, 20);
            this.ModPartLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartLB.Name = "ModPartLB";
            this.ModPartLB.Size = new System.Drawing.Size(121, 21);
            this.ModPartLB.TabIndex = 2;
            this.ModPartLB.Text = "Modify Part:";
            // 
            // ModPartIDLB
            // 
            this.ModPartIDLB.AutoSize = true;
            this.ModPartIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartIDLB.Location = new System.Drawing.Point(27, 57);
            this.ModPartIDLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartIDLB.Name = "ModPartIDLB";
            this.ModPartIDLB.Size = new System.Drawing.Size(35, 21);
            this.ModPartIDLB.TabIndex = 23;
            this.ModPartIDLB.Text = " ID";
            // 
            // ModPartNameLB
            // 
            this.ModPartNameLB.AutoSize = true;
            this.ModPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartNameLB.Location = new System.Drawing.Point(27, 95);
            this.ModPartNameLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartNameLB.Name = "ModPartNameLB";
            this.ModPartNameLB.Size = new System.Drawing.Size(62, 21);
            this.ModPartNameLB.TabIndex = 24;
            this.ModPartNameLB.Text = "Name";
            // 
            // ModPartInventoryLB
            // 
            this.ModPartInventoryLB.AutoSize = true;
            this.ModPartInventoryLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartInventoryLB.Location = new System.Drawing.Point(27, 137);
            this.ModPartInventoryLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartInventoryLB.Name = "ModPartInventoryLB";
            this.ModPartInventoryLB.Size = new System.Drawing.Size(97, 21);
            this.ModPartInventoryLB.TabIndex = 25;
            this.ModPartInventoryLB.Text = "Inventory";
            // 
            // ModPartCostLB
            // 
            this.ModPartCostLB.AutoSize = true;
            this.ModPartCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartCostLB.Location = new System.Drawing.Point(27, 183);
            this.ModPartCostLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartCostLB.Name = "ModPartCostLB";
            this.ModPartCostLB.Size = new System.Drawing.Size(101, 21);
            this.ModPartCostLB.TabIndex = 26;
            this.ModPartCostLB.Text = "Price/Cost";
            // 
            // ModPartMaxLB
            // 
            this.ModPartMaxLB.AutoSize = true;
            this.ModPartMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartMaxLB.Location = new System.Drawing.Point(27, 227);
            this.ModPartMaxLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModPartMaxLB.Name = "ModPartMaxLB";
            this.ModPartMaxLB.Size = new System.Drawing.Size(49, 21);
            this.ModPartMaxLB.TabIndex = 27;
            this.ModPartMaxLB.Text = "Max";
            // 
            // AddPartMinLB
            // 
            this.AddPartMinLB.AutoSize = true;
            this.AddPartMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLB.Location = new System.Drawing.Point(286, 227);
            this.AddPartMinLB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPartMinLB.Name = "AddPartMinLB";
            this.AddPartMinLB.Size = new System.Drawing.Size(45, 21);
            this.AddPartMinLB.TabIndex = 28;
            this.AddPartMinLB.Text = "Min";
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineID.Location = new System.Drawing.Point(27, 276);
            this.labelMachineID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(110, 21);
            this.labelMachineID.TabIndex = 29;
            this.labelMachineID.Text = "Machine ID";
            // 
            // AddPartSaveBT
            // 
            this.AddPartSaveBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartSaveBT.Location = new System.Drawing.Point(74, 341);
            this.AddPartSaveBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPartSaveBT.Name = "AddPartSaveBT";
            this.AddPartSaveBT.Size = new System.Drawing.Size(72, 27);
            this.AddPartSaveBT.TabIndex = 30;
            this.AddPartSaveBT.Text = "Save ";
            this.AddPartSaveBT.UseVisualStyleBackColor = true;
            this.AddPartSaveBT.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddPartCancelBT
            // 
            this.AddPartCancelBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartCancelBT.Location = new System.Drawing.Point(314, 341);
            this.AddPartCancelBT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddPartCancelBT.Name = "AddPartCancelBT";
            this.AddPartCancelBT.Size = new System.Drawing.Size(72, 27);
            this.AddPartCancelBT.TabIndex = 31;
            this.AddPartCancelBT.Text = "Cancel";
            this.AddPartCancelBT.UseVisualStyleBackColor = true;
            this.AddPartCancelBT.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(150, 134);
            this.txtInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(125, 29);
            this.txtInventory.TabIndex = 32;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(150, 180);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(125, 29);
            this.txtPrice.TabIndex = 33;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(150, 224);
            this.txtMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(125, 29);
            this.txtMax.TabIndex = 34;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineID.Location = new System.Drawing.Point(150, 273);
            this.txtMachineID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(125, 29);
            this.txtMachineID.TabIndex = 35;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(347, 227);
            this.txtMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(125, 29);
            this.txtMin.TabIndex = 36;
            // 
            // txtPartId
            // 
            this.txtPartId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPartId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartId.Location = new System.Drawing.Point(150, 57);
            this.txtPartId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.ReadOnly = true;
            this.txtPartId.Size = new System.Drawing.Size(245, 29);
            this.txtPartId.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(150, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 29);
            this.txtName.TabIndex = 38;
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInHouse.Location = new System.Drawing.Point(194, 18);
            this.radioInHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(105, 26);
            this.radioInHouse.TabIndex = 39;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioInHouse.UseVisualStyleBackColor = true;
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOutsourced.Location = new System.Drawing.Point(314, 20);
            this.radioOutsourced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(126, 26);
            this.radioOutsourced.TabIndex = 40;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(29, 276);
            this.labelCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(95, 21);
            this.labelCompanyName.TabIndex = 41;
            this.labelCompanyName.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(150, 274);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(125, 29);
            this.txtCompanyName.TabIndex = 42;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 392);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPartId);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.AddPartCancelBT);
            this.Controls.Add(this.AddPartSaveBT);
            this.Controls.Add(this.labelMachineID);
            this.Controls.Add(this.AddPartMinLB);
            this.Controls.Add(this.ModPartMaxLB);
            this.Controls.Add(this.ModPartCostLB);
            this.Controls.Add(this.ModPartInventoryLB);
            this.Controls.Add(this.ModPartNameLB);
            this.Controls.Add(this.ModPartIDLB);
            this.Controls.Add(this.ModPartLB);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ModPartLB;
        private System.Windows.Forms.Label ModPartIDLB;
        private System.Windows.Forms.Label ModPartNameLB;
        private System.Windows.Forms.Label ModPartInventoryLB;
        private System.Windows.Forms.Label ModPartCostLB;
        private System.Windows.Forms.Label ModPartMaxLB;
        private System.Windows.Forms.Label AddPartMinLB;
        private System.Windows.Forms.Label labelMachineID;
        private System.Windows.Forms.Button AddPartSaveBT;
        private System.Windows.Forms.Button AddPartCancelBT;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtPartId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
    }
}