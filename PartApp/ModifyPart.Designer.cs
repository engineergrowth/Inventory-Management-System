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
            this.ModPartLB.Location = new System.Drawing.Point(40, 31);
            this.ModPartLB.Name = "ModPartLB";
            this.ModPartLB.Size = new System.Drawing.Size(180, 34);
            this.ModPartLB.TabIndex = 2;
            this.ModPartLB.Text = "Modify Part:";
            // 
            // ModPartIDLB
            // 
            this.ModPartIDLB.AutoSize = true;
            this.ModPartIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartIDLB.Location = new System.Drawing.Point(40, 87);
            this.ModPartIDLB.Name = "ModPartIDLB";
            this.ModPartIDLB.Size = new System.Drawing.Size(53, 34);
            this.ModPartIDLB.TabIndex = 23;
            this.ModPartIDLB.Text = " ID";
            // 
            // ModPartNameLB
            // 
            this.ModPartNameLB.AutoSize = true;
            this.ModPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartNameLB.Location = new System.Drawing.Point(40, 146);
            this.ModPartNameLB.Name = "ModPartNameLB";
            this.ModPartNameLB.Size = new System.Drawing.Size(93, 34);
            this.ModPartNameLB.TabIndex = 24;
            this.ModPartNameLB.Text = "Name";
            // 
            // ModPartInventoryLB
            // 
            this.ModPartInventoryLB.AutoSize = true;
            this.ModPartInventoryLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartInventoryLB.Location = new System.Drawing.Point(40, 211);
            this.ModPartInventoryLB.Name = "ModPartInventoryLB";
            this.ModPartInventoryLB.Size = new System.Drawing.Size(142, 34);
            this.ModPartInventoryLB.TabIndex = 25;
            this.ModPartInventoryLB.Text = "Inventory";
            // 
            // ModPartCostLB
            // 
            this.ModPartCostLB.AutoSize = true;
            this.ModPartCostLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartCostLB.Location = new System.Drawing.Point(40, 282);
            this.ModPartCostLB.Name = "ModPartCostLB";
            this.ModPartCostLB.Size = new System.Drawing.Size(148, 34);
            this.ModPartCostLB.TabIndex = 26;
            this.ModPartCostLB.Text = "Price/Cost";
            // 
            // ModPartMaxLB
            // 
            this.ModPartMaxLB.AutoSize = true;
            this.ModPartMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModPartMaxLB.Location = new System.Drawing.Point(40, 350);
            this.ModPartMaxLB.Name = "ModPartMaxLB";
            this.ModPartMaxLB.Size = new System.Drawing.Size(72, 34);
            this.ModPartMaxLB.TabIndex = 27;
            this.ModPartMaxLB.Text = "Max";
            // 
            // AddPartMinLB
            // 
            this.AddPartMinLB.AutoSize = true;
            this.AddPartMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLB.Location = new System.Drawing.Point(429, 350);
            this.AddPartMinLB.Name = "AddPartMinLB";
            this.AddPartMinLB.Size = new System.Drawing.Size(67, 34);
            this.AddPartMinLB.TabIndex = 28;
            this.AddPartMinLB.Text = "Min";
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineID.Location = new System.Drawing.Point(40, 425);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(165, 34);
            this.labelMachineID.TabIndex = 29;
            this.labelMachineID.Text = "Machine ID";
            // 
            // AddPartSaveBT
            // 
            this.AddPartSaveBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartSaveBT.Location = new System.Drawing.Point(111, 524);
            this.AddPartSaveBT.Name = "AddPartSaveBT";
            this.AddPartSaveBT.Size = new System.Drawing.Size(108, 42);
            this.AddPartSaveBT.TabIndex = 30;
            this.AddPartSaveBT.Text = "Save ";
            this.AddPartSaveBT.UseVisualStyleBackColor = true;
            this.AddPartSaveBT.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddPartCancelBT
            // 
            this.AddPartCancelBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartCancelBT.Location = new System.Drawing.Point(471, 524);
            this.AddPartCancelBT.Name = "AddPartCancelBT";
            this.AddPartCancelBT.Size = new System.Drawing.Size(108, 42);
            this.AddPartCancelBT.TabIndex = 31;
            this.AddPartCancelBT.Text = "Cancel";
            this.AddPartCancelBT.UseVisualStyleBackColor = true;
            this.AddPartCancelBT.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(225, 206);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(186, 39);
            this.txtInventory.TabIndex = 32;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(225, 277);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 39);
            this.txtPrice.TabIndex = 33;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(225, 345);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(186, 39);
            this.txtMax.TabIndex = 34;
            // 
            // txtMachineID
            // 
            this.txtMachineID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineID.Location = new System.Drawing.Point(225, 420);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(186, 39);
            this.txtMachineID.TabIndex = 35;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(521, 350);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(186, 39);
            this.txtMin.TabIndex = 36;
            // 
            // txtPartId
            // 
            this.txtPartId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPartId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartId.Location = new System.Drawing.Point(225, 87);
            this.txtPartId.Name = "txtPartId";
            this.txtPartId.ReadOnly = true;
            this.txtPartId.Size = new System.Drawing.Size(365, 39);
            this.txtPartId.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(225, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 39);
            this.txtName.TabIndex = 38;
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInHouse.Location = new System.Drawing.Point(291, 28);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(153, 37);
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
            this.radioOutsourced.Location = new System.Drawing.Point(471, 31);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(184, 37);
            this.radioOutsourced.TabIndex = 40;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(43, 425);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(139, 34);
            this.labelCompanyName.TabIndex = 41;
            this.labelCompanyName.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(225, 422);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(186, 39);
            this.txtCompanyName.TabIndex = 42;
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 603);
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