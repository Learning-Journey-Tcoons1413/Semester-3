namespace Week9_StringsFiles
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
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.LabelUnitPrice = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.UnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TitleTextBox1 = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.TotalValueLabel = new System.Windows.Forms.Label();
            this.TotalValueTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.ItemHeight = 16;
            this.ProductsListBox.Location = new System.Drawing.Point(80, 60);
            this.ProductsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(737, 164);
            this.ProductsListBox.TabIndex = 0;
            this.ProductsListBox.SelectedIndexChanged += new System.EventHandler(this.ProductsListBox_SelectedIndexChanged);
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(80, 284);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(61, 16);
            this.NumberLabel.TabIndex = 3;
            this.NumberLabel.Text = "Number";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(80, 329);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 16);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(80, 366);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 16);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Type";
            // 
            // LabelUnitPrice
            // 
            this.LabelUnitPrice.AutoSize = true;
            this.LabelUnitPrice.Location = new System.Drawing.Point(80, 410);
            this.LabelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelUnitPrice.Name = "LabelUnitPrice";
            this.LabelUnitPrice.Size = new System.Drawing.Size(74, 16);
            this.LabelUnitPrice.TabIndex = 6;
            this.LabelUnitPrice.Text = "Unit Price";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(80, 453);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(63, 16);
            this.QuantityLabel.TabIndex = 7;
            this.QuantityLabel.Text = "Quantity";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(210, 284);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.ReadOnly = true;
            this.NumberTextBox.Size = new System.Drawing.Size(220, 22);
            this.NumberTextBox.TabIndex = 8;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(210, 362);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.ReadOnly = true;
            this.TypeTextBox.Size = new System.Drawing.Size(220, 22);
            this.TypeTextBox.TabIndex = 8;
            // 
            // UnitPriceTextBox
            // 
            this.UnitPriceTextBox.Location = new System.Drawing.Point(210, 401);
            this.UnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitPriceTextBox.Name = "UnitPriceTextBox";
            this.UnitPriceTextBox.Size = new System.Drawing.Size(220, 22);
            this.UnitPriceTextBox.TabIndex = 8;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(210, 444);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(220, 22);
            this.QuantityTextBox.TabIndex = 8;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(80, 537);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(176, 32);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // TitleTextBox1
            // 
            this.TitleTextBox1.Location = new System.Drawing.Point(210, 320);
            this.TitleTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTextBox1.Name = "TitleTextBox1";
            this.TitleTextBox1.ReadOnly = true;
            this.TitleTextBox1.Size = new System.Drawing.Size(220, 22);
            this.TitleTextBox1.TabIndex = 8;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(84, 496);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(47, 16);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Value";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(210, 487);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.ReadOnly = true;
            this.ValueTextBox.Size = new System.Drawing.Size(220, 22);
            this.ValueTextBox.TabIndex = 8;
            // 
            // TotalValueLabel
            // 
            this.TotalValueLabel.AutoSize = true;
            this.TotalValueLabel.Location = new System.Drawing.Point(861, 64);
            this.TotalValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalValueLabel.Name = "TotalValueLabel";
            this.TotalValueLabel.Size = new System.Drawing.Size(87, 16);
            this.TotalValueLabel.TabIndex = 11;
            this.TotalValueLabel.Text = "Total Value";
            // 
            // TotalValueTextBox
            // 
            this.TotalValueTextBox.Location = new System.Drawing.Point(977, 60);
            this.TotalValueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalValueTextBox.Name = "TotalValueTextBox";
            this.TotalValueTextBox.ReadOnly = true;
            this.TotalValueTextBox.Size = new System.Drawing.Size(200, 22);
            this.TotalValueTextBox.TabIndex = 12;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(309, 537);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 31);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 601);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.TotalValueTextBox);
            this.Controls.Add(this.TotalValueLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.UnitPriceTextBox);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.TitleTextBox1);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.LabelUnitPrice);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsListBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductsListBox;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label LabelUnitPrice;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;

        private System.Windows.Forms.TextBox UnitPriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox TitleTextBox1;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label TotalValueLabel;
        private System.Windows.Forms.TextBox TotalValueTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

