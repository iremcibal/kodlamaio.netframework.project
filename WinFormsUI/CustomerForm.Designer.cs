namespace WinFormsUI
{
    partial class CustomerForm
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomerArea = new System.Windows.Forms.GroupBox();
            this.AddBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AddLastNameTb = new System.Windows.Forms.TextBox();
            this.AddFirstNameTb = new System.Windows.Forms.TextBox();
            this.AddIdentityNumberTb = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.IdentityNumber = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.AddCustomerIdTb = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.Label();
            this.AddPhoneTb = new System.Windows.Forms.TextBox();
            this.AddCountryTb = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.AddCompanyNameTb = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.Label();
            this.UpdateCustomerArea = new System.Windows.Forms.GroupBox();
            this.UpdateBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.UpdateLastNameTb = new System.Windows.Forms.TextBox();
            this.UpdateFirstNameTb = new System.Windows.Forms.TextBox();
            this.UpdateIdentityNumberTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateCustomerIdTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdatePhoneTb = new System.Windows.Forms.TextBox();
            this.UpdateCountryTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.UpdateCompanyNameTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DeleteCustomerArea = new System.Windows.Forms.GroupBox();
            this.DeleteBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteLastNameTb = new System.Windows.Forms.TextBox();
            this.DeleteFirstNameTb = new System.Windows.Forms.TextBox();
            this.DeleteIdentityNumberTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.DeleteCustomerIdTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeletePhoneTb = new System.Windows.Forms.TextBox();
            this.DeleteCountryTb = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteCompanyNameTb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.AddCustomerArea.SuspendLayout();
            this.UpdateCustomerArea.SuspendLayout();
            this.DeleteCustomerArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Location = new System.Drawing.Point(12, 12);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowHeadersWidth = 51;
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(1138, 176);
            this.customerDataGridView.TabIndex = 0;
            this.customerDataGridView.SelectionChanged += new System.EventHandler(this.customerDataGridView_SelectionChanged);
            // 
            // AddCustomerArea
            // 
            this.AddCustomerArea.Controls.Add(this.AddBirthDatePicker);
            this.AddCustomerArea.Controls.Add(this.AddLastNameTb);
            this.AddCustomerArea.Controls.Add(this.AddFirstNameTb);
            this.AddCustomerArea.Controls.Add(this.AddIdentityNumberTb);
            this.AddCustomerArea.Controls.Add(this.BirthDate);
            this.AddCustomerArea.Controls.Add(this.LastName);
            this.AddCustomerArea.Controls.Add(this.IdentityNumber);
            this.AddCustomerArea.Controls.Add(this.FirstName);
            this.AddCustomerArea.Controls.Add(this.AddCustomerIdTb);
            this.AddCustomerArea.Controls.Add(this.CustomerID);
            this.AddCustomerArea.Controls.Add(this.AddPhoneTb);
            this.AddCustomerArea.Controls.Add(this.AddCountryTb);
            this.AddCustomerArea.Controls.Add(this.Country);
            this.AddCustomerArea.Controls.Add(this.Phone);
            this.AddCustomerArea.Controls.Add(this.Add);
            this.AddCustomerArea.Controls.Add(this.AddCompanyNameTb);
            this.AddCustomerArea.Controls.Add(this.CompanyName);
            this.AddCustomerArea.Location = new System.Drawing.Point(12, 194);
            this.AddCustomerArea.Name = "AddCustomerArea";
            this.AddCustomerArea.Size = new System.Drawing.Size(365, 300);
            this.AddCustomerArea.TabIndex = 2;
            this.AddCustomerArea.TabStop = false;
            this.AddCustomerArea.Text = "Add Customer Area";
            // 
            // AddBirthDatePicker
            // 
            this.AddBirthDatePicker.Location = new System.Drawing.Point(191, 227);
            this.AddBirthDatePicker.Name = "AddBirthDatePicker";
            this.AddBirthDatePicker.Size = new System.Drawing.Size(148, 22);
            this.AddBirthDatePicker.TabIndex = 37;
            // 
            // AddLastNameTb
            // 
            this.AddLastNameTb.Location = new System.Drawing.Point(191, 194);
            this.AddLastNameTb.Name = "AddLastNameTb";
            this.AddLastNameTb.Size = new System.Drawing.Size(149, 22);
            this.AddLastNameTb.TabIndex = 36;
            // 
            // AddFirstNameTb
            // 
            this.AddFirstNameTb.Location = new System.Drawing.Point(191, 160);
            this.AddFirstNameTb.Name = "AddFirstNameTb";
            this.AddFirstNameTb.Size = new System.Drawing.Size(149, 22);
            this.AddFirstNameTb.TabIndex = 35;
            // 
            // AddIdentityNumberTb
            // 
            this.AddIdentityNumberTb.Location = new System.Drawing.Point(191, 130);
            this.AddIdentityNumberTb.Name = "AddIdentityNumberTb";
            this.AddIdentityNumberTb.Size = new System.Drawing.Size(149, 22);
            this.AddIdentityNumberTb.TabIndex = 34;
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(23, 224);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(62, 16);
            this.BirthDate.TabIndex = 33;
            this.BirthDate.Text = "BirthDate";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(23, 194);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(69, 16);
            this.LastName.TabIndex = 32;
            this.LastName.Text = "LastName";
            // 
            // IdentityNumber
            // 
            this.IdentityNumber.AutoSize = true;
            this.IdentityNumber.Location = new System.Drawing.Point(22, 133);
            this.IdentityNumber.Name = "IdentityNumber";
            this.IdentityNumber.Size = new System.Drawing.Size(97, 16);
            this.IdentityNumber.TabIndex = 31;
            this.IdentityNumber.Text = "IdentityNumber";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(23, 166);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(69, 16);
            this.FirstName.TabIndex = 30;
            this.FirstName.Text = "FirstName";
            // 
            // AddCustomerIdTb
            // 
            this.AddCustomerIdTb.Location = new System.Drawing.Point(191, 12);
            this.AddCustomerIdTb.Name = "AddCustomerIdTb";
            this.AddCustomerIdTb.Size = new System.Drawing.Size(149, 22);
            this.AddCustomerIdTb.TabIndex = 29;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(22, 18);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(77, 16);
            this.CustomerID.TabIndex = 28;
            this.CustomerID.Text = "CustomerID";
            // 
            // AddPhoneTb
            // 
            this.AddPhoneTb.Location = new System.Drawing.Point(191, 101);
            this.AddPhoneTb.Name = "AddPhoneTb";
            this.AddPhoneTb.Size = new System.Drawing.Size(149, 22);
            this.AddPhoneTb.TabIndex = 24;
            // 
            // AddCountryTb
            // 
            this.AddCountryTb.Location = new System.Drawing.Point(191, 71);
            this.AddCountryTb.Name = "AddCountryTb";
            this.AddCountryTb.Size = new System.Drawing.Size(149, 22);
            this.AddCountryTb.TabIndex = 23;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Location = new System.Drawing.Point(22, 74);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(52, 16);
            this.Country.TabIndex = 20;
            this.Country.Text = "Country";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(23, 107);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(46, 16);
            this.Phone.TabIndex = 19;
            this.Phone.Text = "Phone";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(104, 255);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(145, 36);
            this.Add.TabIndex = 18;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddCompanyNameTb
            // 
            this.AddCompanyNameTb.Location = new System.Drawing.Point(191, 43);
            this.AddCompanyNameTb.Name = "AddCompanyNameTb";
            this.AddCompanyNameTb.Size = new System.Drawing.Size(149, 22);
            this.AddCompanyNameTb.TabIndex = 9;
            // 
            // CompanyName
            // 
            this.CompanyName.AutoSize = true;
            this.CompanyName.Location = new System.Drawing.Point(23, 49);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(102, 16);
            this.CompanyName.TabIndex = 0;
            this.CompanyName.Text = "CompanyName";
            // 
            // UpdateCustomerArea
            // 
            this.UpdateCustomerArea.Controls.Add(this.UpdateBirthDatePicker);
            this.UpdateCustomerArea.Controls.Add(this.UpdateLastNameTb);
            this.UpdateCustomerArea.Controls.Add(this.UpdateFirstNameTb);
            this.UpdateCustomerArea.Controls.Add(this.UpdateIdentityNumberTb);
            this.UpdateCustomerArea.Controls.Add(this.label1);
            this.UpdateCustomerArea.Controls.Add(this.label2);
            this.UpdateCustomerArea.Controls.Add(this.label3);
            this.UpdateCustomerArea.Controls.Add(this.label4);
            this.UpdateCustomerArea.Controls.Add(this.UpdateCustomerIdTb);
            this.UpdateCustomerArea.Controls.Add(this.label5);
            this.UpdateCustomerArea.Controls.Add(this.UpdatePhoneTb);
            this.UpdateCustomerArea.Controls.Add(this.UpdateCountryTb);
            this.UpdateCustomerArea.Controls.Add(this.label6);
            this.UpdateCustomerArea.Controls.Add(this.label7);
            this.UpdateCustomerArea.Controls.Add(this.Update);
            this.UpdateCustomerArea.Controls.Add(this.UpdateCompanyNameTb);
            this.UpdateCustomerArea.Controls.Add(this.label8);
            this.UpdateCustomerArea.Location = new System.Drawing.Point(394, 194);
            this.UpdateCustomerArea.Name = "UpdateCustomerArea";
            this.UpdateCustomerArea.Size = new System.Drawing.Size(365, 300);
            this.UpdateCustomerArea.TabIndex = 38;
            this.UpdateCustomerArea.TabStop = false;
            this.UpdateCustomerArea.Text = "Update Customer Area";
            // 
            // UpdateBirthDatePicker
            // 
            this.UpdateBirthDatePicker.Location = new System.Drawing.Point(191, 227);
            this.UpdateBirthDatePicker.Name = "UpdateBirthDatePicker";
            this.UpdateBirthDatePicker.Size = new System.Drawing.Size(148, 22);
            this.UpdateBirthDatePicker.TabIndex = 37;
            // 
            // UpdateLastNameTb
            // 
            this.UpdateLastNameTb.Location = new System.Drawing.Point(191, 194);
            this.UpdateLastNameTb.Name = "UpdateLastNameTb";
            this.UpdateLastNameTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateLastNameTb.TabIndex = 36;
            // 
            // UpdateFirstNameTb
            // 
            this.UpdateFirstNameTb.Location = new System.Drawing.Point(191, 160);
            this.UpdateFirstNameTb.Name = "UpdateFirstNameTb";
            this.UpdateFirstNameTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateFirstNameTb.TabIndex = 35;
            // 
            // UpdateIdentityNumberTb
            // 
            this.UpdateIdentityNumberTb.Location = new System.Drawing.Point(191, 130);
            this.UpdateIdentityNumberTb.Name = "UpdateIdentityNumberTb";
            this.UpdateIdentityNumberTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateIdentityNumberTb.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "IdentityNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "FirstName";
            // 
            // UpdateCustomerIdTb
            // 
            this.UpdateCustomerIdTb.Location = new System.Drawing.Point(191, 12);
            this.UpdateCustomerIdTb.Name = "UpdateCustomerIdTb";
            this.UpdateCustomerIdTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateCustomerIdTb.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "CustomerID";
            // 
            // UpdatePhoneTb
            // 
            this.UpdatePhoneTb.Location = new System.Drawing.Point(191, 101);
            this.UpdatePhoneTb.Name = "UpdatePhoneTb";
            this.UpdatePhoneTb.Size = new System.Drawing.Size(149, 22);
            this.UpdatePhoneTb.TabIndex = 24;
            // 
            // UpdateCountryTb
            // 
            this.UpdateCountryTb.Location = new System.Drawing.Point(191, 71);
            this.UpdateCountryTb.Name = "UpdateCountryTb";
            this.UpdateCountryTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateCountryTb.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(104, 255);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(145, 36);
            this.Update.TabIndex = 18;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // UpdateCompanyNameTb
            // 
            this.UpdateCompanyNameTb.Location = new System.Drawing.Point(191, 43);
            this.UpdateCompanyNameTb.Name = "UpdateCompanyNameTb";
            this.UpdateCompanyNameTb.Size = new System.Drawing.Size(149, 22);
            this.UpdateCompanyNameTb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "CompanyName";
            // 
            // DeleteCustomerArea
            // 
            this.DeleteCustomerArea.Controls.Add(this.DeleteBirthDatePicker);
            this.DeleteCustomerArea.Controls.Add(this.DeleteLastNameTb);
            this.DeleteCustomerArea.Controls.Add(this.DeleteFirstNameTb);
            this.DeleteCustomerArea.Controls.Add(this.DeleteIdentityNumberTb);
            this.DeleteCustomerArea.Controls.Add(this.label9);
            this.DeleteCustomerArea.Controls.Add(this.label10);
            this.DeleteCustomerArea.Controls.Add(this.label11);
            this.DeleteCustomerArea.Controls.Add(this.label12);
            this.DeleteCustomerArea.Controls.Add(this.DeleteCustomerIdTb);
            this.DeleteCustomerArea.Controls.Add(this.label13);
            this.DeleteCustomerArea.Controls.Add(this.DeletePhoneTb);
            this.DeleteCustomerArea.Controls.Add(this.DeleteCountryTb);
            this.DeleteCustomerArea.Controls.Add(this.label14);
            this.DeleteCustomerArea.Controls.Add(this.label15);
            this.DeleteCustomerArea.Controls.Add(this.Delete);
            this.DeleteCustomerArea.Controls.Add(this.DeleteCompanyNameTb);
            this.DeleteCustomerArea.Controls.Add(this.label16);
            this.DeleteCustomerArea.Location = new System.Drawing.Point(785, 194);
            this.DeleteCustomerArea.Name = "DeleteCustomerArea";
            this.DeleteCustomerArea.Size = new System.Drawing.Size(365, 300);
            this.DeleteCustomerArea.TabIndex = 39;
            this.DeleteCustomerArea.TabStop = false;
            this.DeleteCustomerArea.Text = "Delete Customer Area";
            // 
            // DeleteBirthDatePicker
            // 
            this.DeleteBirthDatePicker.Location = new System.Drawing.Point(191, 227);
            this.DeleteBirthDatePicker.Name = "DeleteBirthDatePicker";
            this.DeleteBirthDatePicker.Size = new System.Drawing.Size(148, 22);
            this.DeleteBirthDatePicker.TabIndex = 37;
            // 
            // DeleteLastNameTb
            // 
            this.DeleteLastNameTb.Location = new System.Drawing.Point(191, 194);
            this.DeleteLastNameTb.Name = "DeleteLastNameTb";
            this.DeleteLastNameTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteLastNameTb.TabIndex = 36;
            // 
            // DeleteFirstNameTb
            // 
            this.DeleteFirstNameTb.Location = new System.Drawing.Point(191, 160);
            this.DeleteFirstNameTb.Name = "DeleteFirstNameTb";
            this.DeleteFirstNameTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteFirstNameTb.TabIndex = 35;
            // 
            // DeleteIdentityNumberTb
            // 
            this.DeleteIdentityNumberTb.Location = new System.Drawing.Point(191, 130);
            this.DeleteIdentityNumberTb.Name = "DeleteIdentityNumberTb";
            this.DeleteIdentityNumberTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteIdentityNumberTb.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 33;
            this.label9.Text = "BirthDate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "LastName";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 31;
            this.label11.Text = "IdentityNumber";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 166);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "FirstName";
            // 
            // DeleteCustomerIdTb
            // 
            this.DeleteCustomerIdTb.Location = new System.Drawing.Point(191, 12);
            this.DeleteCustomerIdTb.Name = "DeleteCustomerIdTb";
            this.DeleteCustomerIdTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteCustomerIdTb.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "CustomerID";
            // 
            // DeletePhoneTb
            // 
            this.DeletePhoneTb.Location = new System.Drawing.Point(191, 101);
            this.DeletePhoneTb.Name = "DeletePhoneTb";
            this.DeletePhoneTb.Size = new System.Drawing.Size(149, 22);
            this.DeletePhoneTb.TabIndex = 24;
            // 
            // DeleteCountryTb
            // 
            this.DeleteCountryTb.Location = new System.Drawing.Point(191, 71);
            this.DeleteCountryTb.Name = "DeleteCountryTb";
            this.DeleteCountryTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteCountryTb.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Country";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Phone";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(104, 255);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(145, 36);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteCompanyNameTb
            // 
            this.DeleteCompanyNameTb.Location = new System.Drawing.Point(191, 43);
            this.DeleteCompanyNameTb.Name = "DeleteCompanyNameTb";
            this.DeleteCompanyNameTb.Size = new System.Drawing.Size(149, 22);
            this.DeleteCompanyNameTb.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "CompanyName";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 516);
            this.Controls.Add(this.DeleteCustomerArea);
            this.Controls.Add(this.UpdateCustomerArea);
            this.Controls.Add(this.AddCustomerArea);
            this.Controls.Add(this.customerDataGridView);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.AddCustomerArea.ResumeLayout(false);
            this.AddCustomerArea.PerformLayout();
            this.UpdateCustomerArea.ResumeLayout(false);
            this.UpdateCustomerArea.PerformLayout();
            this.DeleteCustomerArea.ResumeLayout(false);
            this.DeleteCustomerArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.GroupBox AddCustomerArea;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox AddCompanyNameTb;
        private System.Windows.Forms.Label CompanyName;
        private System.Windows.Forms.TextBox AddPhoneTb;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.TextBox AddCustomerIdTb;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.DateTimePicker AddBirthDatePicker;
        private System.Windows.Forms.TextBox AddLastNameTb;
        private System.Windows.Forms.TextBox AddFirstNameTb;
        private System.Windows.Forms.TextBox AddIdentityNumberTb;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label IdentityNumber;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TextBox AddCountryTb;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.GroupBox UpdateCustomerArea;
        private System.Windows.Forms.DateTimePicker UpdateBirthDatePicker;
        private System.Windows.Forms.TextBox UpdateLastNameTb;
        private System.Windows.Forms.TextBox UpdateFirstNameTb;
        private System.Windows.Forms.TextBox UpdateIdentityNumberTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UpdateCustomerIdTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UpdatePhoneTb;
        private System.Windows.Forms.TextBox UpdateCountryTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.TextBox UpdateCompanyNameTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox DeleteCustomerArea;
        private System.Windows.Forms.DateTimePicker DeleteBirthDatePicker;
        private System.Windows.Forms.TextBox DeleteLastNameTb;
        private System.Windows.Forms.TextBox DeleteFirstNameTb;
        private System.Windows.Forms.TextBox DeleteIdentityNumberTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox DeleteCustomerIdTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DeletePhoneTb;
        private System.Windows.Forms.TextBox DeleteCountryTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox DeleteCompanyNameTb;
        private System.Windows.Forms.Label label16;
    }
}