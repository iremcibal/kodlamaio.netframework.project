namespace WinFormsUI
{
    partial class Form1
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
            this.BtnReadData = new System.Windows.Forms.Button();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReadData
            // 
            this.BtnReadData.Location = new System.Drawing.Point(37, 23);
            this.BtnReadData.Name = "BtnReadData";
            this.BtnReadData.Size = new System.Drawing.Size(237, 71);
            this.BtnReadData.TabIndex = 0;
            this.BtnReadData.Text = "First Read Button";
            this.BtnReadData.UseVisualStyleBackColor = true;
            this.BtnReadData.Click += new System.EventHandler(this.btnDataReader_Click);
            // 
            // btnWriteData
            // 
            //this.btnWriteData.Location = new System.Drawing.Point(383, 27);
            //this.btnWriteData.Name = "btnWriteData";
            //this.btnWriteData.Size = new System.Drawing.Size(203, 66);
            //this.btnWriteData.TabIndex = 1;
            //this.btnWriteData.Text = "btnWriteData";
            //this.btnWriteData.UseVisualStyleBackColor = true;
            //this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.Location = new System.Drawing.Point(46, 137);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(227, 77);
            this.btnUpdateData.TabIndex = 2;
            this.btnUpdateData.Text = "btnUpdateData";
            this.btnUpdateData.UseVisualStyleBackColor = true;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(374, 129);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(211, 84);
            this.btnDeleteData.TabIndex = 3;
            this.btnDeleteData.Text = "btnDeleteData";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnWriteData);
            this.Controls.Add(this.BtnReadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReadData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Button btnDeleteData;
    }
}

