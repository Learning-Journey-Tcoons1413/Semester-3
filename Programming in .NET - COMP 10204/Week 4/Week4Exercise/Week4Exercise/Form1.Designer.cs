namespace Week4Exercise
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextbox = new System.Windows.Forms.TextBox();
            this.LastNameTextbox = new System.Windows.Forms.TextBox();
            this.accountTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.savingAccountRadioBtn = new System.Windows.Forms.RadioButton();
            this.checkingAccountRadioBtn = new System.Windows.Forms.RadioButton();
            this.accountInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.addTransactionBtn = new System.Windows.Forms.Button();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addTransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.depositRadioBtn = new System.Windows.Forms.RadioButton();
            this.withdrawRadioBtn = new System.Windows.Forms.RadioButton();
            this.currentBalanceTextbox = new System.Windows.Forms.TextBox();
            this.currentBalanceLabel = new System.Windows.Forms.Label();
            this.accountNumberTextbox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.transactionLabel = new System.Windows.Forms.Label();
            this.transactionsListBox = new System.Windows.Forms.ListBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.accountTypeGroupBox.SuspendLayout();
            this.accountInformationGroupBox.SuspendLayout();
            this.addTransactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.Location = new System.Drawing.Point(34, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(78, 16);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name: ";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.Location = new System.Drawing.Point(34, 81);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(78, 16);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name: ";
            // 
            // FirstNameTextbox
            // 
            this.FirstNameTextbox.Location = new System.Drawing.Point(118, 36);
            this.FirstNameTextbox.Name = "FirstNameTextbox";
            this.FirstNameTextbox.Size = new System.Drawing.Size(145, 20);
            this.FirstNameTextbox.TabIndex = 2;
            // 
            // LastNameTextbox
            // 
            this.LastNameTextbox.Location = new System.Drawing.Point(118, 76);
            this.LastNameTextbox.Name = "LastNameTextbox";
            this.LastNameTextbox.Size = new System.Drawing.Size(145, 20);
            this.LastNameTextbox.TabIndex = 3;
            // 
            // accountTypeGroupBox
            // 
            this.accountTypeGroupBox.Controls.Add(this.savingAccountRadioBtn);
            this.accountTypeGroupBox.Controls.Add(this.checkingAccountRadioBtn);
            this.accountTypeGroupBox.Location = new System.Drawing.Point(294, 23);
            this.accountTypeGroupBox.Name = "accountTypeGroupBox";
            this.accountTypeGroupBox.Size = new System.Drawing.Size(226, 100);
            this.accountTypeGroupBox.TabIndex = 4;
            this.accountTypeGroupBox.TabStop = false;
            this.accountTypeGroupBox.Text = "Account Type";
            // 
            // savingAccountRadioBtn
            // 
            this.savingAccountRadioBtn.AutoSize = true;
            this.savingAccountRadioBtn.Location = new System.Drawing.Point(6, 53);
            this.savingAccountRadioBtn.Name = "savingAccountRadioBtn";
            this.savingAccountRadioBtn.Size = new System.Drawing.Size(101, 17);
            this.savingAccountRadioBtn.TabIndex = 1;
            this.savingAccountRadioBtn.Text = "Saving Account";
            this.savingAccountRadioBtn.UseVisualStyleBackColor = true;
            // 
            // checkingAccountRadioBtn
            // 
            this.checkingAccountRadioBtn.AutoSize = true;
            this.checkingAccountRadioBtn.Checked = true;
            this.checkingAccountRadioBtn.Location = new System.Drawing.Point(6, 29);
            this.checkingAccountRadioBtn.Name = "checkingAccountRadioBtn";
            this.checkingAccountRadioBtn.Size = new System.Drawing.Size(113, 17);
            this.checkingAccountRadioBtn.TabIndex = 0;
            this.checkingAccountRadioBtn.TabStop = true;
            this.checkingAccountRadioBtn.Text = "Checking Account";
            this.checkingAccountRadioBtn.UseVisualStyleBackColor = true;
            // 
            // accountInformationGroupBox
            // 
            this.accountInformationGroupBox.Controls.Add(this.statusLabel);
            this.accountInformationGroupBox.Controls.Add(this.addTransactionBtn);
            this.accountInformationGroupBox.Controls.Add(this.amountTextbox);
            this.accountInformationGroupBox.Controls.Add(this.amountLabel);
            this.accountInformationGroupBox.Controls.Add(this.addTransactionGroupBox);
            this.accountInformationGroupBox.Controls.Add(this.currentBalanceTextbox);
            this.accountInformationGroupBox.Controls.Add(this.currentBalanceLabel);
            this.accountInformationGroupBox.Controls.Add(this.accountNumberTextbox);
            this.accountInformationGroupBox.Controls.Add(this.accountNumberLabel);
            this.accountInformationGroupBox.Controls.Add(this.transactionLabel);
            this.accountInformationGroupBox.Controls.Add(this.transactionsListBox);
            this.accountInformationGroupBox.Enabled = false;
            this.accountInformationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInformationGroupBox.Location = new System.Drawing.Point(21, 145);
            this.accountInformationGroupBox.Name = "accountInformationGroupBox";
            this.accountInformationGroupBox.Size = new System.Drawing.Size(720, 323);
            this.accountInformationGroupBox.TabIndex = 6;
            this.accountInformationGroupBox.TabStop = false;
            this.accountInformationGroupBox.Text = "Account Information";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 296);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "Status";
            // 
            // addTransactionBtn
            // 
            this.addTransactionBtn.Location = new System.Drawing.Point(415, 248);
            this.addTransactionBtn.Name = "addTransactionBtn";
            this.addTransactionBtn.Size = new System.Drawing.Size(241, 37);
            this.addTransactionBtn.TabIndex = 9;
            this.addTransactionBtn.Text = "Add Transaction";
            this.addTransactionBtn.UseVisualStyleBackColor = true;
            this.addTransactionBtn.Click += new System.EventHandler(this.addTransactionBtn_Click);
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(485, 217);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(175, 22);
            this.amountTextbox.TabIndex = 8;
            this.amountTextbox.Text = "0.00";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(412, 217);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(52, 16);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Amount";
            // 
            // addTransactionGroupBox
            // 
            this.addTransactionGroupBox.Controls.Add(this.depositRadioBtn);
            this.addTransactionGroupBox.Controls.Add(this.withdrawRadioBtn);
            this.addTransactionGroupBox.Location = new System.Drawing.Point(412, 105);
            this.addTransactionGroupBox.Name = "addTransactionGroupBox";
            this.addTransactionGroupBox.Size = new System.Drawing.Size(248, 91);
            this.addTransactionGroupBox.TabIndex = 6;
            this.addTransactionGroupBox.TabStop = false;
            this.addTransactionGroupBox.Text = "Add Transaction";
            // 
            // depositRadioBtn
            // 
            this.depositRadioBtn.AutoSize = true;
            this.depositRadioBtn.Checked = true;
            this.depositRadioBtn.Location = new System.Drawing.Point(7, 59);
            this.depositRadioBtn.Name = "depositRadioBtn";
            this.depositRadioBtn.Size = new System.Drawing.Size(72, 20);
            this.depositRadioBtn.TabIndex = 1;
            this.depositRadioBtn.TabStop = true;
            this.depositRadioBtn.Text = "Deposit";
            this.depositRadioBtn.UseVisualStyleBackColor = true;
            // 
            // withdrawRadioBtn
            // 
            this.withdrawRadioBtn.AutoSize = true;
            this.withdrawRadioBtn.Location = new System.Drawing.Point(7, 32);
            this.withdrawRadioBtn.Name = "withdrawRadioBtn";
            this.withdrawRadioBtn.Size = new System.Drawing.Size(80, 20);
            this.withdrawRadioBtn.TabIndex = 0;
            this.withdrawRadioBtn.TabStop = true;
            this.withdrawRadioBtn.Text = "Withdraw";
            this.withdrawRadioBtn.UseVisualStyleBackColor = true;
            // 
            // currentBalanceTextbox
            // 
            this.currentBalanceTextbox.Location = new System.Drawing.Point(532, 30);
            this.currentBalanceTextbox.Name = "currentBalanceTextbox";
            this.currentBalanceTextbox.ReadOnly = true;
            this.currentBalanceTextbox.Size = new System.Drawing.Size(128, 22);
            this.currentBalanceTextbox.TabIndex = 5;
            // 
            // currentBalanceLabel
            // 
            this.currentBalanceLabel.AutoSize = true;
            this.currentBalanceLabel.Location = new System.Drawing.Point(409, 33);
            this.currentBalanceLabel.Name = "currentBalanceLabel";
            this.currentBalanceLabel.Size = new System.Drawing.Size(102, 16);
            this.currentBalanceLabel.TabIndex = 4;
            this.currentBalanceLabel.Text = "Current Balance";
            // 
            // accountNumberTextbox
            // 
            this.accountNumberTextbox.Location = new System.Drawing.Point(98, 33);
            this.accountNumberTextbox.Name = "accountNumberTextbox";
            this.accountNumberTextbox.ReadOnly = true;
            this.accountNumberTextbox.Size = new System.Drawing.Size(128, 22);
            this.accountNumberTextbox.TabIndex = 3;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.AutoSize = true;
            this.accountNumberLabel.Location = new System.Drawing.Point(9, 36);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(62, 16);
            this.accountNumberLabel.TabIndex = 2;
            this.accountNumberLabel.Text = "Account#";
            // 
            // transactionLabel
            // 
            this.transactionLabel.AutoSize = true;
            this.transactionLabel.Location = new System.Drawing.Point(6, 86);
            this.transactionLabel.Name = "transactionLabel";
            this.transactionLabel.Size = new System.Drawing.Size(85, 16);
            this.transactionLabel.TabIndex = 0;
            this.transactionLabel.Text = "Transactions";
            // 
            // transactionsListBox
            // 
            this.transactionsListBox.FormattingEnabled = true;
            this.transactionsListBox.ItemHeight = 16;
            this.transactionsListBox.Location = new System.Drawing.Point(6, 105);
            this.transactionsListBox.Name = "transactionsListBox";
            this.transactionsListBox.Size = new System.Drawing.Size(374, 164);
            this.transactionsListBox.TabIndex = 1;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(539, 32);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(119, 27);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Location = new System.Drawing.Point(539, 69);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 27);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 480);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.accountInformationGroupBox);
            this.Controls.Add(this.accountTypeGroupBox);
            this.Controls.Add(this.LastNameTextbox);
            this.Controls.Add(this.FirstNameTextbox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.accountTypeGroupBox.ResumeLayout(false);
            this.accountTypeGroupBox.PerformLayout();
            this.accountInformationGroupBox.ResumeLayout(false);
            this.accountInformationGroupBox.PerformLayout();
            this.addTransactionGroupBox.ResumeLayout(false);
            this.addTransactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextbox;
        private System.Windows.Forms.TextBox LastNameTextbox;
        private System.Windows.Forms.GroupBox accountTypeGroupBox;
        private System.Windows.Forms.RadioButton savingAccountRadioBtn;
        private System.Windows.Forms.RadioButton checkingAccountRadioBtn;
        private System.Windows.Forms.GroupBox accountInformationGroupBox;
        private System.Windows.Forms.GroupBox addTransactionGroupBox;
        private System.Windows.Forms.RadioButton depositRadioBtn;
        private System.Windows.Forms.RadioButton withdrawRadioBtn;
        private System.Windows.Forms.TextBox currentBalanceTextbox;
        private System.Windows.Forms.Label currentBalanceLabel;
        private System.Windows.Forms.TextBox accountNumberTextbox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label transactionLabel;
        private System.Windows.Forms.ListBox transactionsListBox;
        private System.Windows.Forms.Button addTransactionBtn;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label statusLabel;
    }
}

