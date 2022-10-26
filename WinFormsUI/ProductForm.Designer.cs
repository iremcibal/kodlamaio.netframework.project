namespace WinFormsUI
{
    partial class ProductForm
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.AddProductArea = new System.Windows.Forms.GroupBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.UnitsInStock = new System.Windows.Forms.Label();
            this.ProductNameTb = new System.Windows.Forms.TextBox();
            this.CategoryIDTb = new System.Windows.Forms.TextBox();
            this.UnitPriceTb = new System.Windows.Forms.TextBox();
            this.UnitsInStockTb = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.AddProductArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.AllowUserToDeleteRows = false;
            this.ProductGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Location = new System.Drawing.Point(11, 11);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.ReadOnly = true;
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 24;
            this.ProductGridView.Size = new System.Drawing.Size(1018, 174);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            // 
            // AddProductArea
            // 
            this.AddProductArea.Controls.Add(this.Add);
            this.AddProductArea.Controls.Add(this.UnitsInStockTb);
            this.AddProductArea.Controls.Add(this.UnitPriceTb);
            this.AddProductArea.Controls.Add(this.CategoryIDTb);
            this.AddProductArea.Controls.Add(this.ProductNameTb);
            this.AddProductArea.Controls.Add(this.UnitsInStock);
            this.AddProductArea.Controls.Add(this.UnitPrice);
            this.AddProductArea.Controls.Add(this.CategoryID);
            this.AddProductArea.Controls.Add(this.ProductName);
            this.AddProductArea.Location = new System.Drawing.Point(11, 202);
            this.AddProductArea.Name = "AddProductArea";
            this.AddProductArea.Size = new System.Drawing.Size(365, 268);
            this.AddProductArea.TabIndex = 1;
            this.AddProductArea.TabStop = false;
            this.AddProductArea.Text = "Add Product Area";
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(7, 38);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(90, 16);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "ProductName";
            // 
            // CategoryID
            // 
            this.CategoryID.AutoSize = true;
            this.CategoryID.Location = new System.Drawing.Point(7, 74);
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Size = new System.Drawing.Size(75, 16);
            this.CategoryID.TabIndex = 2;
            this.CategoryID.Text = "CategoryID";
            this.CategoryID.Click += new System.EventHandler(this.label3_Click);
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Location = new System.Drawing.Point(7, 116);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(61, 16);
            this.UnitPrice.TabIndex = 4;
            this.UnitPrice.Text = "UnitPrice";
            // 
            // UnitsInStock
            // 
            this.UnitsInStock.AutoSize = true;
            this.UnitsInStock.Location = new System.Drawing.Point(7, 149);
            this.UnitsInStock.Name = "UnitsInStock";
            this.UnitsInStock.Size = new System.Drawing.Size(81, 16);
            this.UnitsInStock.TabIndex = 5;
            this.UnitsInStock.Text = "UnitsInStock";
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.Location = new System.Drawing.Point(175, 32);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.Size = new System.Drawing.Size(149, 22);
            this.ProductNameTb.TabIndex = 9;
            // 
            // CategoryIDTb
            // 
            this.CategoryIDTb.Location = new System.Drawing.Point(175, 68);
            this.CategoryIDTb.Name = "CategoryIDTb";
            this.CategoryIDTb.Size = new System.Drawing.Size(149, 22);
            this.CategoryIDTb.TabIndex = 11;
            // 
            // UnitPriceTb
            // 
            this.UnitPriceTb.Location = new System.Drawing.Point(175, 110);
            this.UnitPriceTb.Name = "UnitPriceTb";
            this.UnitPriceTb.Size = new System.Drawing.Size(149, 22);
            this.UnitPriceTb.TabIndex = 13;
            // 
            // UnitsInStockTb
            // 
            this.UnitsInStockTb.Location = new System.Drawing.Point(175, 149);
            this.UnitsInStockTb.Name = "UnitsInStockTb";
            this.UnitsInStockTb.Size = new System.Drawing.Size(149, 22);
            this.UnitsInStockTb.TabIndex = 14;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(83, 202);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(191, 36);
            this.Add.TabIndex = 18;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 612);
            this.Controls.Add(this.AddProductArea);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.AddProductArea.ResumeLayout(false);
            this.AddProductArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.GroupBox AddProductArea;
        private System.Windows.Forms.Label UnitsInStock;
        private System.Windows.Forms.Label UnitPrice;
        private System.Windows.Forms.Label CategoryID;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox UnitsInStockTb;
        private System.Windows.Forms.TextBox UnitPriceTb;
        private System.Windows.Forms.TextBox CategoryIDTb;
        private System.Windows.Forms.TextBox ProductNameTb;
    }
}