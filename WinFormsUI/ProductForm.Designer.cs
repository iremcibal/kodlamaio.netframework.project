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
            this.Add = new System.Windows.Forms.Button();
            this.UnitsInStockTb = new System.Windows.Forms.TextBox();
            this.UnitPriceTb = new System.Windows.Forms.TextBox();
            this.CategoryIDTb = new System.Windows.Forms.TextBox();
            this.ProductNameTb = new System.Windows.Forms.TextBox();
            this.UnitsInStock = new System.Windows.Forms.Label();
            this.UnitPrice = new System.Windows.Forms.Label();
            this.CategoryID = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.UnitsInStockUpdateTb = new System.Windows.Forms.TextBox();
            this.UnitPriceUpdateTb = new System.Windows.Forms.TextBox();
            this.CategoryIDUpdateTb = new System.Windows.Forms.TextBox();
            this.ProductNameUpdateTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.AddProductArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.ProductGridView.SelectionChanged += new System.EventHandler(this.productsDataGridView_SelectionChanged);
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
            // UnitsInStockTb
            // 
            this.UnitsInStockTb.Location = new System.Drawing.Point(175, 149);
            this.UnitsInStockTb.Name = "UnitsInStockTb";
            this.UnitsInStockTb.Size = new System.Drawing.Size(149, 22);
            this.UnitsInStockTb.TabIndex = 14;
            // 
            // UnitPriceTb
            // 
            this.UnitPriceTb.Location = new System.Drawing.Point(175, 110);
            this.UnitPriceTb.Name = "UnitPriceTb";
            this.UnitPriceTb.Size = new System.Drawing.Size(149, 22);
            this.UnitPriceTb.TabIndex = 13;
            // 
            // CategoryIDTb
            // 
            this.CategoryIDTb.Location = new System.Drawing.Point(175, 68);
            this.CategoryIDTb.Name = "CategoryIDTb";
            this.CategoryIDTb.Size = new System.Drawing.Size(149, 22);
            this.CategoryIDTb.TabIndex = 11;
            // 
            // ProductNameTb
            // 
            this.ProductNameTb.Location = new System.Drawing.Point(175, 32);
            this.ProductNameTb.Name = "ProductNameTb";
            this.ProductNameTb.Size = new System.Drawing.Size(149, 22);
            this.ProductNameTb.TabIndex = 9;
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
            // UnitPrice
            // 
            this.UnitPrice.AutoSize = true;
            this.UnitPrice.Location = new System.Drawing.Point(7, 110);
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Size = new System.Drawing.Size(61, 16);
            this.UnitPrice.TabIndex = 4;
            this.UnitPrice.Text = "UnitPrice";
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
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(7, 38);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(90, 16);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "ProductName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Update);
            this.groupBox1.Controls.Add(this.UnitsInStockUpdateTb);
            this.groupBox1.Controls.Add(this.UnitPriceUpdateTb);
            this.groupBox1.Controls.Add(this.CategoryIDUpdateTb);
            this.groupBox1.Controls.Add(this.ProductNameUpdateTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(391, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 268);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Product Area";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(83, 202);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(191, 36);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            // 
            // UnitsInStockUpdateTb
            // 
            this.UnitsInStockUpdateTb.Location = new System.Drawing.Point(175, 149);
            this.UnitsInStockUpdateTb.Name = "UnitsInStockUpdateTb";
            this.UnitsInStockUpdateTb.Size = new System.Drawing.Size(149, 22);
            this.UnitsInStockUpdateTb.TabIndex = 14;
            // 
            // UnitPriceUpdateTb
            // 
            this.UnitPriceUpdateTb.Location = new System.Drawing.Point(175, 110);
            this.UnitPriceUpdateTb.Name = "UnitPriceUpdateTb";
            this.UnitPriceUpdateTb.Size = new System.Drawing.Size(149, 22);
            this.UnitPriceUpdateTb.TabIndex = 13;
            // 
            // CategoryIDUpdateTb
            // 
            this.CategoryIDUpdateTb.Location = new System.Drawing.Point(175, 68);
            this.CategoryIDUpdateTb.Name = "CategoryIDUpdateTb";
            this.CategoryIDUpdateTb.Size = new System.Drawing.Size(149, 22);
            this.CategoryIDUpdateTb.TabIndex = 11;
            // 
            // ProductNameUpdateTb
            // 
            this.ProductNameUpdateTb.Location = new System.Drawing.Point(175, 32);
            this.ProductNameUpdateTb.Name = "ProductNameUpdateTb";
            this.ProductNameUpdateTb.Size = new System.Drawing.Size(149, 22);
            this.ProductNameUpdateTb.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "UnitsInStock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "UnitPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ProductName";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 612);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddProductArea);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.AddProductArea.ResumeLayout(false);
            this.AddProductArea.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox UnitsInStockUpdateTb;
        private System.Windows.Forms.TextBox UnitPriceUpdateTb;
        private System.Windows.Forms.TextBox CategoryIDUpdateTb;
        private System.Windows.Forms.TextBox ProductNameUpdateTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}