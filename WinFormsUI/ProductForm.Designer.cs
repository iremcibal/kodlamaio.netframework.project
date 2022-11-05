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
            this.updateArea = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.UnitsInStockUpdateTb = new System.Windows.Forms.TextBox();
            this.UnitPriceUpdateTb = new System.Windows.Forms.TextBox();
            this.CategoryIDUpdateTb = new System.Windows.Forms.TextBox();
            this.ProductNameUpdateTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteArea = new System.Windows.Forms.GroupBox();
            this.Delete = new System.Windows.Forms.Button();
            this.UnitsInStockDeleteTb = new System.Windows.Forms.TextBox();
            this.UnitPriceDeleteTb = new System.Windows.Forms.TextBox();
            this.CategoryIDDeleteTb = new System.Windows.Forms.TextBox();
            this.ProductNameDeleteTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.AddProductArea.SuspendLayout();
            this.updateArea.SuspendLayout();
            this.deleteArea.SuspendLayout();
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
            this.ProductGridView.Size = new System.Drawing.Size(1126, 172);
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
            // updateArea
            // 
            this.updateArea.Controls.Add(this.Update);
            this.updateArea.Controls.Add(this.UnitsInStockUpdateTb);
            this.updateArea.Controls.Add(this.UnitPriceUpdateTb);
            this.updateArea.Controls.Add(this.CategoryIDUpdateTb);
            this.updateArea.Controls.Add(this.ProductNameUpdateTb);
            this.updateArea.Controls.Add(this.label1);
            this.updateArea.Controls.Add(this.label2);
            this.updateArea.Controls.Add(this.label3);
            this.updateArea.Controls.Add(this.label4);
            this.updateArea.Location = new System.Drawing.Point(391, 202);
            this.updateArea.Name = "updateArea";
            this.updateArea.Size = new System.Drawing.Size(365, 268);
            this.updateArea.TabIndex = 19;
            this.updateArea.TabStop = false;
            this.updateArea.Text = "Update Product Area";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(83, 202);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(191, 36);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
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
            // deleteArea
            // 
            this.deleteArea.Controls.Add(this.Delete);
            this.deleteArea.Controls.Add(this.UnitsInStockDeleteTb);
            this.deleteArea.Controls.Add(this.UnitPriceDeleteTb);
            this.deleteArea.Controls.Add(this.CategoryIDDeleteTb);
            this.deleteArea.Controls.Add(this.ProductNameDeleteTb);
            this.deleteArea.Controls.Add(this.label5);
            this.deleteArea.Controls.Add(this.label6);
            this.deleteArea.Controls.Add(this.label7);
            this.deleteArea.Controls.Add(this.label8);
            this.deleteArea.Location = new System.Drawing.Point(772, 202);
            this.deleteArea.Name = "deleteArea";
            this.deleteArea.Size = new System.Drawing.Size(365, 268);
            this.deleteArea.TabIndex = 20;
            this.deleteArea.TabStop = false;
            this.deleteArea.Text = "Delete Product Area";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(83, 202);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(191, 36);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // UnitsInStockDeleteTb
            // 
            this.UnitsInStockDeleteTb.Location = new System.Drawing.Point(175, 149);
            this.UnitsInStockDeleteTb.Name = "UnitsInStockDeleteTb";
            this.UnitsInStockDeleteTb.Size = new System.Drawing.Size(149, 22);
            this.UnitsInStockDeleteTb.TabIndex = 14;
            // 
            // UnitPriceDeleteTb
            // 
            this.UnitPriceDeleteTb.Location = new System.Drawing.Point(175, 110);
            this.UnitPriceDeleteTb.Name = "UnitPriceDeleteTb";
            this.UnitPriceDeleteTb.Size = new System.Drawing.Size(149, 22);
            this.UnitPriceDeleteTb.TabIndex = 13;
            // 
            // CategoryIDDeleteTb
            // 
            this.CategoryIDDeleteTb.Location = new System.Drawing.Point(175, 68);
            this.CategoryIDDeleteTb.Name = "CategoryIDDeleteTb";
            this.CategoryIDDeleteTb.Size = new System.Drawing.Size(149, 22);
            this.CategoryIDDeleteTb.TabIndex = 11;
            // 
            // ProductNameDeleteTb
            // 
            this.ProductNameDeleteTb.Location = new System.Drawing.Point(175, 32);
            this.ProductNameDeleteTb.Name = "ProductNameDeleteTb";
            this.ProductNameDeleteTb.Size = new System.Drawing.Size(149, 22);
            this.ProductNameDeleteTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "UnitsInStock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "UnitPrice";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "CategoryID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "ProductName";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 516);
            this.Controls.Add(this.deleteArea);
            this.Controls.Add(this.updateArea);
            this.Controls.Add(this.AddProductArea);
            this.Controls.Add(this.ProductGridView);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.AddProductArea.ResumeLayout(false);
            this.AddProductArea.PerformLayout();
            this.updateArea.ResumeLayout(false);
            this.updateArea.PerformLayout();
            this.deleteArea.ResumeLayout(false);
            this.deleteArea.PerformLayout();
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
        private System.Windows.Forms.GroupBox updateArea;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox UnitsInStockUpdateTb;
        private System.Windows.Forms.TextBox UnitPriceUpdateTb;
        private System.Windows.Forms.TextBox CategoryIDUpdateTb;
        private System.Windows.Forms.TextBox ProductNameUpdateTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox deleteArea;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox UnitsInStockDeleteTb;
        private System.Windows.Forms.TextBox UnitPriceDeleteTb;
        private System.Windows.Forms.TextBox CategoryIDDeleteTb;
        private System.Windows.Forms.TextBox ProductNameDeleteTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}