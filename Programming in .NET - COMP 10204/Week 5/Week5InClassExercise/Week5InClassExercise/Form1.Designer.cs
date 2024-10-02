namespace Week5InClassExercise
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.employeeTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.commisionRadioButton = new System.Windows.Forms.RadioButton();
            this.hourylRadioButton = new System.Windows.Forms.RadioButton();
            this.salaryRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.weeklySalaryLabel = new System.Windows.Forms.Label();
            this.weeklySalaryTextBox = new System.Windows.Forms.TextBox();
            this.weeklyHoursLabel = new System.Windows.Forms.Label();
            this.weeklyHoursTextBox = new System.Windows.Forms.TextBox();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.hourlyRateTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.commisionRateLabel = new System.Windows.Forms.Label();
            this.commisionRateTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalSalaryLabel = new System.Windows.Forms.Label();
            this.totalSalaryTextBox = new System.Windows.Forms.TextBox();
            this.salaryGroupBox = new System.Windows.Forms.GroupBox();
            this.hourlyGroupBox = new System.Windows.Forms.GroupBox();
            this.commisionGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeTypeGroupBox.SuspendLayout();
            this.salaryGroupBox.SuspendLayout();
            this.hourlyGroupBox.SuspendLayout();
            this.commisionGroupBox.SuspendLayout();
            this.employeeInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 33);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(70, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 65);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(70, 58);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 96);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 4;
            this.idLabel.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(70, 93);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // employeeTypeGroupBox
            // 
            this.employeeTypeGroupBox.Controls.Add(this.commisionRadioButton);
            this.employeeTypeGroupBox.Controls.Add(this.hourylRadioButton);
            this.employeeTypeGroupBox.Controls.Add(this.salaryRadioButton);
            this.employeeTypeGroupBox.Location = new System.Drawing.Point(282, 64);
            this.employeeTypeGroupBox.Name = "employeeTypeGroupBox";
            this.employeeTypeGroupBox.Size = new System.Drawing.Size(510, 61);
            this.employeeTypeGroupBox.TabIndex = 6;
            this.employeeTypeGroupBox.TabStop = false;
            this.employeeTypeGroupBox.Text = "Employee Type";
            // 
            // commisionRadioButton
            // 
            this.commisionRadioButton.AutoSize = true;
            this.commisionRadioButton.Location = new System.Drawing.Point(373, 26);
            this.commisionRadioButton.Name = "commisionRadioButton";
            this.commisionRadioButton.Size = new System.Drawing.Size(75, 17);
            this.commisionRadioButton.TabIndex = 2;
            this.commisionRadioButton.TabStop = true;
            this.commisionRadioButton.Text = "Commision";
            this.commisionRadioButton.UseVisualStyleBackColor = true;
            this.commisionRadioButton.CheckedChanged += new System.EventHandler(this.commisionRadioButton_CheckedChanged);
            // 
            // hourylRadioButton
            // 
            this.hourylRadioButton.AutoSize = true;
            this.hourylRadioButton.Location = new System.Drawing.Point(216, 26);
            this.hourylRadioButton.Name = "hourylRadioButton";
            this.hourylRadioButton.Size = new System.Drawing.Size(55, 17);
            this.hourylRadioButton.TabIndex = 1;
            this.hourylRadioButton.TabStop = true;
            this.hourylRadioButton.Text = "Hourly";
            this.hourylRadioButton.UseVisualStyleBackColor = true;
            this.hourylRadioButton.CheckedChanged += new System.EventHandler(this.hourylRadioButton_CheckedChanged);
            // 
            // salaryRadioButton
            // 
            this.salaryRadioButton.AutoSize = true;
            this.salaryRadioButton.Location = new System.Drawing.Point(46, 28);
            this.salaryRadioButton.Name = "salaryRadioButton";
            this.salaryRadioButton.Size = new System.Drawing.Size(54, 17);
            this.salaryRadioButton.TabIndex = 0;
            this.salaryRadioButton.TabStop = true;
            this.salaryRadioButton.Text = "Salary";
            this.salaryRadioButton.UseVisualStyleBackColor = true;
            this.salaryRadioButton.CheckedChanged += new System.EventHandler(this.salaryRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // weeklySalaryLabel
            // 
            this.weeklySalaryLabel.AutoSize = true;
            this.weeklySalaryLabel.Location = new System.Drawing.Point(9, 29);
            this.weeklySalaryLabel.Name = "weeklySalaryLabel";
            this.weeklySalaryLabel.Size = new System.Drawing.Size(75, 13);
            this.weeklySalaryLabel.TabIndex = 8;
            this.weeklySalaryLabel.Text = "Weekly Salary";
            // 
            // weeklySalaryTextBox
            // 
            this.weeklySalaryTextBox.Location = new System.Drawing.Point(12, 56);
            this.weeklySalaryTextBox.Name = "weeklySalaryTextBox";
            this.weeklySalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.weeklySalaryTextBox.TabIndex = 9;
            // 
            // weeklyHoursLabel
            // 
            this.weeklyHoursLabel.AutoSize = true;
            this.weeklyHoursLabel.Location = new System.Drawing.Point(6, 29);
            this.weeklyHoursLabel.Name = "weeklyHoursLabel";
            this.weeklyHoursLabel.Size = new System.Drawing.Size(74, 13);
            this.weeklyHoursLabel.TabIndex = 10;
            this.weeklyHoursLabel.Text = "Weekly Hours";
            // 
            // weeklyHoursTextBox
            // 
            this.weeklyHoursTextBox.Location = new System.Drawing.Point(6, 55);
            this.weeklyHoursTextBox.Name = "weeklyHoursTextBox";
            this.weeklyHoursTextBox.Size = new System.Drawing.Size(100, 20);
            this.weeklyHoursTextBox.TabIndex = 11;
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(6, 95);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(63, 13);
            this.hourlyRateLabel.TabIndex = 12;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // hourlyRateTextBox
            // 
            this.hourlyRateTextBox.Location = new System.Drawing.Point(6, 122);
            this.hourlyRateTextBox.Name = "hourlyRateTextBox";
            this.hourlyRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.hourlyRateTextBox.TabIndex = 13;
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Location = new System.Drawing.Point(6, 26);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(60, 13);
            this.totalSalesLabel.TabIndex = 14;
            this.totalSalesLabel.Text = "Total Sales";
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.Location = new System.Drawing.Point(6, 52);
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalesTextBox.TabIndex = 15;
            // 
            // commisionRateLabel
            // 
            this.commisionRateLabel.AutoSize = true;
            this.commisionRateLabel.Location = new System.Drawing.Point(9, 92);
            this.commisionRateLabel.Name = "commisionRateLabel";
            this.commisionRateLabel.Size = new System.Drawing.Size(100, 13);
            this.commisionRateLabel.TabIndex = 16;
            this.commisionRateLabel.Text = "Commision Rate (%)";
            // 
            // commisionRateTextBox
            // 
            this.commisionRateTextBox.Location = new System.Drawing.Point(6, 118);
            this.commisionRateTextBox.Name = "commisionRateTextBox";
            this.commisionRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.commisionRateTextBox.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(282, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(510, 199);
            this.listBox1.TabIndex = 18;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(108, 309);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(118, 34);
            this.addEmployeeButton.TabIndex = 19;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(108, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 34);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(108, 420);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(118, 34);
            this.readButton.TabIndex = 21;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(108, 474);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 34);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // totalSalaryLabel
            // 
            this.totalSalaryLabel.AutoSize = true;
            this.totalSalaryLabel.Location = new System.Drawing.Point(282, 525);
            this.totalSalaryLabel.Name = "totalSalaryLabel";
            this.totalSalaryLabel.Size = new System.Drawing.Size(63, 13);
            this.totalSalaryLabel.TabIndex = 23;
            this.totalSalaryLabel.Text = "Total Salary";
            // 
            // totalSalaryTextBox
            // 
            this.totalSalaryTextBox.Location = new System.Drawing.Point(366, 522);
            this.totalSalaryTextBox.Name = "totalSalaryTextBox";
            this.totalSalaryTextBox.ReadOnly = true;
            this.totalSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalaryTextBox.TabIndex = 24;
            // 
            // salaryGroupBox
            // 
            this.salaryGroupBox.Controls.Add(this.weeklySalaryLabel);
            this.salaryGroupBox.Controls.Add(this.weeklySalaryTextBox);
            this.salaryGroupBox.Location = new System.Drawing.Point(298, 131);
            this.salaryGroupBox.Name = "salaryGroupBox";
            this.salaryGroupBox.Size = new System.Drawing.Size(133, 172);
            this.salaryGroupBox.TabIndex = 25;
            this.salaryGroupBox.TabStop = false;
            this.salaryGroupBox.Text = "Salary";
            // 
            // hourlyGroupBox
            // 
            this.hourlyGroupBox.Controls.Add(this.weeklyHoursLabel);
            this.hourlyGroupBox.Controls.Add(this.weeklyHoursTextBox);
            this.hourlyGroupBox.Controls.Add(this.hourlyRateLabel);
            this.hourlyGroupBox.Controls.Add(this.hourlyRateTextBox);
            this.hourlyGroupBox.Location = new System.Drawing.Point(470, 131);
            this.hourlyGroupBox.Name = "hourlyGroupBox";
            this.hourlyGroupBox.Size = new System.Drawing.Size(120, 172);
            this.hourlyGroupBox.TabIndex = 26;
            this.hourlyGroupBox.TabStop = false;
            this.hourlyGroupBox.Text = "Hourly";
            // 
            // commisionGroupBox
            // 
            this.commisionGroupBox.Controls.Add(this.totalSalesLabel);
            this.commisionGroupBox.Controls.Add(this.totalSalesTextBox);
            this.commisionGroupBox.Controls.Add(this.commisionRateLabel);
            this.commisionGroupBox.Controls.Add(this.commisionRateTextBox);
            this.commisionGroupBox.Location = new System.Drawing.Point(630, 134);
            this.commisionGroupBox.Name = "commisionGroupBox";
            this.commisionGroupBox.Size = new System.Drawing.Size(125, 169);
            this.commisionGroupBox.TabIndex = 27;
            this.commisionGroupBox.TabStop = false;
            this.commisionGroupBox.Text = "Commison";
            // 
            // employeeInfoGroupBox
            // 
            this.employeeInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.employeeInfoGroupBox.Controls.Add(this.firstNameTextBox);
            this.employeeInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.employeeInfoGroupBox.Controls.Add(this.lastNameTextBox);
            this.employeeInfoGroupBox.Controls.Add(this.idLabel);
            this.employeeInfoGroupBox.Controls.Add(this.idTextBox);
            this.employeeInfoGroupBox.Location = new System.Drawing.Point(61, 64);
            this.employeeInfoGroupBox.Name = "employeeInfoGroupBox";
            this.employeeInfoGroupBox.Size = new System.Drawing.Size(187, 162);
            this.employeeInfoGroupBox.TabIndex = 28;
            this.employeeInfoGroupBox.TabStop = false;
            this.employeeInfoGroupBox.Text = "Employee Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 562);
            this.Controls.Add(this.employeeInfoGroupBox);
            this.Controls.Add(this.commisionGroupBox);
            this.Controls.Add(this.hourlyGroupBox);
            this.Controls.Add(this.salaryGroupBox);
            this.Controls.Add(this.totalSalaryTextBox);
            this.Controls.Add(this.totalSalaryLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeTypeGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.employeeTypeGroupBox.ResumeLayout(false);
            this.employeeTypeGroupBox.PerformLayout();
            this.salaryGroupBox.ResumeLayout(false);
            this.salaryGroupBox.PerformLayout();
            this.hourlyGroupBox.ResumeLayout(false);
            this.hourlyGroupBox.PerformLayout();
            this.commisionGroupBox.ResumeLayout(false);
            this.commisionGroupBox.PerformLayout();
            this.employeeInfoGroupBox.ResumeLayout(false);
            this.employeeInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.GroupBox employeeTypeGroupBox;
        private System.Windows.Forms.RadioButton commisionRadioButton;
        private System.Windows.Forms.RadioButton hourylRadioButton;
        private System.Windows.Forms.RadioButton salaryRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label weeklySalaryLabel;
        private System.Windows.Forms.TextBox weeklySalaryTextBox;
        private System.Windows.Forms.Label weeklyHoursLabel;
        private System.Windows.Forms.TextBox weeklyHoursTextBox;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.TextBox hourlyRateTextBox;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        private System.Windows.Forms.Label commisionRateLabel;
        private System.Windows.Forms.TextBox commisionRateTextBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalSalaryLabel;
        private System.Windows.Forms.TextBox totalSalaryTextBox;
        private System.Windows.Forms.GroupBox salaryGroupBox;
        private System.Windows.Forms.GroupBox hourlyGroupBox;
        private System.Windows.Forms.GroupBox commisionGroupBox;
        private System.Windows.Forms.GroupBox employeeInfoGroupBox;
    }
}

