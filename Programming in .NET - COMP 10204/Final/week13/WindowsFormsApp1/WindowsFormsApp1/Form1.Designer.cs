namespace WindowsFormsApp1
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
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.testLabel = new System.Windows.Forms.Label();
            this.sortLastNameButton = new System.Windows.Forms.Button();
            this.sortBySallaryButton = new System.Windows.Forms.Button();
            this.sortByIdButton = new System.Windows.Forms.Button();
            this.addEmployeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeListBox
            // 
            this.employeeListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 16;
            this.employeeListBox.Location = new System.Drawing.Point(218, 12);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(925, 340);
            this.employeeListBox.TabIndex = 0;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(215, 355);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 16);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Status:";
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 326);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(200, 26);
            this.addEmployeeButton.TabIndex = 3;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // addEmployeeGroupBox
            // 
            this.addEmployeeGroupBox.Controls.Add(this.textBox6);
            this.addEmployeeGroupBox.Controls.Add(this.textBox5);
            this.addEmployeeGroupBox.Controls.Add(this.textBox4);
            this.addEmployeeGroupBox.Controls.Add(this.textBox3);
            this.addEmployeeGroupBox.Controls.Add(this.textBox2);
            this.addEmployeeGroupBox.Controls.Add(this.textBox1);
            this.addEmployeeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addEmployeeGroupBox.Name = "addEmployeeGroupBox";
            this.addEmployeeGroupBox.Size = new System.Drawing.Size(200, 309);
            this.addEmployeeGroupBox.TabIndex = 2;
            this.addEmployeeGroupBox.TabStop = false;
            this.addEmployeeGroupBox.Text = "Add Employee";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 0;
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(12, 358);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(200, 28);
            this.deleteEmployeeButton.TabIndex = 4;
            this.deleteEmployeeButton.Text = "Delete Employee";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(15, 427);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(35, 13);
            this.testLabel.TabIndex = 5;
            this.testLabel.Text = "label1";
            // 
            // sortLastNameButton
            // 
            this.sortLastNameButton.Location = new System.Drawing.Point(218, 374);
            this.sortLastNameButton.Name = "sortLastNameButton";
            this.sortLastNameButton.Size = new System.Drawing.Size(113, 41);
            this.sortLastNameButton.TabIndex = 6;
            this.sortLastNameButton.Text = "Sort By Lastname";
            this.sortLastNameButton.UseVisualStyleBackColor = true;
            this.sortLastNameButton.Click += new System.EventHandler(this.sortLastNameButton_Click);
            // 
            // sortBySallaryButton
            // 
            this.sortBySallaryButton.Location = new System.Drawing.Point(337, 374);
            this.sortBySallaryButton.Name = "sortBySallaryButton";
            this.sortBySallaryButton.Size = new System.Drawing.Size(113, 41);
            this.sortBySallaryButton.TabIndex = 7;
            this.sortBySallaryButton.Text = "Sort By Salary";
            this.sortBySallaryButton.UseVisualStyleBackColor = true;
            this.sortBySallaryButton.Click += new System.EventHandler(this.sortBySallaryButton_Click);
            // 
            // sortByIdButton
            // 
            this.sortByIdButton.Location = new System.Drawing.Point(456, 374);
            this.sortByIdButton.Name = "sortByIdButton";
            this.sortByIdButton.Size = new System.Drawing.Size(113, 41);
            this.sortByIdButton.TabIndex = 8;
            this.sortByIdButton.Text = "Sort By ID";
            this.sortByIdButton.UseVisualStyleBackColor = true;
            this.sortByIdButton.Click += new System.EventHandler(this.sortByIdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 500);
            this.Controls.Add(this.sortByIdButton);
            this.Controls.Add(this.sortBySallaryButton);
            this.Controls.Add(this.sortLastNameButton);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.addEmployeeGroupBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.employeeListBox);
            this.Name = "Form1";
            this.Text = "Tom\'s Plumbing";
            this.addEmployeeGroupBox.ResumeLayout(false);
            this.addEmployeeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox employeeListBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.GroupBox addEmployeeGroupBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button sortLastNameButton;
        private System.Windows.Forms.Button sortBySallaryButton;
        private System.Windows.Forms.Button sortByIdButton;
    }
}

