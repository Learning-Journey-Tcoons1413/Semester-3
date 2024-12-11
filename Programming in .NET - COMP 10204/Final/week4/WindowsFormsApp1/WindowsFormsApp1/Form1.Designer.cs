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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.accountTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.checkingRadioButton = new System.Windows.Forms.RadioButton();
            this.savingRadioButton = new System.Windows.Forms.RadioButton();
            this.createButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.addTransactionButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.accountTypeGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 20);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(104, 13);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(27, 42);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(104, 39);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // accountTypeGroupBox
            // 
            this.accountTypeGroupBox.Controls.Add(this.savingRadioButton);
            this.accountTypeGroupBox.Controls.Add(this.checkingRadioButton);
            this.accountTypeGroupBox.Location = new System.Drawing.Point(30, 76);
            this.accountTypeGroupBox.Name = "accountTypeGroupBox";
            this.accountTypeGroupBox.Size = new System.Drawing.Size(200, 100);
            this.accountTypeGroupBox.TabIndex = 2;
            this.accountTypeGroupBox.TabStop = false;
            this.accountTypeGroupBox.Text = "Account Type";
            // 
            // checkingRadioButton
            // 
            this.checkingRadioButton.AutoSize = true;
            this.checkingRadioButton.Location = new System.Drawing.Point(19, 20);
            this.checkingRadioButton.Name = "checkingRadioButton";
            this.checkingRadioButton.Size = new System.Drawing.Size(113, 17);
            this.checkingRadioButton.TabIndex = 0;
            this.checkingRadioButton.TabStop = true;
            this.checkingRadioButton.Text = "Checking Account";
            this.checkingRadioButton.UseVisualStyleBackColor = true;
            // 
            // savingRadioButton
            // 
            this.savingRadioButton.AutoSize = true;
            this.savingRadioButton.Location = new System.Drawing.Point(19, 43);
            this.savingRadioButton.Name = "savingRadioButton";
            this.savingRadioButton.Size = new System.Drawing.Size(101, 17);
            this.savingRadioButton.TabIndex = 1;
            this.savingRadioButton.TabStop = true;
            this.savingRadioButton.Text = "Saving Account";
            this.savingRadioButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(30, 196);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(155, 196);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTransactionButton);
            this.groupBox1.Controls.Add(this.amountTextBox);
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.depositRadioButton);
            this.groupBox1.Controls.Add(this.withdrawRadioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.currentBalanceLabel);
            this.groupBox1.Controls.Add(this.currentBalanceTextBox);
            this.groupBox1.Controls.Add(this.accountNumberTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(289, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #";
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Location = new System.Drawing.Point(100, 26);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.accountNumberTextBox.TabIndex = 1;
            // 
            // currentBalanceTextBox
            // 
            this.currentBalanceTextBox.Location = new System.Drawing.Point(324, 26);
            this.currentBalanceTextBox.Name = "currentBalanceTextBox";
            this.currentBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentBalanceTextBox.TabIndex = 2;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(235, 29);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(83, 13);
            this.currentBalanceLabel.TabIndex = 3;
            this.currentBalanceLabel.Text = "Current Balance";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 147);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Transaction";
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Location = new System.Drawing.Point(13, 281);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioButton.TabIndex = 6;
            this.withdrawRadioButton.TabStop = true;
            this.withdrawRadioButton.Text = "Withdraw";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Location = new System.Drawing.Point(13, 304);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(61, 17);
            this.depositRadioButton.TabIndex = 7;
            this.depositRadioButton.TabStop = true;
            this.depositRadioButton.Text = "Deposit";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(13, 338);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 8;
            this.amountLabel.Text = "Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(77, 335);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 9;
            // 
            // addTransactionButton
            // 
            this.addTransactionButton.Location = new System.Drawing.Point(10, 376);
            this.addTransactionButton.Name = "addTransactionButton";
            this.addTransactionButton.Size = new System.Drawing.Size(167, 36);
            this.addTransactionButton.TabIndex = 10;
            this.addTransactionButton.Text = "Add Transaction";
            this.addTransactionButton.UseVisualStyleBackColor = true;
            this.addTransactionButton.Click += new System.EventHandler(this.addTransactionButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(27, 419);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.accountTypeGroupBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.accountTypeGroupBox.ResumeLayout(false);
            this.accountTypeGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox accountTypeGroupBox;
        private System.Windows.Forms.RadioButton savingRadioButton;
        private System.Windows.Forms.RadioButton checkingRadioButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton depositRadioButton;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.TextBox currentBalanceTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTransactionButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

