namespace LabExerciseWeek7
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
            this.asciiLabel = new System.Windows.Forms.Label();
            this.asciiTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearStringTextBox = new System.Windows.Forms.TextBox();
            this.encryptStringTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asciiLabel
            // 
            this.asciiLabel.AutoSize = true;
            this.asciiLabel.Location = new System.Drawing.Point(26, 41);
            this.asciiLabel.Name = "asciiLabel";
            this.asciiLabel.Size = new System.Drawing.Size(86, 13);
            this.asciiLabel.TabIndex = 0;
            this.asciiLabel.Text = "The ASCII Table";
            // 
            // asciiTextBox
            // 
            this.asciiTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asciiTextBox.Location = new System.Drawing.Point(29, 70);
            this.asciiTextBox.Multiline = true;
            this.asciiTextBox.Name = "asciiTextBox";
            this.asciiTextBox.Size = new System.Drawing.Size(425, 241);
            this.asciiTextBox.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(29, 331);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(112, 36);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearStringTextBox
            // 
            this.clearStringTextBox.Location = new System.Drawing.Point(29, 386);
            this.clearStringTextBox.Name = "clearStringTextBox";
            this.clearStringTextBox.Size = new System.Drawing.Size(425, 20);
            this.clearStringTextBox.TabIndex = 3;
            // 
            // encryptStringTextBox
            // 
            this.encryptStringTextBox.Location = new System.Drawing.Point(29, 430);
            this.encryptStringTextBox.Name = "encryptStringTextBox";
            this.encryptStringTextBox.ReadOnly = true;
            this.encryptStringTextBox.Size = new System.Drawing.Size(425, 20);
            this.encryptStringTextBox.TabIndex = 4;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(29, 483);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(112, 36);
            this.encryptButton.TabIndex = 5;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(342, 483);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(112, 36);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 559);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encryptStringTextBox);
            this.Controls.Add(this.clearStringTextBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.asciiTextBox);
            this.Controls.Add(this.asciiLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label asciiLabel;
        private System.Windows.Forms.TextBox asciiTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox clearStringTextBox;
        private System.Windows.Forms.TextBox encryptStringTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
    }
}

