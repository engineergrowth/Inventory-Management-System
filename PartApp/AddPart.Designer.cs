namespace PartApp
{
    partial class AddPart
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
            this.AddPartLB = new System.Windows.Forms.Label();
            this.radioInHouse = new System.Windows.Forms.RadioButton();
            this.radioOutsourced = new System.Windows.Forms.RadioButton();
            this.AddPartNameLB = new System.Windows.Forms.Label();
            this.labelMachineID = new System.Windows.Forms.Label();
            this.AddPartMaxLB = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.AddPartMinLB = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtMachineID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.AddPartIDLB = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddPartLB
            // 
            this.AddPartLB.AutoSize = true;
            this.AddPartLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLB.Location = new System.Drawing.Point(39, 21);
            this.AddPartLB.Name = "AddPartLB";
            this.AddPartLB.Size = new System.Drawing.Size(139, 34);
            this.AddPartLB.TabIndex = 1;
            this.AddPartLB.Text = "Add Part:";
            // 
            // radioInHouse
            // 
            this.radioInHouse.AutoSize = true;
            this.radioInHouse.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioInHouse.Location = new System.Drawing.Point(236, 19);
            this.radioInHouse.Name = "radioInHouse";
            this.radioInHouse.Size = new System.Drawing.Size(153, 37);
            this.radioInHouse.TabIndex = 2;
            this.radioInHouse.TabStop = true;
            this.radioInHouse.Text = "In-House";
            this.radioInHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioInHouse.UseVisualStyleBackColor = true;
            // 
            // radioOutsourced
            // 
            this.radioOutsourced.AutoSize = true;
            this.radioOutsourced.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOutsourced.Location = new System.Drawing.Point(463, 19);
            this.radioOutsourced.Name = "radioOutsourced";
            this.radioOutsourced.Size = new System.Drawing.Size(184, 37);
            this.radioOutsourced.TabIndex = 3;
            this.radioOutsourced.TabStop = true;
            this.radioOutsourced.Text = "Outsourced";
            this.radioOutsourced.UseVisualStyleBackColor = true;
            // 
            // AddPartNameLB
            // 
            this.AddPartNameLB.AutoSize = true;
            this.AddPartNameLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartNameLB.Location = new System.Drawing.Point(65, 148);
            this.AddPartNameLB.Name = "AddPartNameLB";
            this.AddPartNameLB.Size = new System.Drawing.Size(93, 34);
            this.AddPartNameLB.TabIndex = 4;
            this.AddPartNameLB.Text = "Name";
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMachineID.Location = new System.Drawing.Point(59, 465);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(165, 34);
            this.labelMachineID.TabIndex = 5;
            this.labelMachineID.Text = "Machine ID";
            // 
            // AddPartMaxLB
            // 
            this.AddPartMaxLB.AutoSize = true;
            this.AddPartMaxLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMaxLB.Location = new System.Drawing.Point(65, 385);
            this.AddPartMaxLB.Name = "AddPartMaxLB";
            this.AddPartMaxLB.Size = new System.Drawing.Size(72, 34);
            this.AddPartMaxLB.TabIndex = 6;
            this.AddPartMaxLB.Text = "Max";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(65, 298);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(148, 34);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price/Cost";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.Location = new System.Drawing.Point(65, 225);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(142, 34);
            this.labelInventory.TabIndex = 8;
            this.labelInventory.Text = "Inventory";
            // 
            // AddPartMinLB
            // 
            this.AddPartMinLB.AutoSize = true;
            this.AddPartMinLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartMinLB.Location = new System.Drawing.Point(457, 385);
            this.AddPartMinLB.Name = "AddPartMinLB";
            this.AddPartMinLB.Size = new System.Drawing.Size(67, 34);
            this.AddPartMinLB.TabIndex = 9;
            this.AddPartMinLB.Text = "Min";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(110, 552);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(463, 552);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 42);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtMachineID
            // 
            this.txtMachineID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineID.Location = new System.Drawing.Point(230, 460);
            this.txtMachineID.Name = "txtMachineID";
            this.txtMachineID.Size = new System.Drawing.Size(186, 39);
            this.txtMachineID.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(230, 298);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 39);
            this.txtPrice.TabIndex = 16;
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(230, 380);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(186, 39);
            this.txtMax.TabIndex = 18;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(552, 385);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(209, 39);
            this.txtMin.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(230, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(365, 39);
            this.txtName.TabIndex = 21;
            // 
            // AddPartIDLB
            // 
            this.AddPartIDLB.AutoSize = true;
            this.AddPartIDLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartIDLB.Location = new System.Drawing.Point(65, 75);
            this.AddPartIDLB.Name = "AddPartIDLB";
            this.AddPartIDLB.Size = new System.Drawing.Size(53, 34);
            this.AddPartIDLB.TabIndex = 22;
            this.AddPartIDLB.Text = " ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtID.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(230, 77);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(365, 39);
            this.txtID.TabIndex = 23;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyName.Location = new System.Drawing.Point(65, 458);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(139, 34);
            this.labelCompanyName.TabIndex = 24;
            this.labelCompanyName.Text = "Company";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(230, 458);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(186, 39);
            this.txtCompanyName.TabIndex = 25;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(230, 225);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(186, 39);
            this.txtInventory.TabIndex = 33;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(795, 668);
            this.Controls.Add(this.txtInventory);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.AddPartIDLB);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtMachineID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AddPartMinLB);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.AddPartMaxLB);
            this.Controls.Add(this.labelMachineID);
            this.Controls.Add(this.AddPartNameLB);
            this.Controls.Add(this.radioOutsourced);
            this.Controls.Add(this.radioInHouse);
            this.Controls.Add(this.AddPartLB);
            this.Name = "AddPart";
            this.Text = " Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLB;
        private System.Windows.Forms.RadioButton radioInHouse;
        private System.Windows.Forms.RadioButton radioOutsourced;
        private System.Windows.Forms.Label AddPartNameLB;
        private System.Windows.Forms.Label labelMachineID;
        private System.Windows.Forms.Label AddPartMaxLB;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label AddPartMinLB;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtMachineID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label AddPartIDLB;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtInventory;
    }
}