namespace PayRollForm
{
    partial class FormPayrollSystem
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
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.radioButtonCommission = new System.Windows.Forms.RadioButton();
            this.radioButtonHourly = new System.Windows.Forms.RadioButton();
            this.radioButtonSalary = new System.Windows.Forms.RadioButton();
            this.groupBoxSalary = new System.Windows.Forms.GroupBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.groupBoxHourly = new System.Windows.Forms.GroupBox();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.textBoxHoursWorked = new System.Windows.Forms.TextBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.groupBoxCommission = new System.Windows.Forms.GroupBox();
            this.textBoxCommisionRate = new System.Windows.Forms.TextBox();
            this.labelCommision = new System.Windows.Forms.Label();
            this.textBoxTotalSales = new System.Windows.Forms.TextBox();
            this.labelSales = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalPayroll = new System.Windows.Forms.TextBox();
            this.saveEmployeeFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openEmployeeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.AutoFormFill = new System.Windows.Forms.Button();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxSalary.SuspendLayout();
            this.groupBoxHourly.SuspendLayout();
            this.groupBoxCommission.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.radioButtonCommission);
            this.groupBoxEmployee.Controls.Add(this.radioButtonHourly);
            this.groupBoxEmployee.Controls.Add(this.radioButtonSalary);
            this.groupBoxEmployee.Location = new System.Drawing.Point(75, 146);
            this.groupBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxEmployee.Size = new System.Drawing.Size(709, 50);
            this.groupBoxEmployee.TabIndex = 3;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee Type";
            // 
            // radioButtonCommission
            // 
            this.radioButtonCommission.AutoSize = true;
            this.radioButtonCommission.Location = new System.Drawing.Point(512, 23);
            this.radioButtonCommission.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCommission.Name = "radioButtonCommission";
            this.radioButtonCommission.Size = new System.Drawing.Size(92, 20);
            this.radioButtonCommission.TabIndex = 2;
            this.radioButtonCommission.Text = "Commision";
            this.radioButtonCommission.UseVisualStyleBackColor = true;
            // 
            // radioButtonHourly
            // 
            this.radioButtonHourly.AutoSize = true;
            this.radioButtonHourly.Location = new System.Drawing.Point(251, 23);
            this.radioButtonHourly.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonHourly.Name = "radioButtonHourly";
            this.radioButtonHourly.Size = new System.Drawing.Size(64, 20);
            this.radioButtonHourly.TabIndex = 1;
            this.radioButtonHourly.Text = "Hourly";
            this.radioButtonHourly.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalary
            // 
            this.radioButtonSalary.AutoSize = true;
            this.radioButtonSalary.Checked = true;
            this.radioButtonSalary.Location = new System.Drawing.Point(27, 22);
            this.radioButtonSalary.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSalary.Name = "radioButtonSalary";
            this.radioButtonSalary.Size = new System.Drawing.Size(64, 20);
            this.radioButtonSalary.TabIndex = 0;
            this.radioButtonSalary.TabStop = true;
            this.radioButtonSalary.Text = "Salary";
            this.radioButtonSalary.UseVisualStyleBackColor = true;
            // 
            // groupBoxSalary
            // 
            this.groupBoxSalary.Controls.Add(this.textBoxSalary);
            this.groupBoxSalary.Controls.Add(this.labelSalary);
            this.groupBoxSalary.Location = new System.Drawing.Point(75, 204);
            this.groupBoxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSalary.Name = "groupBoxSalary";
            this.groupBoxSalary.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSalary.Size = new System.Drawing.Size(197, 145);
            this.groupBoxSalary.TabIndex = 4;
            this.groupBoxSalary.TabStop = false;
            this.groupBoxSalary.Text = "Salary";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(27, 52);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(132, 22);
            this.textBoxSalary.TabIndex = 0;
            this.textBoxSalary.Text = "850";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(25, 32);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(95, 16);
            this.labelSalary.TabIndex = 0;
            this.labelSalary.Text = "Weekly Salary";
            // 
            // groupBoxHourly
            // 
            this.groupBoxHourly.Controls.Add(this.textBoxHourlyRate);
            this.groupBoxHourly.Controls.Add(this.labelHourlyRate);
            this.groupBoxHourly.Controls.Add(this.textBoxHoursWorked);
            this.groupBoxHourly.Controls.Add(this.labelHours);
            this.groupBoxHourly.Location = new System.Drawing.Point(325, 204);
            this.groupBoxHourly.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxHourly.Name = "groupBoxHourly";
            this.groupBoxHourly.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxHourly.Size = new System.Drawing.Size(197, 145);
            this.groupBoxHourly.TabIndex = 5;
            this.groupBoxHourly.TabStop = false;
            this.groupBoxHourly.Text = "Hourly";
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(27, 113);
            this.textBoxHourlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(132, 22);
            this.textBoxHourlyRate.TabIndex = 1;
            this.textBoxHourlyRate.Text = "16.50";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(25, 94);
            this.labelHourlyRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(78, 16);
            this.labelHourlyRate.TabIndex = 0;
            this.labelHourlyRate.Text = "Hourly Rate";
            // 
            // textBoxHoursWorked
            // 
            this.textBoxHoursWorked.Location = new System.Drawing.Point(27, 52);
            this.textBoxHoursWorked.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHoursWorked.Name = "textBoxHoursWorked";
            this.textBoxHoursWorked.Size = new System.Drawing.Size(132, 22);
            this.textBoxHoursWorked.TabIndex = 0;
            this.textBoxHoursWorked.Text = "40";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(25, 32);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(92, 16);
            this.labelHours.TabIndex = 0;
            this.labelHours.Text = "Weekly Hours";
            // 
            // groupBoxCommission
            // 
            this.groupBoxCommission.Controls.Add(this.textBoxCommisionRate);
            this.groupBoxCommission.Controls.Add(this.labelCommision);
            this.groupBoxCommission.Controls.Add(this.textBoxTotalSales);
            this.groupBoxCommission.Controls.Add(this.labelSales);
            this.groupBoxCommission.Location = new System.Drawing.Point(587, 204);
            this.groupBoxCommission.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCommission.Name = "groupBoxCommission";
            this.groupBoxCommission.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCommission.Size = new System.Drawing.Size(197, 145);
            this.groupBoxCommission.TabIndex = 6;
            this.groupBoxCommission.TabStop = false;
            this.groupBoxCommission.Text = "Commission";
            // 
            // textBoxCommisionRate
            // 
            this.textBoxCommisionRate.Location = new System.Drawing.Point(27, 113);
            this.textBoxCommisionRate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCommisionRate.Name = "textBoxCommisionRate";
            this.textBoxCommisionRate.Size = new System.Drawing.Size(132, 22);
            this.textBoxCommisionRate.TabIndex = 1;
            this.textBoxCommisionRate.Text = "16.50";
            // 
            // labelCommision
            // 
            this.labelCommision.AutoSize = true;
            this.labelCommision.Location = new System.Drawing.Point(25, 94);
            this.labelCommision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCommision.Name = "labelCommision";
            this.labelCommision.Size = new System.Drawing.Size(136, 16);
            this.labelCommision.TabIndex = 0;
            this.labelCommision.Text = "Commission Rate (%)";
            // 
            // textBoxTotalSales
            // 
            this.textBoxTotalSales.Location = new System.Drawing.Point(27, 52);
            this.textBoxTotalSales.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalSales.Name = "textBoxTotalSales";
            this.textBoxTotalSales.Size = new System.Drawing.Size(132, 22);
            this.textBoxTotalSales.TabIndex = 0;
            this.textBoxTotalSales.Text = "10000";
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(25, 32);
            this.labelSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(76, 16);
            this.labelSales.TabIndex = 0;
            this.labelSales.Text = "Total Sales";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(71, 55);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(72, 16);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(193, 52);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(387, 55);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(72, 16);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(509, 52);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(71, 102);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(137, 102);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(188, 22);
            this.textBoxID.TabIndex = 2;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(75, 399);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(125, 39);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Add Employee";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 16;
            this.listBoxEmployee.Location = new System.Drawing.Point(245, 402);
            this.listBoxEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(676, 244);
            this.listBoxEmployee.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(75, 465);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(125, 39);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(75, 530);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(125, 39);
            this.buttonRead.TabIndex = 9;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(75, 602);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(125, 46);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 667);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Salary";
            // 
            // textBoxTotalPayroll
            // 
            this.textBoxTotalPayroll.Location = new System.Drawing.Point(355, 663);
            this.textBoxTotalPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotalPayroll.Name = "textBoxTotalPayroll";
            this.textBoxTotalPayroll.ReadOnly = true;
            this.textBoxTotalPayroll.Size = new System.Drawing.Size(132, 22);
            this.textBoxTotalPayroll.TabIndex = 12;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(823, 667);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(97, 364);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 14;
            // 
            // AutoFormFill
            // 
            this.AutoFormFill.Location = new System.Drawing.Point(992, 59);
            this.AutoFormFill.Name = "AutoFormFill";
            this.AutoFormFill.Size = new System.Drawing.Size(154, 29);
            this.AutoFormFill.TabIndex = 15;
            this.AutoFormFill.Text = "Auto Form Fill";
            this.AutoFormFill.UseVisualStyleBackColor = true;
            // 
            // FormPayrollSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 729);
            this.Controls.Add(this.AutoFormFill);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxTotalPayroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.groupBoxCommission);
            this.Controls.Add(this.groupBoxHourly);
            this.Controls.Add(this.groupBoxSalary);
            this.Controls.Add(this.groupBoxEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPayrollSystem";
            this.Text = "Payroll System - (Developed for COMP10204 - .NET)";
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxSalary.ResumeLayout(false);
            this.groupBoxSalary.PerformLayout();
            this.groupBoxHourly.ResumeLayout(false);
            this.groupBoxHourly.PerformLayout();
            this.groupBoxCommission.ResumeLayout(false);
            this.groupBoxCommission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.RadioButton radioButtonCommission;
        private System.Windows.Forms.RadioButton radioButtonHourly;
        private System.Windows.Forms.RadioButton radioButtonSalary;
        private System.Windows.Forms.GroupBox groupBoxSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.GroupBox groupBoxHourly;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.TextBox textBoxHoursWorked;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.GroupBox groupBoxCommission;
        private System.Windows.Forms.TextBox textBoxCommisionRate;
        private System.Windows.Forms.Label labelCommision;
        private System.Windows.Forms.TextBox textBoxTotalSales;
        private System.Windows.Forms.Label labelSales;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotalPayroll;
        private System.Windows.Forms.SaveFileDialog saveEmployeeFileDialog;
        private System.Windows.Forms.OpenFileDialog openEmployeeFileDialog;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button AutoFormFill;
    }
}

