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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.findNextButton = new System.Windows.Forms.Button();
            this.replaceTextBox = new System.Windows.Forms.TextBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 193);
            this.textBox1.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(139, 292);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 1;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(220, 292);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(100, 20);
            this.findTextBox.TabIndex = 3;
            // 
            // findNextButton
            // 
            this.findNextButton.Location = new System.Drawing.Point(139, 334);
            this.findNextButton.Name = "findNextButton";
            this.findNextButton.Size = new System.Drawing.Size(75, 23);
            this.findNextButton.TabIndex = 4;
            this.findNextButton.Text = "Find Next";
            this.findNextButton.UseVisualStyleBackColor = true;
            this.findNextButton.Click += new System.EventHandler(this.findNextButton_Click);
            // 
            // replaceTextBox
            // 
            this.replaceTextBox.Location = new System.Drawing.Point(220, 377);
            this.replaceTextBox.Name = "replaceTextBox";
            this.replaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.replaceTextBox.TabIndex = 3;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(139, 377);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 5;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.findNextButton);
            this.Controls.Add(this.replaceTextBox);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.Button findNextButton;
        private System.Windows.Forms.TextBox replaceTextBox;
        private System.Windows.Forms.Button replaceButton;
    }
}

