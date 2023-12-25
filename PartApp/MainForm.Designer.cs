namespace PartApp
{
    partial class MainForm
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
            this.MainLB = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.PartSearchBT = new System.Windows.Forms.Button();
            this.PartSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsSearchBT = new System.Windows.Forms.Button();
            this.ProductSearchBox = new System.Windows.Forms.TextBox();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.ModifyProductBT = new System.Windows.Forms.Button();
            this.ModifyPartBT = new System.Windows.Forms.Button();
            this.DeletePartBT = new System.Windows.Forms.Button();
            this.AddProductBT = new System.Windows.Forms.Button();
            this.DeleteProductBT = new System.Windows.Forms.Button();
            this.AddPartBT = new System.Windows.Forms.Button();
            this.ExitBT = new System.Windows.Forms.Button();
            this.MainPartDGV = new System.Windows.Forms.DataGridView();
            this.MainProductDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MainPartDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLB
            // 
            this.MainLB.AutoSize = true;
            this.MainLB.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLB.Location = new System.Drawing.Point(21, 22);
            this.MainLB.Name = "MainLB";
            this.MainLB.Size = new System.Drawing.Size(428, 34);
            this.MainLB.TabIndex = 0;
            this.MainLB.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(79, 100);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(81, 34);
            this.PartsLabel.TabIndex = 1;
            this.PartsLabel.Text = "Parts";
            // 
            // PartSearchBT
            // 
            this.PartSearchBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchBT.Location = new System.Drawing.Point(195, 97);
            this.PartSearchBT.Name = "PartSearchBT";
            this.PartSearchBT.Size = new System.Drawing.Size(108, 42);
            this.PartSearchBT.TabIndex = 2;
            this.PartSearchBT.Text = "Search";
            this.PartSearchBT.UseVisualStyleBackColor = true;
            this.PartSearchBT.Click += new System.EventHandler(this.PartSearchBT_Click);
            // 
            // PartSearchBox
            // 
            this.PartSearchBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchBox.Location = new System.Drawing.Point(319, 97);
            this.PartSearchBox.Name = "PartSearchBox";
            this.PartSearchBox.Size = new System.Drawing.Size(333, 39);
            this.PartSearchBox.TabIndex = 3;
            // 
            // ProductsSearchBT
            // 
            this.ProductsSearchBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsSearchBT.Location = new System.Drawing.Point(883, 102);
            this.ProductsSearchBT.Name = "ProductsSearchBT";
            this.ProductsSearchBT.Size = new System.Drawing.Size(108, 37);
            this.ProductsSearchBT.TabIndex = 4;
            this.ProductsSearchBT.Text = "Search";
            this.ProductsSearchBT.UseVisualStyleBackColor = true;
            this.ProductsSearchBT.Click += new System.EventHandler(this.ProductsSearchBT_Click);
            // 
            // ProductSearchBox
            // 
            this.ProductSearchBox.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearchBox.Location = new System.Drawing.Point(1014, 97);
            this.ProductSearchBox.Name = "ProductSearchBox";
            this.ProductSearchBox.Size = new System.Drawing.Size(312, 39);
            this.ProductSearchBox.TabIndex = 5;
            this.ProductSearchBox.Click += new System.EventHandler(this.ProductsSearchBT_Click);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(718, 105);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(130, 34);
            this.ProductsLabel.TabIndex = 6;
            this.ProductsLabel.Text = "Products";
            // 
            // ModifyProductBT
            // 
            this.ModifyProductBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyProductBT.Location = new System.Drawing.Point(1029, 606);
            this.ModifyProductBT.Name = "ModifyProductBT";
            this.ModifyProductBT.Size = new System.Drawing.Size(108, 44);
            this.ModifyProductBT.TabIndex = 7;
            this.ModifyProductBT.Text = "Modify";
            this.ModifyProductBT.UseVisualStyleBackColor = true;
            this.ModifyProductBT.Click += new System.EventHandler(this.ModifyProductBT_Click);
            // 
            // ModifyPartBT
            // 
            this.ModifyPartBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyPartBT.Location = new System.Drawing.Point(341, 608);
            this.ModifyPartBT.Name = "ModifyPartBT";
            this.ModifyPartBT.Size = new System.Drawing.Size(108, 42);
            this.ModifyPartBT.TabIndex = 8;
            this.ModifyPartBT.Text = "Modify";
            this.ModifyPartBT.UseVisualStyleBackColor = true;
            this.ModifyPartBT.Click += new System.EventHandler(this.ModifyPartBT_Click);
            // 
            // DeletePartBT
            // 
            this.DeletePartBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartBT.Location = new System.Drawing.Point(485, 608);
            this.DeletePartBT.Name = "DeletePartBT";
            this.DeletePartBT.Size = new System.Drawing.Size(108, 42);
            this.DeletePartBT.TabIndex = 9;
            this.DeletePartBT.Text = "Delete";
            this.DeletePartBT.UseVisualStyleBackColor = true;
            this.DeletePartBT.Click += new System.EventHandler(this.DeletePartBT_Click);
            // 
            // AddProductBT
            // 
            this.AddProductBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductBT.Location = new System.Drawing.Point(883, 606);
            this.AddProductBT.Name = "AddProductBT";
            this.AddProductBT.Size = new System.Drawing.Size(108, 44);
            this.AddProductBT.TabIndex = 10;
            this.AddProductBT.Text = "Add";
            this.AddProductBT.UseVisualStyleBackColor = true;
            this.AddProductBT.Click += new System.EventHandler(this.AddProductBT_Click);
            // 
            // DeleteProductBT
            // 
            this.DeleteProductBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteProductBT.Location = new System.Drawing.Point(1177, 606);
            this.DeleteProductBT.Name = "DeleteProductBT";
            this.DeleteProductBT.Size = new System.Drawing.Size(108, 44);
            this.DeleteProductBT.TabIndex = 11;
            this.DeleteProductBT.Text = "Delete";
            this.DeleteProductBT.UseVisualStyleBackColor = true;
            this.DeleteProductBT.Click += new System.EventHandler(this.DeleteProductBT_Click);
            // 
            // AddPartBT
            // 
            this.AddPartBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartBT.Location = new System.Drawing.Point(195, 608);
            this.AddPartBT.Name = "AddPartBT";
            this.AddPartBT.Size = new System.Drawing.Size(108, 42);
            this.AddPartBT.TabIndex = 12;
            this.AddPartBT.Text = "Add";
            this.AddPartBT.UseVisualStyleBackColor = true;
            this.AddPartBT.Click += new System.EventHandler(this.AddPartBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBT.Location = new System.Drawing.Point(1208, 25);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(108, 35);
            this.ExitBT.TabIndex = 13;
            this.ExitBT.Text = "Exit";
            this.ExitBT.UseVisualStyleBackColor = true;
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // MainPartDGV
            // 
            this.MainPartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainPartDGV.Location = new System.Drawing.Point(12, 169);
            this.MainPartDGV.Name = "MainPartDGV";
            this.MainPartDGV.RowHeadersWidth = 62;
            this.MainPartDGV.RowTemplate.Height = 28;
            this.MainPartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainPartDGV.Size = new System.Drawing.Size(671, 415);
            this.MainPartDGV.TabIndex = 14;
            // 
            // MainProductDGV
            // 
            this.MainProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainProductDGV.Location = new System.Drawing.Point(689, 169);
            this.MainProductDGV.Name = "MainProductDGV";
            this.MainProductDGV.RowHeadersWidth = 62;
            this.MainProductDGV.RowTemplate.Height = 28;
            this.MainProductDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainProductDGV.Size = new System.Drawing.Size(658, 415);
            this.MainProductDGV.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1359, 674);
            this.Controls.Add(this.MainProductDGV);
            this.Controls.Add(this.MainPartDGV);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.AddPartBT);
            this.Controls.Add(this.DeleteProductBT);
            this.Controls.Add(this.AddProductBT);
            this.Controls.Add(this.DeletePartBT);
            this.Controls.Add(this.ModifyPartBT);
            this.Controls.Add(this.ModifyProductBT);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.ProductSearchBox);
            this.Controls.Add(this.ProductsSearchBT);
            this.Controls.Add(this.PartSearchBox);
            this.Controls.Add(this.PartSearchBT);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.MainLB);
            this.Name = "MainForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPartDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainProductDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLB;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Button PartSearchBT;
        private System.Windows.Forms.TextBox PartSearchBox;
        private System.Windows.Forms.Button ProductsSearchBT;
        private System.Windows.Forms.TextBox ProductSearchBox;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button ModifyProductBT;
        private System.Windows.Forms.Button ModifyPartBT;
        private System.Windows.Forms.Button DeletePartBT;
        private System.Windows.Forms.Button AddProductBT;
        private System.Windows.Forms.Button DeleteProductBT;
        private System.Windows.Forms.Button AddPartBT;
        private System.Windows.Forms.Button ExitBT;
        private System.Windows.Forms.DataGridView MainPartDGV;
        private System.Windows.Forms.DataGridView MainProductDGV;
    }
}