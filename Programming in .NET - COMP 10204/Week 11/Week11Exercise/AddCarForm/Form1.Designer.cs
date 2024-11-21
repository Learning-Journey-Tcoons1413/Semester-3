namespace Week11Exercise
{
    partial class AddCarForm
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
            this.makeLabel = new System.Windows.Forms.Label();
            this.makeCarGroupBox = new System.Windows.Forms.GroupBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.yearUpDown = new System.Windows.Forms.NumericUpDown();
            this.makeCarGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(32, 53);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(49, 20);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make";
            // 
            // makeCarGroupBox
            // 
            this.makeCarGroupBox.Controls.Add(this.yearUpDown);
            this.makeCarGroupBox.Controls.Add(this.closeButton);
            this.makeCarGroupBox.Controls.Add(this.addCarButton);
            this.makeCarGroupBox.Controls.Add(this.modelTextBox);
            this.makeCarGroupBox.Controls.Add(this.makeTextBox);
            this.makeCarGroupBox.Controls.Add(this.yearLabel);
            this.makeCarGroupBox.Controls.Add(this.modelLabel);
            this.makeCarGroupBox.Controls.Add(this.makeLabel);
            this.makeCarGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeCarGroupBox.Location = new System.Drawing.Point(48, 40);
            this.makeCarGroupBox.Name = "makeCarGroupBox";
            this.makeCarGroupBox.Size = new System.Drawing.Size(347, 304);
            this.makeCarGroupBox.TabIndex = 1;
            this.makeCarGroupBox.TabStop = false;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(32, 88);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(54, 20);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(32, 125);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(43, 20);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "Year";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(132, 50);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(170, 27);
            this.makeTextBox.TabIndex = 3;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(132, 85);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(170, 27);
            this.modelTextBox.TabIndex = 3;
            // 
            // addCarButton
            // 
            this.addCarButton.Location = new System.Drawing.Point(36, 211);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(124, 39);
            this.addCarButton.TabIndex = 4;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(181, 211);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 39);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // yearUpDown
            // 
            this.yearUpDown.Location = new System.Drawing.Point(132, 125);
            this.yearUpDown.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.yearUpDown.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.yearUpDown.Name = "yearUpDown";
            this.yearUpDown.Size = new System.Drawing.Size(170, 27);
            this.yearUpDown.TabIndex = 5;
            this.yearUpDown.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 394);
            this.Controls.Add(this.makeCarGroupBox);
            this.Name = "AddCarForm";
            this.Text = "Add Car Form";
            this.makeCarGroupBox.ResumeLayout(false);
            this.makeCarGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.GroupBox makeCarGroupBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.NumericUpDown yearUpDown;
    }
}

