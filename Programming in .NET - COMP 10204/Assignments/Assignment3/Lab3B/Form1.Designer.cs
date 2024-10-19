namespace Lab3B
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
            this.selectHairdresserGroupBox = new System.Windows.Forms.GroupBox();
            this.hairdresserComboBox = new System.Windows.Forms.ComboBox();
            this.selectServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.selectServiceListBox = new System.Windows.Forms.ListBox();
            this.chargedItemsListBox = new System.Windows.Forms.ListBox();
            this.chargedItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.priceGroupBox = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.selectHairdresserGroupBox.SuspendLayout();
            this.selectServiceGroupBox.SuspendLayout();
            this.chargedItemsGroupBox.SuspendLayout();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectHairdresserGroupBox
            // 
            this.selectHairdresserGroupBox.Controls.Add(this.hairdresserComboBox);
            this.selectHairdresserGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectHairdresserGroupBox.Location = new System.Drawing.Point(12, 12);
            this.selectHairdresserGroupBox.Name = "selectHairdresserGroupBox";
            this.selectHairdresserGroupBox.Size = new System.Drawing.Size(200, 233);
            this.selectHairdresserGroupBox.TabIndex = 1;
            this.selectHairdresserGroupBox.TabStop = false;
            this.selectHairdresserGroupBox.Text = "Select a Hairdresser";
            // 
            // hairdresserComboBox
            // 
            this.hairdresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hairdresserComboBox.FormattingEnabled = true;
            this.hairdresserComboBox.Location = new System.Drawing.Point(6, 19);
            this.hairdresserComboBox.Name = "hairdresserComboBox";
            this.hairdresserComboBox.Size = new System.Drawing.Size(149, 24);
            this.hairdresserComboBox.TabIndex = 0;
            // 
            // selectServiceGroupBox
            // 
            this.selectServiceGroupBox.Controls.Add(this.selectServiceListBox);
            this.selectServiceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectServiceGroupBox.Location = new System.Drawing.Point(232, 12);
            this.selectServiceGroupBox.Name = "selectServiceGroupBox";
            this.selectServiceGroupBox.Size = new System.Drawing.Size(200, 233);
            this.selectServiceGroupBox.TabIndex = 2;
            this.selectServiceGroupBox.TabStop = false;
            this.selectServiceGroupBox.Text = "Select a Service";
            // 
            // selectServiceListBox
            // 
            this.selectServiceListBox.FormattingEnabled = true;
            this.selectServiceListBox.ItemHeight = 16;
            this.selectServiceListBox.Location = new System.Drawing.Point(6, 19);
            this.selectServiceListBox.Name = "selectServiceListBox";
            this.selectServiceListBox.Size = new System.Drawing.Size(188, 196);
            this.selectServiceListBox.TabIndex = 0;
            this.selectServiceListBox.Click += new System.EventHandler(this.selectServiceListBox_Click);
            // 
            // chargedItemsListBox
            // 
            this.chargedItemsListBox.FormattingEnabled = true;
            this.chargedItemsListBox.ItemHeight = 16;
            this.chargedItemsListBox.Location = new System.Drawing.Point(6, 19);
            this.chargedItemsListBox.Name = "chargedItemsListBox";
            this.chargedItemsListBox.ScrollAlwaysVisible = true;
            this.chargedItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chargedItemsListBox.Size = new System.Drawing.Size(188, 196);
            this.chargedItemsListBox.TabIndex = 0;
            // 
            // chargedItemsGroupBox
            // 
            this.chargedItemsGroupBox.Controls.Add(this.chargedItemsListBox);
            this.chargedItemsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargedItemsGroupBox.Location = new System.Drawing.Point(453, 12);
            this.chargedItemsGroupBox.Name = "chargedItemsGroupBox";
            this.chargedItemsGroupBox.Size = new System.Drawing.Size(200, 233);
            this.chargedItemsGroupBox.TabIndex = 3;
            this.chargedItemsGroupBox.TabStop = false;
            this.chargedItemsGroupBox.Text = "Charged Items";
            // 
            // priceGroupBox
            // 
            this.priceGroupBox.Controls.Add(this.priceListBox);
            this.priceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceGroupBox.Location = new System.Drawing.Point(672, 12);
            this.priceGroupBox.Name = "priceGroupBox";
            this.priceGroupBox.Size = new System.Drawing.Size(140, 233);
            this.priceGroupBox.TabIndex = 4;
            this.priceGroupBox.TabStop = false;
            this.priceGroupBox.Text = "Price";
            // 
            // priceListBox
            // 
            this.priceListBox.FormatString = "C2";
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(6, 19);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.ScrollAlwaysVisible = true;
            this.priceListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.priceListBox.Size = new System.Drawing.Size(128, 196);
            this.priceListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(179, 300);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 37);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Service";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(337, 300);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(152, 37);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Total Price";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(495, 300);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(152, 37);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset ";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(653, 300);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 37);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(624, 272);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(75, 16);
            this.totalPriceLabel.TabIndex = 9;
            this.totalPriceLabel.Text = "Total Price:";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(705, 268);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPriceTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 356);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.chargedItemsGroupBox);
            this.Controls.Add(this.selectServiceGroupBox);
            this.Controls.Add(this.selectHairdresserGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.selectHairdresserGroupBox.ResumeLayout(false);
            this.selectServiceGroupBox.ResumeLayout(false);
            this.chargedItemsGroupBox.ResumeLayout(false);
            this.priceGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox selectHairdresserGroupBox;
        private System.Windows.Forms.ComboBox hairdresserComboBox;
        private System.Windows.Forms.GroupBox selectServiceGroupBox;
        private System.Windows.Forms.ListBox selectServiceListBox;
        private System.Windows.Forms.ListBox chargedItemsListBox;
        private System.Windows.Forms.GroupBox chargedItemsGroupBox;
        private System.Windows.Forms.GroupBox priceGroupBox;
        private System.Windows.Forms.ListBox priceListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TextBox totalPriceTextBox;
    }
}

